using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Electro_domestic
    {
        //declaration of the variables
        private double price;
        private string color;
        private double weight;


        public Electro_domestic()
        {
            this.price = 100;
            this.color = "white";
            this.weight = 5;

        }

        //constructor
        public Electro_domestic(double price, double weight)
        {
            this.price = price;
            this.weight = weight;
        }

        public Electro_domestic(double price, string color, double weight)
        {
            this.price = price;
            this.color = color;
            this.weight = weight;
        }


        //method
        public string checkColor()
        {
            return this.color;
        }

        public void changePrice(double price)
        {
            this.price = price;
        }

        public void changeColor(string color)
        {
            this.color = color;
        }
    }

}
