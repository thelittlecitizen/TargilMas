using System;
using System.Collections.Generic;
using System.Text;

namespace Mas
{
    class Agent //subscribe
    {
        public string Name;
        public int Id;

        public bool NewOffer { get; set; }

        public Agent(string name, int id)
        {
            Name = name;
            Id = id;
        }

        Random random = new Random();
        public bool AcceptAttend(ManageAuction manageAuction)
        {
            int rand = random.Next(5);
            if (rand >3)
            {
                return true;
            }
            
            return false;
        }
    }


}
