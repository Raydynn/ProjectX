using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class PandasAlreadyFriendsException: Exception
    {
        public Panda Panda1 { get; set; }
        public Panda Panda2 { get; set; }
        public PandasAlreadyFriendsException(Panda panda1, Panda panda2)
        {
            Panda1 = panda1;
            Panda2 = panda2;
        }
    }
}
