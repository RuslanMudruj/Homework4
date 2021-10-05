using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace homework_1
{
    class Buy
    {
        // Тип відношення has-a
        public Product item;
        
        public int quantity;

        private double all_price;
        public double All_price
        {
            set
            {
                if (value > 0)
                {
                    all_price = value;
                }
            }
            get
            {
                return all_price;
                

            }
        }



        private int all_weight;
        public int All_weight
        {
            set
            {
                if (value > 0)
                {
                    all_weight = value;
                }
            }
            get
            {
                return all_weight;
            }
        }

        public Buy(Product el1, int iquantity)
        {
            this.item = el1;
            this.quantity = iquantity;
            this.all_price = item.Price * iquantity;
            this.all_weight = item.Weight * iquantity;
        }

        

       

    }
}
