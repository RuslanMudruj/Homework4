using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    class Product
    {
        protected string name;
        public string Name
        {
            set
            {
                name = value;

            }
            get
            {
                return name;
            }
        }



        protected string type;
        public string Type
        {
            set
            {
                type = value;

            }
            get
            {
                return type;
            }

        }

        protected double price;
        public double Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                    throw new Exception("price is incorrect");

            }
            get
            {
                return price;
            }
        }

        protected int weight;
        public int Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("weight is incorrect");

            }
            get
            {
                return weight;
            }
        }

        protected int days;
        public int Days
        {
            set
            {
                days = value;

            }
            get
            {
                return days;
            }

        }
        protected string date;
        public string Date
        {
            set
            {
                date = value;

            }
            get
            {
                return date;
            }

        }



        public bool date_check(string in_date)
        {
            string[] splited_date = in_date.Split('.');
            bool check = true;
            try
            {
                if (splited_date.Length > 4)
                    throw new Exception("date string is incorrect");
                check = false;
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                if ((int.Parse(splited_date[0]) > 31 && int.Parse(splited_date[0]) < 1) && (int.Parse(splited_date[1]) > 12 && int.Parse(splited_date[1]) < 1) && (int.Parse(splited_date[2]) != 2021))
                {
                    throw new Exception("date is incorrect");
                    check = false;
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }




            return check;
        }
        public Product()
        {

        }

        public Product(string in_name, double in_price, int in_weight,string in_days,string in_date)
        {
            this.name = in_name;
            if (in_price > 1)
            {
                this.price = in_price;
            
            }
            else
                throw new Exception("price is incorrect");

            if (in_weight > 1)
            {
                this.weight = in_weight;
            }
            else
                throw new Exception("weight is incorrect");
            ;
            if (int.Parse(in_days) > 1 && int.Parse(in_days) < 31) 
            {
                this.days = int.Parse(in_days);
            }
            else
                throw new Exception("wa is incorrect");
            ;


            if(this.date_check(date))
                this.date = in_date;
        }

        public virtual void change_price(double d_percents) 
        {
            
            this.price = this.price * (d_percents / 100);
        }
        public override string ToString()// перевантаження  метода ToString
        {
            return "Name: " + this.Name  + '\n' + "Price: " + this.Price + "\n Weight: " + this.Weight + " gram ";

        }
        
        
        
        
        
        
        
         

    }
}
