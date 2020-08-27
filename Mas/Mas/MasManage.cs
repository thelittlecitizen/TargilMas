using System;
using System.Collections.Generic;
using System.Text;

namespace Mas
{
    class MasManage
    {
        public List<Agent> agents;
        public List<ManageAuction> auctions;
        public List<Agent> agentsAccepted;

        public event Func<ManageAuction, bool> Accepting;
       // public delegate void acceptAttended(bool agentAnswer);
        //public event acceptAttended Accepting;

        public void OfferSell(ManageAuction auctions)
        {
            Console.WriteLine("this {random. ManageAuction}  is offer, who want to attend?");
            //            if ((AgentAns = true) && (Accepting != null))

            foreach (var agent in agents)
            {
                Accepting += agent.AcceptAttend;
            }
            Console.WriteLine(Accepting?.Invoke(auctions));

                //foreach (var auction in auctions)
                //{
                //    if (agent.AcceptAttend(auction))
                //    {
                //        auction.auctionAgents.Add(agent);
                //    }
                //}
                
            }
            


        


        }
    }

}

