using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedWeek4TaskB
{
    class Sort
    {
        //greedy algo method named greedyalgo which passes activity list
        public static ActivityList GreedyAlgo(ActivityList ActListt)
        {
            //set pick to new acticity list
            ActivityList pick = new ActivityList();
            {
                //set variable
                int z = 0;
                //call add method to add to array
                pick.Add(ActListt.Data[0]);
                //for i smaller than array length increment i
                for (int i = 1; i < ActListt.Data.Length; i++)     
                {
                    //if array starting point is greater than or equal to ending 
                    if (ActListt.Data[i].Starting >= ActListt.Data[z].Ending)
                    {
                        //call add method passing data and i
                        pick.Add(ActListt.Data[i]);
                        //set int z to int i
                        z = i;
                    }
                }
                //return the activity list
                return pick;
            }
        }
    }
}