using System;
using System.Collections.Generic;
using System.Text;

namespace Mas
{
    class MasManage
    {
        private List<Agent> Agents { get; set; }
        public List<ManageAuction> Auctions { get; set; }

        // public List<Agent> agentsAccepted;

       // public event Func<ManageAuction, bool> Accepting;
        // public delegate void acceptAttended(bool agentAnswer);
        //public event acceptAttended Accepting;
        public MasManage(List<Agent> agents, List<ManageAuction> auctions)
        {
            Agents = agents;
            Auctions = auctions;
        }
        public void OfferSell()
        {
            /**
            //Console.WriteLine("this {random. ManageAuction}  is offer, who want to attend?");
            //            if ((AgentAns = true) && (Accepting != null))
            //foreach (var auction in Auctions)
            //{

            //}
            //foreach (var agent in Agents)
            //{

            //    Accepting += agent.AcceptAttend;
            //    Accepting?.Invoke(auctions);
            //    Accepting.GetInvocationList();
            //}

            //
            **/
            foreach (var auction in Auctions)
            {
                foreach (var agent in Agents)
                {
                    if (agent.AcceptAttend(auction))
                    {
                        Console.WriteLine($"{agent.Name} registered {auction.UId}");
                        //   auction.auctionAgents.Add(agent);
                        auction.startSellEvent += agent.MakeOffer;

                   
                        
                    }
                    else
                    {
                        Console.WriteLine($"{agent.Name} registered {auction.UId}");
                    }

                    //    Accepting += agent.AcceptAttend;
                    //Accepting?.Invoke(auctions);
                    //Accepting.GetInvocationList();
                }
                auction.Run();
            }

            /**
            //Console.WriteLine("who want to attend x sell?");


            //Console.WriteLine(Accepting?.Invoke(auctions));

            //foreach (var auction in Auctions)
            //{
            //    if (agent.AcceptAttend(auction))
            //    {
            //        auction.auctionAgents.Add(agent);
            //    }
            //}
            **/

        }






    }
}



