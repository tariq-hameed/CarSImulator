namespace CarSImulator.Domain
{
    class Car
    {
        private string brand;
        private string model;

        public Car(string brand, string model)
        {

            this.brand = brand;
            this.model = model;
        }
        //public string Brand
        //{
        //    get
        //    {

        //        return brand;
        //    }
        //    set
        //    {
        //        brand = value.Length > 4
        //        ? value.Substring(0, 4)
        //        : value;
        //    }

        //}
        public string Brandd()
        {
            return model;
        }
        public string Model
        {

            get
            {
                return model;
            }
        }
    }
}
