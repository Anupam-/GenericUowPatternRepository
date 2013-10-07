namespace Entities
{
    public class Enumerations
    {
        public enum Gender
        {
            Male = 2,
            Female = 1
        }

        public enum CitizenType
        {
            USCitizen = 1,
            PermanentResident = 2,
            Other = 99
        }

        public enum AddressType
        {
            Permanent = 1,
            Mailing = 2,
            Business = 3,
            PermanentSpouse = 4,
            MailingSpouse = 5
        }
    }
}
