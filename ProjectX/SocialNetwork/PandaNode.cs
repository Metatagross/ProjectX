using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class PandaNode
    {
        private Panda accounter;
        private List<PandaNode> friends;
        public PandaNode(Panda p )
        {
            Accounter = p;
        }

        public Panda Accounter
        {
            get
            {
                return accounter;
            }

            set
            {
                accounter = value;
            }
        }

        public List<PandaNode> Friends
        {
            get
            {
                return friends;
            }

            set
            {
                friends = value;
            }
        }
        public bool AreConnected(Panda p1, Panda p2)
        {
            return true;
        }
    }
}
