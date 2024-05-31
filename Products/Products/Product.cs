using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class Product
    {
        private int id;
        private string name;
        private int qty;
        private float price;
        //private float total;
        public Product() { }
        public Product(int id, string name, int qty, float price)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.price = price;
            //this.total = total;
        }
        public int Id {
            get{ return id; }
            set { id = Id; }
        }
        public string Name
        {
            get { return name; }
            set { name = Name; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = Qty; }
        }
        public float Price
        {
            get { return price; }
            set { price = Price; }
        }
       /* public float Total
        {
            get { return total; }
            set { total = Total; }
        }*/
    }
}
