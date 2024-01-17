using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedWeek4TaskB
{
    public class Activity : IComparable //use of icomaprable
    {
        //set variables 
        private string description;
        private double starting;
        private double ending;


        //setting constructor 
        public Activity(double starting, double ending, string description)
        {
            this.starting = starting;
            this.description = description;
            this.ending = ending;
        }

        //property setting starting,ending and description
        public double Starting
        {
            set { starting = value; }
            get { return starting; }
        }
        public double Ending
        {
            set { ending = value; }
            get { return ending; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        //comapare to statement for icomparable
        public int CompareTo(object obj)
        {
            Activity other = (Activity)obj;
            return ending.CompareTo(other.ending);
        }

        ////overiding string method to display text
        //public override string ToString()
        //{
        //    string newLine = Environment.NewLine;

        //    return newLine + "Description  " + description + "  Starting Time:  " + starting + "  Finishing Time  " + ending + "";
        //}
    }
}