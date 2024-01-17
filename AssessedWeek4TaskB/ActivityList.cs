using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedWeek4TaskB
{
    class ActivityList
    {
        //calling activity class to use methods
        Activity activity;
        //create an array
        Activity[] data = new Activity[3];
        //setting variable called numItems of type int
        private int numItems = 0;

        //property setting 
        public Activity Activity
        {
            set { activity = value; }
            get { return activity; }
        }
        public int NumItems
        {
            set { numItems = value; }
            get { return numItems; }
        }
        //setting property of array
        public Activity[] Data
        {
            set { data = value; }
            get { return data; }
        }

        //add method
        public void Add(Activity act)
        {
            //call array passing numitems = to activity
            data[numItems] = act;
            //increment numitems by 1
            numItems++;
        }
        //display method
        public string Display()
        {
            //create temp string
            string temp = " ";
            //for i smaller than numitems increment i
            for (int i = 0; i < numItems; i++)
            {
                //set temp string to output
                temp += "activity: " + data[i].Description + "  from: " + data[i].Starting + "  till: " + data[i].Ending ;
            }
            //return temp string
            return temp;
        }

    }
}
