namespace BicycleApp.Common
{
    public static class EntityValidationConstants
    {
        public static class User
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 30;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 30;

            public const int PhoneNumberMaxLength = 30;

            public const int DelivaryAddressMaxLength = 200;

            public const int IBANMaxLength = 40;

            public const int PositionMinLength = 3;
            public const int PositionMaxLength = 50;
        }

        public static class Town
        {
            public const int TownNameMinLength = 3;
            public const int TownNameMaxLength = 50;
        }

        public static class Department
        {
            public const int DepartmentNameMinLength = 3;
            public const int DepartmentNameMaxLength = 50;
        }

        public static class Part
        {
            public const int PartNameMinLength = 3;
            public const int PartNameMaxLength = 100;

            public const int PartDescriptionMaxLength = 1000;

            public const int PartOEMMaxLength = 50;

            public const int PartUnitMinLength = 1;
            public const int PartUnitMaxLength = 20;
        }

        public static class CompatiblePart
        {
            public const int CompatiblePartNameMinLength = 3;
            public const int CompatiblePartNameMaxLength = 100;
        }

        public static class PartCategory
        {
            public const int PartCategoryNameMinLength = 3;
            public const int PartCategoryNameMaxLength = 20;
        }

        public static class Suplier
        {
            public const int SuplierNameMinLength = 3;
            public const int SuplierNameMaxLength = 100;

            public const int VATNumberMinLength = 9;
            public const int VATNumberMaxLength = 20;

            public const int AddressMinLength = 3;
            public const int AddressMaxLength = 100;

            public const int PhoneNumberMaxLength = 20;

            public const int EmailMaxLength = 50;

            public const int ContactNameMinLength = 3;
            public const int ContactNameMaxLength = 100;
        }

        public static class Coment
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 30;

            public const int DescriptionMinLength = 1;
            public const int DescriptionMaxLength = 2000;
        }

        public static class Order
        {
            public const int SerialNumberLength = 11;
        }

        public static class Status
        {
            public const int StatusNameMinLength = 3;
            public const int StatusNameMaxLength = 20;      
        }

        public static class BikeModel
        {
            public const int BikeModelNameMinLength = 1;
            public const int BikeModelNameMaxLength = 50;
        }
    }
}
