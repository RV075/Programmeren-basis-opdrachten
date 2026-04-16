using System;
using System.Collections;m
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAssignment18
{
    class Customers
    {
        private int id;
        private string name;
        private int telephone;

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
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Telephone
        {
            get
            { 
                return this.telephone;
            }
            set
            { 
                this.telephone = value;
            }
        }
        public Customers()
        {
     
        }
        public Customers(int id1, string name1, int telephone1)
        {
            this.id = id1;
            this.name = name1;
            this.telephone = telephone1;
        }
        public static ArrayList Initialize()
        {
            ArrayList list = new ArrayList();

            list.Add(new Customers(1, "Merry", 612345678));
            list.Add(new Customers(2, "John", 612345677));
            list.Add(new Customers(3, "Tim", 612345666));
            list.Add(new Customers(4, "Matt", 612345555));
            list.Add(new Customers(5, "Jeff", 612344444));

            return list;
        }
    }
}