using System;
using System.Net.Sockets;

namespace Mas
{
    class Program
    {
        static void Main(string[] args)
        {
            var manageAuction = new ManageAuction(DateTime.Now, 123,100,100);
            MasManage masManage = new MasManage();

            masManage.OfferSell(manageAuction);

        }
    }
}
