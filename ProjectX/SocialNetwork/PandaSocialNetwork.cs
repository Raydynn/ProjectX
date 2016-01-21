using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class PandaSocialNetwork
    {
        public List<Panda> PandaList { get; set; }

        private bool HasPanda(Panda isSocial)
        {
            if (PandaList.Contains(isSocial))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private MakeFriends(Panda panda1, Panda panda2)
        {
            
        }

        public PandaSocialNetwork(Panda newPanda)
        {
            if (PandaList.Contains(newPanda))
	        {
		        throw new Exception("Panda already there!");
	        }
            else
	        {
                PandaList.Add(newPanda);
	        }          
        }
    }
}
