using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator
{
    public partial class RefrigeratorUI : Form
    {

        Refrigerator refrigerator;

        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            refrigerator = new Refrigerator(Convert.ToDouble(maxWeightTextBox.Text));

            maxWeightTextBox.Clear();

        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            refrigerator.item=Convert.ToInt32(noOfItemsTextBox.Text);
            refrigerator.weight=Convert.ToDouble(weightTextBox.Text);
            refrigerator.Add(refrigerator.item, refrigerator.weight);

            if (refrigerator.GetCurrentWeight() <= refrigerator.maxWeight)
            {

                currentWeightTextBox.Text = Convert.ToString(refrigerator.GetCurrentWeight());

                remainingWeightTextBox.Text = Convert.ToString(refrigerator.GetRemainingWeight());
            }

            else
            {
                MessageBox.Show("You can't take more than maximum weight!");
            }

            
            
           
            noOfItemsTextBox.Clear();
            weightTextBox.Clear();

            


            //int itemNo = Convert.ToInt32(noOfItemsTextBox.Text);
            //double weight = Convert.ToDouble(weightTextBox.Text);

            //double currentWeight = itemNo * weight;

            //if (currentWeight < maxWeight)
            //{
            //    currentWeightTextBox.Text = Convert.ToString(currentWeight);

            //}

            //double remainingWeight = maxWeight - currentWeight;

            //remainingWeightTextBox.Text = Convert.ToString(remainingWeight);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
