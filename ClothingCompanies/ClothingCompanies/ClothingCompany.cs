using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingCompanies
{
    class ClothingCompany: IClothingCompany
    {
        private string _name;
        private double _purchaseThreshold;

        public ClothingCompany(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Fabric fabric)
        {
            Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} per meter.", _name, fabric.GetType().Name, fabric.PricePerMeter);
            if (fabric.PricePerMeter < _purchaseThreshold)
            {
                Console.WriteLine(_name + " wants to buy some " + fabric.GetType().Name + "!");
            }
        }
    }
}
