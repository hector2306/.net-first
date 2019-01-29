using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1
{
    public class Washer : Electro_domestic
    {
        public Washer()
        {
            base();
        }

        void CheckColor() { }

        void CheckPrice()
        {
            price = 200;
            Console.WriteLine(price);
        }
    }

}
