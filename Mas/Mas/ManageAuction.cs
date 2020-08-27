using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mas
{//I want list of produvts that in this auction and I want list of agens that attending in this sell
    class ManageAuction //publisher
    {
        public DateTime DateTime;
        public int UId;
        public int StartPrice;
        public int MaxOffer;
        public string NameMaxOffer;
        public int MinJump;
        public Product product;
        public List<Agent> Attendingsell = new List<Agent>();

        public delegate int StartSell(int number, int num); // define a delegate
        public event StartSell startSellEvent;// define an event


 

        public ManageAuction(DateTime dateTime, int uId, int startPrice, int minjump )
        {
            DateTime = dateTime;
            UId = uId;
            StartPrice = startPrice;
            MinJump = minjump;
            MaxOffer = 0;

        }

        public void CheackMaxOffer (List<Tuple<int, string>> numberofmakeoffer)
        {
            foreach (var max in numberofmakeoffer)
            {
                if (MaxOffer < max.Item1)
                {
                    MaxOffer = max.Item1;
                    NameMaxOffer = max.Item2;
                }
            }
        }
      
        public void Run()
        {
            if (startSellEvent != null) 
            {
                Console.WriteLine("started");
                List<Tuple<int,string>> numberandnameofmakeoffer = new List<Tuple<int, string>>();

                foreach (var startSellEvent in startSellEvent.GetInvocationList())
                {
                   
                       var agent = (Agent)startSellEvent.Target;
                       var resulrPrice = (int)startSellEvent?.DynamicInvoke(StartPrice, MinJump);
                       numberandnameofmakeoffer.Add(new Tuple<int, string>(resulrPrice, agent.Name));
                   
                }

                CheackMaxOffer(numberandnameofmakeoffer);

                Console.WriteLine($"the Max Offer is: {MaxOffer} and the name: {NameMaxOffer}");

            }
            else 
            { 
                Console.WriteLine("no one enter to sell"); 
            }

            

           //startSellEvent?.Invoke(StartPrice, MinJump);
        }
        //public void OfferSell()
        //{
        //    foreach (var agent in Attendingsell)
        //    {
        //        if (this.StartPrice + this.MinJump <= agent.MakeOffer(this.StartPrice ,this.MinJump) )
        //        {
        //            Console.WriteLine($"{agent.Name}: {agent.MakeOffer(this.StartPrice, this.MinJump)}");
        //        }
        //    }
        }

    }




