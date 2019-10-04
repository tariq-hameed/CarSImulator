namespace CarSImulator.Domain
{
    class Car
    {
        //private string brand;
        //private string model;
        private string registrationNumber;
        

        public Car(string brand, string model, string registrationNumber)
        {

            //this.brand = brand;
            //this.model = model;
            //this.registrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;

        }

        //public string GetBrand()
        //{
        //    return brand;
        //}
        public string Brand { get; }
        public string Model { get; }
        //public string GetModel
        //{

        //    get
        //    {
        //        return model;
        //    }
        //}
        //public string GetRegistrationNumber()
        public string RegistrationNumber
        {

            //return registrationNumber;
            get
            {
                return registrationNumber;
            }
            set
            {
                if (value.Length > 6)
                {
                    registrationNumber = value.Substring(0, 6);
                }
                else
                {
                    registrationNumber = value;
                }
            }
        }
        


    }
}
