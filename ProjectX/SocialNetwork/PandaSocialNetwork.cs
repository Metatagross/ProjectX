using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class PandaSocialNetwork
    {
        Dictionary<Panda , PandaNode> accounts;

        public PandaSocialNetwork ( )
        {
            Accounts = new Dictionary<Panda , PandaNode>();
        }

        public Dictionary<Panda , PandaNode> Accounts
        {
            get
            {
                return accounts;
            }

            set
            {
                accounts = value;
            }
        }

        
        public int ConnectionLevel ( Panda p1 , Panda p2 )
        {
            Dictionary<PandaNode , bool> visited= new Dictionary<PandaNode, bool>();
            if(Accounts.Keys.Contains(p1) && Accounts.Keys.Contains(p2))
            {
                return BFS(Accounts[p1] , p2 , 0 , visited);
            }
            return -1;
        }
        private int BFS ( PandaNode start , Panda p , int counter , Dictionary<PandaNode , bool> visited )
        {
            if(start.Friends.Contains(Accounts[p]))
            {
                return counter;
            }
            else
            {
                counter++;
                foreach(var item in start.Friends)
                {
                    if(visited.Keys.Contains(item))
                    {
                    }
                    else
                    {
                        visited.Add(item , false);
                    }
                    if(!visited[item])
                    {

                    }
                    else
                    {
                        visited[item] = true;
                        BFS(item , p , counter , visited);
                        visited[item] = false;
                    }
                }
            }
            return -1;
        }
    }
}
