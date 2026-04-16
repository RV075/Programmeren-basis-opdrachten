using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAssignment18
{
    class Cars
    {
        private int id;
        private string make;
        private double price;

        //public void PublicPrint()
        //{
        //    Console.WriteLine("I am public!");
        //}
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public Cars()
        {
            this.id = 0;
            this.make = "unknown";
            this.price = 0.0;
        }
        public Cars(int id1)
        {
            this.id = id1;
            this.make = "unknown";
            this.price = 0.0;
        }
        public Cars(int id1, string make1, double price1)
        {
            this.id = id1;
            this.make = make1;
            this.price = price1;
        }
        public void Print()
        {
            Console.WriteLine($"Id: {this.id}, Make: {this.make}, Price: {this.price}");
        }
    }
}
