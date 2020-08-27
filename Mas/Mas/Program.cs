using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Mas
{
    class Program
    {
        static void Main(string[] args)
        {

            //var manageAuction = new ManageAuction(DateTime.Now, 123,100,100);
            var agents = new List<Agent>() { new Agent("bla", 123), new Agent("blala", 12345), new Agent("afek", 123), new Agent("blala", 12345) };
            var auctions = new List<ManageAuction>() { new ManageAuction(DateTime.Now, 12, 50, 5) , new ManageAuction(DateTime.UtcNow, 13, 20, 1) };

            MasManage masManage = new MasManage(agents, auctions);
          //   masManage.OfferSell(manageAuction);
            masManage.OfferSell();
        }
    }
}
