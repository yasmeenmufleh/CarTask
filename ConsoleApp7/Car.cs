namespace CarTask
{
    public class Car
    {
        public string Make { get; set; }
        public string NumberOfDoors { get; set; }
        public string BodyStyle { get; set; }
        public string EngineLocation { get; set; }
        public string NumberOfCylinders { get; set; }
        public int? HorsePower { get; set; }
        public int? Price { get; set; }

        public override string ToString()
        {
            string str = $"{this.Make},{this.NumberOfDoors},{this.BodyStyle},{this.EngineLocation},{this.NumberOfCylinders}" +
                         $",{this.HorsePower},{this.Price}";
            return str;
        }
    }
}