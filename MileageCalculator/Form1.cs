using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class MileageForm : Form
    {
        public MileageForm()
        {
            InitializeComponent();
        }

        double startingMileage = 0;
        double endingMileage = 0;
        double reimbursementRate = 0.39;
        double milesTravelled = 0;
        double amountOwed = 0;

        private void IntroMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (double)StartInput.Value;
            endingMileage = (double)EndInput.Value;

            if (endingMileage > startingMileage)
            {
                milesTravelled = endingMileage - startingMileage;

                amountOwed = milesTravelled * reimbursementRate;

                AmountOwedText.Text = "£ " + amountOwed;
            }
            else
            {
                MessageBox.Show("The start mileage must be less than the end mileage", "Cannot calcultae mileage");
            }
        }
    }
}
