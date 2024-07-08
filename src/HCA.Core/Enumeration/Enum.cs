using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Enumeration
{
    public enum TaskStatuses
    {
        Pending,
        InProgress,
        Completed,
        Cancelled
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum AudienceType
    {
        Profession,
        Age,
        Gender,
        Area,
        City
    }

    public enum SocialMediaChannel
    {
        WhatsApp,
        SMS,
        Facebook,
        YouTube,
        Instagram
    }

    public enum Services
    {
        Diagnostic = 0,
        Repair = 1,
        Warranty = 2
    }

    public enum AssociatedServiceType
    {
        DiagnosticService = 0,
        RepairService = 1
    }

    public enum SecAdvAmtType
    {
        FullPrice = 0,
        Percentage = 1
    }

    public enum WarrantyDuration
    {
        Days = 0,
        Months = 1
    }

    public enum MarkupType
    {
        Amount = 0,
        Percentage = 1
    }

    public enum SiteType
    {
        Residential = 0,
        Commercial = 1
    }

    public enum Stories
    {
        Single = 0,
        Multi = 1
    }

    public enum IndustryStatus
    {
        Active = 1,
        Deactivated = 0,
        Draft = 2
    }

    public enum PackageType
    {
        Trial = 0,
        Paid = 1
    }

    public enum EmploymentType
    {
        W2Employee = 0,
        Contractor1099 = 1
    }

    public enum CompensationType
    {
        Hourly = 0,
        Salary = 1
    }

    public enum TechIncentiveType
    {
        None = 0,
        perJob = 1,
        perHour = 2,
        perPercentage = 3
    }

    public enum ShiftFrequency
    {
        Daily = 0,
        Weekly = 1,
        Montlhy = 2
    }

    public enum ShiftType
    {
        AfterHours = 0,
        Emergency = 1,
        HolidayShift = 2,
        Normal = 3
    }

    public enum AttachmentType
    {
        Certification = 0,
        Education = 1,
        ExperienceCertificate = 2,
        ProfilePic = 3
    }

    public enum ContractFrequency
    {
        Weekly = 0,
        BiWeekly = 1,
        Monthly = 2,
        Quarterly = 3,
        BiAnually = 4,
        Annually = 5
    }

    //public enum TechType
    //{
    //    SuperTech = 0,
    //    Supervisor = 1,
    //    FieldTech = 2
    //}
    public enum SectionName
    {
        //PredefinedSection = 0,
        //EmploymentTypeSection = 1,
        HeaderSection = 0,

        PredefinedSection = 1,
        CustomerSection = 2,
        PropertyDetailSection = 3,
        JobDetailsSection = 4,
        DetailSection = 5,
        AssignmentSection = 6,
        TaskProgressSection = 7,
        AdditionalInformationSection = 8,
        JobCompletionSection = 9,
        JobReviewSection = 10,
        ApprovalSection = 11,
        BillingSection = 12,
        AttachmentSection = 13
    }

    public enum FieldType
    {
        None = 0,
        Label = 1,
        TextBox = 2,
        Dropdown = 3,
        DateTime = 4,
        RadioEdit = 5,
        CheckBox = 6,
    }

    public enum MapUrl
    {
        //Profile = 0,
        //JobScheduler = 1,
        //EmploymentType = 2,
        //AddIndustry = 3,
        //Dispatch = 4
        Profile = 0,

        JobBuilder = 1,
        EmploymentType = 2
    }

    public enum SubscriptionType
    {
        Downgrade = 0,
        Subscribe = 1,
        Upgrade = 2
    }
}