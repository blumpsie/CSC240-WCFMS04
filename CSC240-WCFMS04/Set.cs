using System;
using System.Collections.Generic;

namespace CSC240_WCFMS04
{
    class Set <T>
    {
        // Fields
        List<T> theList;
        int currentIndex; // Index of current element in the set
        const int START_CAP = 100; // Initial capacity

        // Constructor
        public Set()
        {
            theList = new List<T>(START_CAP);
            currentIndex = -1;
        }

        // Test to see if the list is empty or not
        public bool isEmpty()
        {

            if(theList == null || theList.Count == 0)
            {
                return true;
            }

            return false;
        }

        // Test to see if parameter is a member of the set
        public bool isMemberOf(T aT)
        {
            string paramClass = aT.GetType().Name; // Hopefully this works
            String currClass;

            foreach (T currT in theList)
            {
                currClass = currT.GetType().Name;

                if (currClass.Equals(paramClass))
                {
                    if (currT.Equals(aT))
                    {
                        return true; // they're the same
                    }
                }
            }
            return false; // no matches
        }

        public int size()
        {
            return theList.Count;
        }

        public T getCurrent()
        {
            int saveIndex = currentIndex;

            if (currentIndex == theList.Count - 1)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }

            return theList[saveIndex];
        }

        // Adds paramter to set
        public bool add(T aT)
        {
            if(this.isMemberOf(aT))
            {
                return false; // Duplicate object
            }

            theList.Add(aT);
            
            if (theList.Count == 1) currentIndex = 0;

            // Successful
            return true;
        }

        public void clear()
        {
            currentIndex = -1;
            theList = new List<T>();
        }

        public void display()
        {
            if(theList.Count == 0)
            {
                Console.WriteLine("There are no objects in the set.");
            }
            else
            {
                Console.WriteLine("Here are the object in the set: \n");
                for (int i = 0; i < theList.Count; i++)
                {
                    Console.WriteLine(theList[i].ToString());
                    Console.WriteLine("\n");
                }
            }
        }

        public bool editAnObject(T aT)
        {
            return false;
        }

        public bool removeAnObject(T aT)
        {
            return false;
        }
    }
}
