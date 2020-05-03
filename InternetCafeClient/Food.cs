using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeClient
{
    public class Food
    {
        public static List<Food> listFood = new List<Food>();
        public string name;
        public string price;
        public int amount;
        public Food()
        {
            this.name = "Tên món ăn";
            this.price = "10000";
            this.amount = 0;
        }
        public Food(int s) : this()
        {
            this.name += " "  + s;
        }
        static public void AddFood()
        {
            for (int i = 0; i < 20; i++)
            {
                listFood.Add(new Food());
            }
        }
    }
}
