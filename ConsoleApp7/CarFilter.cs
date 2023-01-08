namespace CarTask
{
    public class CarFilter
    {
        public string Make { get; set; }
        public int? MinHorsePower { get; set; }
        public int? MaxHorsePower { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string NumberOfDoors { get; set; }
        public string NumberOfCylinders { get; set; }
    }
}