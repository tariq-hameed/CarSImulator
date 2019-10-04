namespace CarSImulator.Domain
{
    class Car
    {
        private string brand;
        private string model;
        private string registrationNumber;

        public Car(string brand, string model, string registrationNumber)
        {

            this.brand = brand;
            this.model = model;
            this.registrationNumber = registrationNumber;
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
        public string GetBrand()
        {
            return brand;
        }
        public string GetModel
        {

            get
            {
                return model;
            }
        }
        public string GetRegistrationNumber()
        {

            return registrationNumber;
        }
    }
}
