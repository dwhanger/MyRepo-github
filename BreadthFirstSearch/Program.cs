using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreadthFirstSearchNS
{
    class BreadthFirstSearch
    {
        public class Person
        {
            public Person(string n)
            {
                name = n;
            }

            public string name {get; set;}

            public List<Person> FriendsList = new List<Person> ();

            public void makeIntoFriend(Person p)
            {
                FriendsList.Add(p);
            }

            public bool isFriendOf(Person p)
            {
                bool retval = false;

                foreach (Person f in FriendsList)
                {
                    if (f.name == p.name)
                    {
                        retval = true;
                        break;
                    }
                }

                return retval;
            }

            public Person getFriend(string name)
            {
                Person retval = null;

                foreach (Person f in FriendsList)
                {
                    if (f.name == name)
                    {
                        retval = f;
                        break;
                    }
                }

                return retval;
            }
        
        }

        public Queue<Person> Traverse(Person node)
        {
            Queue<Person> transversalOrder = new Queue<Person>();
            Queue<Person> Q = new Queue<Person>();
            HashSet<Person> S = new HashSet<Person>();

            Q.Enqueue(node);
            S.Add(node);

            while (Q.Count > 0)
            {
                Person p = Q.Dequeue();
                transversalOrder.Enqueue(p);

                foreach (Person friend in p.FriendsList)
                {
                    if (!S.Contains(friend))
                    {
                        Q.Enqueue(friend);
                        S.Add(friend);
                    }
                }
            }

            return transversalOrder;
        }

        public List<Person> PeopleList = new List<Person>();

        public static void Main(string[] args)
        {
            BreadthFirstSearch bfs = new BreadthFirstSearch();
            Person root = new Person("Darren");
            
            root.makeIntoFriend( new Person("matt") );
            root.makeIntoFriend(new Person("joe"));
            root.makeIntoFriend(new Person("alex"));
            root.makeIntoFriend(new Person("beatrice"));
            root.makeIntoFriend(new Person("kelly"));
            
            Person p = root.getFriend("matt");
            if( p != null)
            {
                p.makeIntoFriend(new Person("don"));
                p.makeIntoFriend(new Person("margo"));

            }

            p = root.getFriend("alex");
            if (p != null)
            {
                p.makeIntoFriend(new Person("chris"));
                p.makeIntoFriend(new Person("mary"));

            }

            p = root.getFriend("kelly");
            if (p != null)
            {
                p.makeIntoFriend(new Person("carl"));
                p.makeIntoFriend(new Person("lia"));

            }

            Queue<Person> theBFSList = bfs.Traverse(root);

            foreach (Person pp in theBFSList)
            {
                Console.WriteLine(" Name is== {0}", pp.name);
            }
        
        }






    }
}
