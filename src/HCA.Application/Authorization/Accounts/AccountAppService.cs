using System.Threading.Tasks;
using Abp.Configuration;
using Abp.Zero.Configuration;
using HCA.Authorization.Accounts.Dto;
using HCA.Authorization.Users;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers.Bases;
using System.Collections.Generic;

namespace HCA.Authorization.Accounts
{
    public class AccountAppService : HCAAppServiceBase, IAccountAppService
    {
        private string MERCHANT_LOGIN_ID = "57ECcr6Q";
        private string MERCHANT_TRANSACTION_KEY = "2LG4v33MH68hMzca";

        public const string PasswordRegex = "(?=^.{8,}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\\s)[0-9a-zA-Z!@#$%^&*()]*$";

        private readonly UserRegistrationManager _userRegistrationManager;

        public AccountAppService(UserRegistrationManager userRegistrationManager)
        {
            _userRegistrationManager = userRegistrationManager;
        }

        public async Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input)
        {
            var tenant = await TenantManager.FindByTenancyNameAsync(input.TenancyName);
            if (tenant == null)
            {
                return new IsTenantAvailableOutput(TenantAvailabilityState.NotFound);
            }

            if (!tenant.IsActive)
            {
                return new IsTenantAvailableOutput(TenantAvailabilityState.InActive);
            }

            return new IsTenantAvailableOutput(TenantAvailabilityState.Available, tenant.Id);
        }

        public async Task<createCustomerProfileResponse> CreateCustomerProfile(CustomerProfileDto input)
        {
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = MERCHANT_LOGIN_ID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = MERCHANT_TRANSACTION_KEY,
            };

            var creditCard = new creditCardType
            {
                cardNumber = input.CardNumber.Replace(" ", ""),
                cardCode = input.Cvv,
                expirationDate = input.Expiry.Replace("/", "")
            };

            var billto = new customerAddressType
            {
                firstName = input.b_FirstName,
                lastName = input.b_LastName,
                company = input.Company,
                address = input.b_Address,
                state = input.b_State,
                city = input.b_City,
                zip = input.b_ZipCode,
                country = "USA",
                phoneNumber = input.PhoneNumber
            };

            paymentType cc = new paymentType { Item = creditCard };
            List<customerPaymentProfileType> paymentProfileList = new List<customerPaymentProfileType>();

            customerPaymentProfileType ccPaymentProfile = new customerPaymentProfileType();
            ccPaymentProfile.payment = cc;
            ccPaymentProfile.billTo = billto;
            ccPaymentProfile.customerType = customerTypeEnum.individual;

            paymentProfileList.Add(ccPaymentProfile);

            List<customerAddressType> addressInfoList = new List<customerAddressType>();
            customerAddressType address = new customerAddressType();
            address.firstName = input.FirstName;
            address.lastName = input.LastName;
            address.address = input.Address;
            address.state = input.State;
            address.city = input.City;
            address.zip = input.ZipCode;
            address.country = "USA";
            addressInfoList.Add(address);

            customerProfileType customerProfile = new customerProfileType();
            customerProfile.email = input.Email;
            customerProfile.paymentProfiles = paymentProfileList.ToArray();
            customerProfile.shipToList = addressInfoList.ToArray();

            var request = new createCustomerProfileRequest
            {
                profile = customerProfile,
                validationModeSpecified = true,
                validationMode = validationModeEnum.testMode
            };

            var controller = new createCustomerProfileController(request);
            controller.Execute();

            createCustomerProfileResponse response = controller.GetApiResponse();
            return response;
        }

        public async Task<createTransactionResponse> ChargeCustomerProfile(ChargeCustomerProfileDto input)
        {
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = MERCHANT_LOGIN_ID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = MERCHANT_TRANSACTION_KEY,
            };

            customerProfilePaymentType profileToCharge = new customerProfilePaymentType();
            profileToCharge.customerProfileId = input.CustomerProfileId;
            profileToCharge.paymentProfile = new paymentProfile
            {
                paymentProfileId = input.PaymentProfileId
            };

            var order = new orderType
            {
                invoiceNumber = input.InvoiceNumber
            };

            var transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = input.Amount,
                profile = profileToCharge,
                order = order
            };

            var request = new createTransactionRequest { transactionRequest = transactionRequest };

            var controller = new createTransactionController(request);
            controller.Execute();

            var response = controller.GetApiResponse();
            return response;
        }

        public async Task<int> IsTenantAvailableGetId(IsTenantAvailableInput input)
        {
            var tenant = await TenantManager.FindByTenancyNameAsync(input.TenancyName);
            if (tenant == null)
            {
                return 0;
            }

            if (!tenant.IsActive)
            {
                return 0;
            }

            return tenant.Id;
        }

        public async Task<RegisterOutput> Register(RegisterInput input)
        {
            //var user = await _userRegistrationManager.RegisterAsync(
            //    input.Name,
            //    input.Name,
            //    input.Email,
            //    input.Name,
            //    input.p,
            //    true // Assumed email address is always confirmed. Change this if you want to implement email confirmation.
            //);

            var isEmailConfirmationRequiredForLogin = await SettingManager.GetSettingValueAsync<bool>(AbpZeroSettingNames.UserManagement.IsEmailConfirmationRequiredForLogin);

            return new RegisterOutput
            {
                //CanLogin = user.IsActive && (user.IsEmailConfirmed || !isEmailConfirmationRequiredForLogin)
            };
        }
    }
}