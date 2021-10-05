using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace homework_1
{
    class Storage
    {
        int n;
        private Product[] many_product = new Product[3];
        public Product this[int index]
        {
            set
            {
                many_product[index] = value;
            }
            get
            {
                if (index < many_product.Length)
                    return many_product[index];
                else
                    throw new Exception("index is begger than many product's lenght");
            }

        }
        
        public void date_delete()
        {
            DateTime dt = DateTime.Now;
            string[] date = dt.ToString("d").Split('.');
            
            for(int i = 0;i< many_product.Length; i++)
            {
                if (many_product[i].Type == "Milk")
                {
                    string[] product_date = many_product[i].Date.Split('.');
                    if ((int.Parse(date[0]) >= int.Parse(product_date[0])) && (int.Parse(date[1]) >= int.Parse(product_date[1]) && (int.Parse(date[1]) >= int.Parse(product_date[1]))
                        Array.Clear(many_product, i, 1);
                }
            }
        }

        public void out_file()
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Ruslanchik\source\repos\Homework_№3\out.txt", false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < many_product.Length; i++)
                {
                    sw.WriteLine(String.Format("Product {0}\tPrice {1}\tType {2}\tDate {3} \n", many_product[i].Name, many_product[i].Price, many_product[i].Type, many_product[i].Date));
                }


            }
        }
        public void in_file()
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Ruslanchik\source\repos\Homework_№3\out.txt", false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < many_product.Length; i++)
                {
                    sw.WriteLine(String.Format("Product {0}\tPrice {1}\tType {2}\tDate {3} \n", many_product[i].Name, many_product[i].Price, many_product[i].Type, many_product[i].Date));
                }
            
                
            }
        }








        // Methods------------------------------------------------------------

        public Storage()
        {
            for (int i = 0; i < 3; i++)
            {
                many_product[i] = new Product();
            }
        }

        public void dialog_method()
        {
            for (int i = 0; i < 3; i++)
            {
                string namee = Console.ReadLine();
                many_product[i].Name = namee;
                Console.WriteLine("Pleas enter a price");
                int pric = int.Parse(Console.ReadLine());
                many_product[i].Price = pric;
                Console.WriteLine("Pleas enter a weight");
                int weig = int.Parse(Console.ReadLine());
                many_product[i].Weight = weig;
            }

        }


        public void init_method()
        {
            many_product[0].Name = "Meat";
            many_product[0].Price = 50;
            many_product[0].Weight = 100;

            many_product[1].Name = "Milk";
            many_product[1].Price = 30;
            many_product[1].Weight = 1;


            many_product[2].Name = "Eggs";
            many_product[2].Price = 10;
            many_product[2].Weight = 30;

        }





        public void druk_product()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine("Information about Product: " + '\n' + "Name: " + many_product[i].Name + '\n' + "Price: " + many_product[i].Price + "\n Weight: " + many_product[i].Weight);

        }






        public void meat_check()
        {
           
            for (int i = 0; i < 3; i++)
            {
                if (many_product[i].Name == "Meat")
                {
                    Console.WriteLine("Information about Meat Product: " + '\n' + "Name: " + many_product[i].Name + '\n' + "Price: " + many_product[i].Price + "\n Weight: " + many_product[i].Weight);


                }
            }
        }

        public void store_changeprice(int persent)
        {
            for (int i = 0; i < 3; i++)
            {
                many_product[i].change_price(persent);
            }

        }

    }
}
