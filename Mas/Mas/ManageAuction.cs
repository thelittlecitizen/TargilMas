using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mas
{//I want list of produvts that in this auction and I want list of agens that attending in this sell
    class ManageAuction //publisher
    {
        public DateTime DateTime;
        public int UId;
        public int StartPrice;
        public int MinJump;
        public Product product;
        public List<Agent> auctionAgents;

        public ManageAuction(DateTime dateTime, int uId, int startPrice, int minjump )
        {
            DateTime = dateTime;
            UId = uId;
            StartPrice = startPrice;
            MinJump = minjump;
        }

        public delegate void selsel(object source, EventArgs args); // define a delegate
        public event selsel Seling;// define an event

        

        public void Sell(Product product)
        {
            Console.WriteLine("sell is now on {random} product in {random} price");
            Thread.Sleep(3000);

            OnSelling();
        }

        protected virtual void OnSelling()
        {
            if (Seling != null)
                Seling(this, EventArgs.Empty);
        }


    }


}

