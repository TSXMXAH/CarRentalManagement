namespace CarRentalManagement.Domain
{
    public class Vehicle : BaseDomainModel //#Inherit Abstract Class
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; } //Foreign Key #1
        public int ModelId { get; set; } //Foreign Key #2
        public int colourId { get; set; } //Foreign Key #3
    }
}
