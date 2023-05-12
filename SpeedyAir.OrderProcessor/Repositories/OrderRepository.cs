using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpeedyAir.OrderProcessor.Models;

namespace SpeedyAir.OrderProcessor.Repositories
{
    internal class OrderRepository
    {
        public List<Order> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();
            using (StreamReader r = new StreamReader("orders.json"))
            {
                string fileContent = r.ReadToEnd();
                var jsonObject = JObject.Parse(fileContent);
                for (int i = 1; i < jsonObject.Count; i++)
                {
                    var orderId = "order-" + i.ToString("D3");
                    var orderObject = jsonObject[orderId];
                    if (orderObject != null)
                    {
                        var orderValue = orderObject["destination"].ToString();
                        orderList.Add(new Order { Id = orderId, Destination = orderValue });
                    }

                }
            }

            return orderList;
        }
    }
}
