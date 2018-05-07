using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxValueLeoK
{
    public partial class frmMaxValueLeoK : Form
    {
        public frmMaxValueLeoK()
        {
            InitializeComponent();
        }

        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            //variables
            int tmpMaxValue = 0;
            int tmpCounter;

            for (tmpCounter = 0; tmpCounter < tmpArrayOfIntegers.Length; tmpCounter++)
            {
                //if the max value is less than the number in the array, set the max value to that number
                if (tmpMaxValue < tmpArrayOfIntegers[tmpCounter])
                {
                    tmpMaxValue = tmpArrayOfIntegers[tmpCounter];
                }
            }

            //return the max value
            return tmpMaxValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUM = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNum, maxValue;

            maxValue = 0;
            Random randomNumGenerator = new Random();

            //clear the list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //get the random number
                randomNum = randomNumGenerator.Next(1, MAX_RANDOM_NUM);

                //assign the number to the array
                arrayOfIntegers[counter] = randomNum;

                //add the number to the list box
                this.lstNumbers.Items.Add(randomNum);

                //refresh the form
                this.Refresh();
            }

            //get the max value from the array
            maxValue = GetMaxValue(arrayOfIntegers);

            //display the max value
            this.lblAnswer.Text = "The max value is " + maxValue; 
        }
    }
}
