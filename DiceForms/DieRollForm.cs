using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceForms
{
    public partial class DieRollForm : Form
    {
        // Declarations and initializations of variables
        private aDie die;
        private int dieRoll, numOfDieRolls, seedNum, updateRollCount, updateTimeCount;
        private int rollIter = 0;
        private bool tryNumOfDieRolls, trySeedNum;
        private string cmbBxNRollsSelect;
        private string cmbBxTimeSelect;
        private string cmbBxTickSelect;
        private int[] arrOfDieRolls = new int[6]; // Holds the array of die rolls. 

        // Generate the Die Roll Form
        public DieRollForm()
        {
            InitializeComponent();
        }

        // This function occurs when the number of rolls checkbox is changed.
        private void chkBxNOfRolls_CheckedChanged(object sender, EventArgs e)
        {
            // Displays the number of rolls combo box if the checkbox is checked.
            if (chkBxNOfRolls.Checked)
            {
                cmbBxNOfRolls.Visible = true;
                MessageBox.Show("Activated!");
            }
            else
            { // If not checked, delete the combo box selection and make it invisible.
                cmbBxNOfRolls.SelectedItem = null;
                cmbBxNOfRolls.Visible = false;
            }
        }

        // This function occurs when the time intervals checkbox is changed.
        private void chkBxTimeIntervals_CheckedChanged(object sender, EventArgs e)
        {
            // Displays the time intervals combo box if the checkbox is checked.
            if (chkBxTimeIntervals.Checked)
            {
                cmbBxTimeIntervals.Visible = true;
            }
            else
            { // If not checked, delete the combo box selection and make it invisible.
                cmbBxTimeIntervals.SelectedItem = null;
                cmbBxTimeIntervals.Visible = false;
            }
        }

        // This function perfoms the ticks for the die timer.
        private void timerDie_Tick(object sender, EventArgs e)
        {

            if (cmbBxNRollsSelect != null)
            { // Perform the update every # of rolls (selected).
                updateRollCount = Int32.Parse(cmbBxNRollsSelect);
                for (int tempRollIter = 0; tempRollIter < updateRollCount; tempRollIter++)
                {
                    dieRoll = die.Next;
                    arrOfDieRolls[dieRoll - 1]++;
                    // Creates a frequency distribution based on the array of die roll counts.
                    chrtFreqDist.Series["Die-Face Occurence"].Points.DataBindY(arrOfDieRolls);
                    rollIter++;
                }
            }
            else if (cmbBxTimeSelect != null)
            { // Perform the update every time interval (selected).
                updateTimeCount = Int32.Parse(cmbBxTimeSelect);
                for (int tempRollIter = 0; tempRollIter < updateTimeCount; tempRollIter += timerDie.Interval)
                {
                    dieRoll = die.Next;
                    arrOfDieRolls[dieRoll - 1]++;
                    // Creates a frequency distribution based on the array of die roll counts.
                    chrtFreqDist.Series["Die-Face Occurence"].Points.DataBindY(arrOfDieRolls);
                    rollIter++;
                }
            }

            if (rollIter >= numOfDieRolls)
            { // The total # of rolls are done.

                timerDie.Stop(); // Disable the die timer.
                for (int dieFace = 0; dieFace < arrOfDieRolls.Length; dieFace++)
                { // Reset the array of die rolls to 0 and graph it.
                    arrOfDieRolls[dieFace] = 0;
                }
                rollIter = 0; // Reset the whole roll iteration
                btnStop.Visible = false; // Make the stop button unavailable and the frequency button available
                btnFreqDist.Visible = true;
            }
            chrtFreqDist.Update(); // Update the frequency distribution chart.
        }

        // This button stops the frequency distribution and resets the chart.
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerDie.Stop(); // Disable the die timer.
            for (int dieFace = 0; dieFace < arrOfDieRolls.Length; dieFace++)
            { // Reset the array of die rolls to 0 and graph it.
                arrOfDieRolls[dieFace] = 0;
                chrtFreqDist.Series["Die-Face Occurence"].Points.DataBindY(arrOfDieRolls);
            }
            rollIter = 0; // Reset the whole roll iteration
            //chrtFreqDist.Update(); // Update the frequency distribution chart.
            btnStop.Visible = false; // Make the stop button unavailable and the frequency button available
            btnFreqDist.Visible = true;
        }

        // This button click will bring up the 2nd form for the 2-die roll.
        private void roll2DieBtn_Click(object sender, EventArgs e)
        {
            // Create the Dice Form and show it.
            DiceRollForm diceForm = new DiceRollForm();
            diceForm.ShowDialog();
        }

        // This button click generates the frequency distribution of die rolls given by the user.
        // The user can choose the number of die rolls and the seed number.
        private void btnFreqDist_Click(object sender, EventArgs e)
        {

            // Initialize the combo box strings
            cmbBxNRollsSelect = (string)cmbBxNOfRolls.SelectedItem;
            cmbBxTimeSelect = (string)cmbBxTimeIntervals.SelectedItem;
            cmbBxTickSelect = (string)cmbBxTick.SelectedItem;

            if (!chkBxNOfRolls.Checked && !chkBxTimeIntervals.Checked)
            { // Tell the user they did not check the number of rolls or time intervals checkbox.
                MessageBox.Show("Please select the update # of rolls or time intervals checkbox...", "Select a Checkbox");
                return; // Exit out of the button click.
            }
            else if (chkBxNOfRolls.Checked && cmbBxNRollsSelect == null
                && chkBxTimeIntervals.Checked && cmbBxTimeSelect == null)
            { // Tell the user they did not select a number of rolls and time .
                MessageBox.Show("Please select the update # of rolls and time interval...", "Select the # of rolls");
                return; // Exit out of the button click.
            }
            else if (chkBxNOfRolls.Checked && cmbBxNRollsSelect == null)
            { // Tell the user they did not select a number of rolls.
                MessageBox.Show("Please select the update # of rolls...", "Select the # of rolls");
                return; // Exit out of the button click.
            }
            else if (chkBxTimeIntervals.Checked && cmbBxTimeSelect == null)
            { // Tell the user they did not select a time interval.
                MessageBox.Show("Please select the update time interval...", "Select the # of rolls");
                return; // Exit out of the button click.
            }
            else if (cmbBxTickSelect == null)
            { // Tell the user they did not select a time interval.
                MessageBox.Show("Please select the tick interval...", "Select the tick interval");
                return; // Exit out of the button click.
            }
            else if (cmbBxTimeSelect != null && (Int32.Parse(cmbBxTickSelect) > Int32.Parse(cmbBxTimeSelect)))
            { // Tell the user they did not select a tick inteval <= time interval.

                MessageBox.Show("Please select the tick interval <= time interval...", "Select the appropriate intervals");
                return; // Exit out of the button click.
            }

            // See if the user entered an integer for the die rolls.
            tryNumOfDieRolls = int.TryParse(txtDieRolls.Text, out numOfDieRolls);
            if (!tryNumOfDieRolls) // Guide the user to enter the valid number of die rolls.
            {
                MessageBox.Show("Please enter a valid number of die rolls...", "Enter Die Rolls");
                return; // Exit out of the button click.
            }
            else if (numOfDieRolls <= 0) // Guide the user to enter a number greater than zero.
            {
                MessageBox.Show("Please enter a number greater than zero", "Enter Die Rolls");
                return; // Exit out of the button click.
            }

            // Attempt to get the seed number.
            trySeedNum = int.TryParse(txtSeedNum.Text, out seedNum);
            if (!trySeedNum)
            { // If the input isn't an integer, set the seedNum to 1.
                die = new aDie();
            }
            else
            { // Create a random object using the seed #.
                die = new aDie(seedNum);
            }

            for (int dieFace = 0; dieFace < arrOfDieRolls.Length; dieFace++)
            { // Set the array of die rolls to 0 and graph it.
                arrOfDieRolls[dieFace] = 0;
                chrtFreqDist.Series["Die-Face Occurence"].Points.DataBindY(arrOfDieRolls);
            }
            // Set the timer interval and start it.
            timerDie.Interval = Int32.Parse(cmbBxTickSelect);
            timerDie.Start();
            btnStop.Visible = true; // Make the stop button available and the frequency button unavailable
            btnFreqDist.Visible = false;

        }

    }
}
