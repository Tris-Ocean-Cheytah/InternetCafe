using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

using System.Text;
using System.Threading.Tasks;

namespace InternetCafeClient.DAO
{
    class FoodDAO
    {
        Socket SckClient;
        EndPoint ep;
        byte[] data=new byte[1024];
        public string GetFoodFromServer()
        {
            List<FoodDTO> listfood = new List<FoodDTO>();
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("5"), ep);
            // xu ly du lieu nhan duoc
            int size = SckClient.ReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep);
            string result = Encoding.ASCII.GetString(data, 0, size);
            return result;
        }
        public List<FoodDTO> ConvertToListFood(string result)
        {
            List<FoodDTO> listfood = new List<FoodDTO>();
            string[] splitbyspace = result.Substring(1).Split(' ');
            for(int i=0;i<splitbyspace.Length;i++)
            {
                string[] splitbydot = splitbyspace[i].Split('.');
                FoodDTO food = new FoodDTO();
                food.name = splitbydot[0];
                food.type = splitbydot[1];
                food.price = splitbydot[2];
                listfood.Add(food);
            }
            return listfood;
        }


    }
}
