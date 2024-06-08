using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace HCA.Authorization
{
    public class HCAAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Dashboard, L("Dashboard"));

            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Create, L("UsersCreation"));
            context.CreatePermission(PermissionNames.Pages_Users_Edit, L("UsersEdition"));
            context.CreatePermission(PermissionNames.Pages_Users_Delete, L("UsersDeletion"));
            
            
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Roles_Create, L("RolesCreation"));
            context.CreatePermission(PermissionNames.Pages_Roles_Edit, L("RolesEdition"));
            context.CreatePermission(PermissionNames.Pages_Roles_Delete, L("RolesDeletion"));

            context.CreatePermission(PermissionNames.Pages_Settings, L("Settings"));
            
            context.CreatePermission(PermissionNames.Pages_Industry, L("Industry"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Industry_Create, L("IndustryCreation"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Industry_Edit, L("IndustryEdition"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Industry_Delete, L("IndustryDeletion"), multiTenancySides: MultiTenancySides.Host);


            context.CreatePermission(PermissionNames.Pages_Technician, L("Technician"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Technician_Create, L("TechnicianCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Technician_Edit, L("TechnicianEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Technician_Delete, L("TechnicianDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Shifts, L("Shifts"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Shifts_Create, L("ShiftsCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Shifts_Edit, L("ShiftsEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Shifts_Delete, L("ShiftsDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_CrewGroup, L("CrewGroup"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_CrewGroup_Create, L("CrewGroupCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_CrewGroup_Edit, L("CrewGroupEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_CrewGroup_Delete, L("CrewGroupDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Services, L("Services"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Services_Create, L("ServicesCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Services_Edit, L("ServicesEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Services_Delete, L("ServicesDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Parts, L("Parts"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Parts_Create, L("PartsCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Parts_Edit, L("PartsEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Parts_Delete, L("PartsDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Clients, L("Clients"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Clients_Create, L("ClientsCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Clients_Edit, L("ClientsEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Clients_Delete, L("ClientsDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Contracts, L("Contracts"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Contracts_Create, L("ContractsCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Contracts_Edit, L("ContractsEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Contracts_Delete, L("ContractsDeletion"), multiTenancySides: MultiTenancySides.Tenant);


            context.CreatePermission(PermissionNames.Pages_Jobs, L("Jobs"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Jobs_Create, L("JobsCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Jobs_Edit, L("JobsEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Jobs_Delete, L("JobsDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Dispatch, L("Dispatch"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Dispatch_Create, L("DispatchCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Dispatch_Edit, L("DispatchEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Dispatch_Delete, L("DispatchDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Schedule, L("Schedule"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Schedule_Create, L("ScheduleCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Schedule_Edit, L("ScheduleEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Schedule_Delete, L("ScheduleDeletion"), multiTenancySides: MultiTenancySides.Tenant);


            context.CreatePermission(PermissionNames.Pages_Payables, L("Payables"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Payables_Create, L("PayablesCreation"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Payables_Edit, L("PayablesEdition"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Payables_Delete, L("PayablesDeletion"), multiTenancySides: MultiTenancySides.Tenant);

            context.CreatePermission(PermissionNames.Pages_Package, L("Package"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Package_Create, L("PackageCreation"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Package_Edit, L("PackageEdition"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Package_Delete, L("PackageDeletion"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Tenants_Create, L("TenantsCreation"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Tenants_Edit, L("TenantsEdition"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Tenants_Delete, L("TenantsDeletion"), multiTenancySides: MultiTenancySides.Host);
            
          }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, HCAConsts.LocalizationSourceName);
        }
    }
}
