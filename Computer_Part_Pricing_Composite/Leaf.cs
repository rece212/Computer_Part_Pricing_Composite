using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Part_Pricing_Composite
{
    //inherits from Items to ba able to use properties
    //overrides the inherited calculate method
    public class Leaf : Items
    {

        public Leaf(string name, int price):base(name, price) {}


        public override int CalculateTotalPrice()
        {
            Console.WriteLine(name + " with the price " + price);
            return price;
        }



    }
}
