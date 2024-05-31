using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_list_Collection
{
    public class Product_shop
    {
        private int ID;
        private int qty;
        private int discount;
        private String Name;
        private float price;
        private float total;
        private float payment;
        public Product_shop() { }
        public int Id
        {
            get{ return ID; }
            set{ this.ID = Id; }
        }
        public String name
        {
            get { return Name; }
            set { Name = name; }
        }
        public int Qty
        {
            get { return qty; }
            set { this.qty = Qty; }
        }
        public float Price
        {
            get { return price; }
            set { this.price = Price; }
        }

       
        public Product_shop(int iD, int qty, int discount, string name, float price, float total, float payment)
        {
            ID = iD;
            this.qty = qty;
            this.discount = discount;
            Name = name;
            this.price = price;
            this.total = total;
            this.payment = payment;
        }

         public void Input()
        {
            Console.Write("Input ID=");
            this.ID = int.Parse(Console.ReadLine());
            Console.Write("Input Name=");
            this.Name = Console.ReadLine();
            Console.Write("Input Quantity=");
            this.qty = int.Parse(Console.ReadLine());
            Console.Write("Input Price=");
            this.price = int.Parse(Console.ReadLine());
        }
        public float Total()
        {
            return this.total = this.price * this.qty;
        }
        public int Discount()
        {
            if(Total()>=1 && Total() <= 25)
            {
                this.discount = 10;
                this.payment =  Total() - (Total() * this.discount)/100;
            }
            else if(Total() > 25 && Total() <= 35)
            {
                this.discount = 20;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            else if (Total() > 35 && Total() <= 50)
            {
                this.discount = 25;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            else if (Total() > 50)
            {
                this.discount = 30;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            return this.discount;
        }
        public float Payment()
        {
            if (Total() >= 1 && Total() <= 25)
            {
                this.discount = 10;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            else if (Total() > 25 && Total() <= 35)
            {
                this.discount = 20;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            else if (Total() > 35 && Total() <= 50)
            {
                this.discount = 25;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            else if (Total() > 50)
            {
                this.discount = 30;
                this.payment = Total() - (Total() * this.discount) / 100;
            }
            return this.payment;
        }
        public void Output()
        {
            Console.WriteLine(
                "\t"+"ID: "+this.ID + "\t" + "Name: " + this.Name+
                "\t" + "Qty: " + this.qty + "\t" + "Price: " + this.price +"$"+
                "\t" + "Total: " + Total()+ "$" + "\t"+ "Discount: "+ Discount()+"%"+
                "\t" + "Paymnet: " + Payment()+"$"
                );

        }
    }
}
