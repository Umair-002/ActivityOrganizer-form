using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessedWeek4TaskB
{
    public partial class Form1 : Form
    {
        //setting fields which allow us to call methods from the classes
        Activity act;
        ActivityList ActList;

        //method to sort 
        public static void quickSortDD2(Activity[] items, int left, int right)
        {
            //setting variables
            double change = items[left].Ending;
            int i, j;
            i = left; j = right;
            //while i is smaller or equal to j 
            while (i <= j)
            {
                //for ending smaller than 0 and i is smaller than right increment
                for (; (items[i].Ending.CompareTo(change) < 0) && (i < right); i++) ;
                //for ending smaller than 0 and j greater than left - j each time
                for (; (change.CompareTo(items[j].Ending) < 0) && (j > left); j--) ;
                //if i is smaller or equal to j
                if (i <= j)
                    //call swap method passing ref to items
                    Swap(ref items[j--], ref items[i++]);
            }
            //if left smaller than j call quicksort
            if (left < j) quickSortDD2(items, left, j);
            //if i smaller than right call quicksort
            if (i < right) quickSortDD2(items, i, right);
        }
        //swap method passing 2 ref
        static void Swap(ref Activity x, ref Activity y)
        {
            //activity type temp = to x
            Activity temp = x;
            //ref x = to ref y
            x = y;
            //ref y = to activity type temp
            y = temp;
        }

        public Form1()
        {
            //initialize actlist so that methods can be called
            ActList = new ActivityList();
            InitializeComponent();
        }
        //add button
        private void AddButton_Click(object sender, EventArgs e)
        {
            //call constructor passing textboxes and convert to double so that numbers can be read 
            act = new Activity(Convert.ToDouble(StartingTextBox.Text),
            Convert.ToDouble(FinishingTextBox.Text), DescriptionTextBox.Text);
            //Convert32
            //call add method to add to data structure (array)
            ActList.Add(act);

        }
        //sort button
        private void SortButton_Click(object sender, EventArgs e)
        {
            //call local quicksort method passing data structure(array) and length -1
            quickSortDD2(ActList.Data, 0, ActList.Data.Length - 1);
        }

        //organize button
        private void OrganizeButton_Click(object sender, EventArgs e)
        {
            //change display text to sort method called which passes activity class and display method
            DisplayTextBox.Text = Sort.GreedyAlgo(ActList).Display();
        }
        //display button
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //change display text box to display method
            DisplayTextBox.Text = "Activities available:" + ActList.Display();
        }
    }
}
