using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class PandaSocialNetwork
    {
        private List<Panda> pandaList = new List<Panda>();
        private Dictionary<Panda, List<Panda>> pandaFriendList = new Dictionary<Panda, List<Panda>>();

        private bool HasPanda(Panda isSocial)
        {
            if (pandaList.Contains(isSocial))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MakeFriends(Panda panda1, Panda panda2)
        {
            if (!pandaList.Contains(panda1))
            {
                pandaList.Add(panda1);
            }

            if (!pandaList.Contains(panda2))
            {
                pandaList.Add(panda2);
            }

            if (!pandaFriendList.ContainsKey(panda1))
            {
                pandaFriendList.Add(panda1, new List<Panda>());
            }

            if (pandaFriendList[panda1].Contains(panda2))
            {
                throw new PandasAlreadyFriendsException(panda1, panda2);
            }

            pandaFriendList[panda1].Add(panda2);
        }

        public PandaSocialNetwork(Panda newPanda)
        {
            if (pandaList.Contains(newPanda))
	        {
		        throw new Exception("Panda already there!");
	        }
            else
	        {
                pandaList.Add(newPanda);
	        }          
        }
    }
}
