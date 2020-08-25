using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mas
{
    class ManageAuction //publisher
    {
        public DateTime DateTime;
        public int uId;
        public int startPrice;
        public int minJump;

        public delegate void selsel(object source, EventArgs args); // define a delegate
        public event selsel Seling;// define an event

        public void Sell(Agent agent)
        {
            Console.WriteLine("sell is now");
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

