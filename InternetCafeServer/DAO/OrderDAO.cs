using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetCafeServer.DTO;
namespace InternetCafeServer.DAO
{
    class OrderDAO
    {
        OrderDTO order = new OrderDTO();
        public OrderDTO Convertstringtoorder(string result)
        {
            string[] splitbyspace = result.Split('*');
            order.name = splitbyspace[0];
            order.username = splitbyspace[1];
            order.food = splitbyspace[2];
            order.price = splitbyspace[3];
            return order;
        }
    }
}
