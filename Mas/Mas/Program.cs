using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Sockets;

namespace Mas
{
    class Program
    {
        static void Main(string[] args)
        {

            //var manageAuction = new ManageAuction(DateTime.Now, 123,100,100);
            var agents = new List<Agent>() { new Agent("shahar", 316387569), new Agent("yuval", 280546), new Agent("afek", 785964321), new Agent("shani", 12345) };
            var auctions = new List<ManageAuction>() { new ManageAuction(DateTime.Now, 12, 50, 5) , new ManageAuction(DateTime.UtcNow, 13, 20, 1) };

            MasManage masManage = new MasManage(agents, auctions);
          //   masManage.OfferSell(manageAuction);
            masManage.StartSelling();
            Console.ReadLine();
        }
    }
}
