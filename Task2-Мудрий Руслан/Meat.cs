using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
     class Meat : Product 
    {
        private string category;
        public string Category 
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }
        private int sort;
        public int Sort
        {
            set
            {
                if ((value >= 0) && (value <= 3))//0 - вищий сорт, 3 - третій сорт
                {
                    sort = value;
                }
                else
                    throw new Exception("sort is incorrect");
            }
            get
            {
                return sort;
            }
        }
        public Meat()
        {

        }



        public Meat(string c_category, int i_sort, string in_name, double in_price, int in_weight)
        {
            this.category = c_category;

            if ((i_sort >= 0) && (i_sort <= 3))//0 - вищий сорт, 3 - третій сорт
            {
                this.sort = i_sort;
            }
            else throw new Exception("sort is incorrect");


            this.name = in_name;
            if (in_price >= 1)
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

        }
        public override void change_price(double d_percents) 
        {
            Console.WriteLine("Meat");
            this.price = this.price * ((d_percents + (50 - this.sort*10))/100); //Нова Ціна буде дорівнювати n% від старої + Націнка залежно від сорту
        }

        public override string ToString()// перевантаження  метода ToString
        {
           return "Name: " + this.Name + "\n Type of meat: " + this.Category + "\n Sort: " + this.Sort + '\n' + "Price: " + this.Price + "\n Weight: " + this.Weight + " gram ";

        }
        

    }
}
