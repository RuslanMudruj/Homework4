using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    class Dairy_products : Product
    {
        protected int expiration_date;
        public int Expiration_date
        {
            set
            {
                if (value > 0)
                    expiration_date = value;
            }
            get
            {
                return expiration_date;
            }
        }
        Dairy_products()
        {
        }
        public Dairy_products(string in_name, double in_price, int in_weight, int in_expiration_date)
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
            if (in_weight > 0)
                this.expiration_date = in_expiration_date;
            else
                throw new Exception("expiration date is incorrect");
        }
        public override void change_price(double d_percents)
        {
            this.price = this.price * ((d_percents / 100) + (expiration_date / 100)); // 1 день - 1% до націнки)
        }

        public override string ToString()// перевантаження  метода ToString
        {
            return "Name: " + this.Name + "\n Price: " + this.Price + "\n Weight: " + this.Weight + " gram " + "\n Expiration date: " + this.Expiration_date;
        }
    }
}

