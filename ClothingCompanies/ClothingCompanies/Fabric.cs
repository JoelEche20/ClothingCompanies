using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingCompanies
{
    public abstract class Fabric
    {
        private double _pricePerMeter;
        private List<IClothingCompany> __companies = new List<IClothingCompany>();

        public Fabric(double pricePerMeter)
        {
            _pricePerMeter = pricePerMeter;
        }

        public void Attach(IClothingCompany clothingCompany)
        {
            __companies.Add(clothingCompany);
        }

        public void Detach(IClothingCompany clothingCompany)
        {
            __companies.Remove(clothingCompany);
        } 

        public void Notify()
        {
            foreach (IClothingCompany company in __companies)
            {
                company.Update(this);
            }
        }

        public double PricePerMeter
        {
            get { return _pricePerMeter; }
            set
            {
                if (_pricePerMeter != value)
                {
                    _pricePerMeter = value;
                    Notify();
                }
            }
        }
    }
}
