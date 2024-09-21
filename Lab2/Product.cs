using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Lab2
{
    internal class Product
    {
        private string p_name;
        private double p_price;
        private int p_discount;
        public Product() { }
        public Product(string p_name, double p_price, int p_discount)
        {
            this.p_name = p_name;
            this.p_price = p_price;
            this.p_discount = p_discount;
        }

        public Product(string p_name, double p_price)
        {
            this.p_name = p_name;
            this.p_price = p_price;
            this.p_discount = 0;
        }
        public string Product_Name { get; set; }
        public double Product_Price { get; set; }
        public int Discount { get; set; }

        public void input()
        {
            Console.WriteLine("Please enter product's name : ");
            this.p_name = Console.ReadLine();
            Console.WriteLine("Please enter product's price : ");
            this.p_price = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter product's discount :");
            this.p_discount = int.Parse(Console.ReadLine());
        }

        private double getImportTax()
        {
            return (p_price * 10) / 100;
        }

        public void display()
        {
            Console.WriteLine($"Product name : {p_name}");
            Console.WriteLine($"Product price : {p_price}");
            Console.WriteLine($"Product discount : {p_discount}");
            Console.WriteLine($"Product tax : {getImportTax()}");
        }

    }
}
