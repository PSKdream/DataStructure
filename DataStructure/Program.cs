using System;
using Lists;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collection x = new ArrayCollection(2);
            // Collection x = new LinkedCollection();
            List data = new SinglyLinkedList();
            data.add("Ant");
            data.add("Bat");
            data.add(1, "Cat");
        }
    }
}
