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
        public string type;
        public int amount;
        public Food()
        {
            this.name = "Tên món ăn";
            this.price = "10000";
            this.amount = 0;
        }
        public Food(int s) : this()
        {
            this.name += " " + s;
        }

        public Food(string type) : this()
        {
            this.type = type;
        }
        static public void AddFood()
        {
            AddType();
        }

        static public void AddType()
        {
            for (int i = 0; i < 10; i++)
            {
                Food food = new Food("Mon Chinh")
                {
                    name = "Món chính"
                };
                listFood.Add(food);
            }

            for (int i = 0; i < 10; i++)
            {
                Food food = new Food("Do uong")
                {
                    name = "Đồ uống"
                };
                listFood.Add(food);
            }

            for (int i = 0; i < 20; i++)
            {
                Food food = new Food("An Nhe")
                {
                    name = "Ăn nhẹ"
                };
                listFood.Add(food);
            }
        }
    }
}
