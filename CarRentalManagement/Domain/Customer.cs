namespace CarRentalManagement.Domain
{
    public class Customer : BaseDomainModel //#Inherit Abstract Class
    {
        public string? DrivingLicense { get; set; }
        public string? Address { get; set; }
        public string? CustomerName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
