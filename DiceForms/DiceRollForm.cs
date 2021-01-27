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
    public partial class DiceRollForm : Form
    {

        // Declarations and initializations of variables
        private aDie die = new aDie();
        private int dieRoll1, dieRoll2, numOfDiceRolls, updateRollCount, updateTimeCount;
        private int rollIter = 0;
        private bool tryNumOfDiceRolls;
        private string cmbBxNRollsSelect;
        private string cmbBxTimeSelect;
        private string cmbBxTickSelect;
        private int[] arrOfDiceRolls = new int[12]; // Holds the array of die rolls. 

        // Generate the Dice Roll Form
        public DiceRollForm()
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

        // This function perfoms the ticks for the dice timer.
        private void timerDice_Tick(object sender, EventArgs e)
        {

            if (cmbBxNRollsSelect != null)
            { // Perform the update every # of rolls (selected).
                updateRollCount = Int32.Parse(cmbBxNRollsSelect);
                for (int tempRollIter = 0; tempRollIter < updateRollCount; tempRollIter++)
                {
                    dieRoll1 = die.Next;
                    dieRoll2 = die.Next;
                    // Add the sum of the dice rolls to the array.
                    arrOfDiceRolls[dieRoll1 + dieRoll2 - 1]++;
                    // Creates a frequency distribution based on the array of die roll counts.
                    chrtFreqDist.Series["Dice-Sum Occurence"].Points.DataBindY(arrOfDiceRolls);
                    rollIter++;
                }
            }
            else if (cmbBxTimeSelect != null)
            { // Perform the update every time interval (selected).
                updateTimeCount = Int32.Parse(cmbBxTimeSelect);
                for (int tempRollIter = 0; tempRollIter < updateTimeCount; tempRollIter += timerDice.Interval)
                {
                    dieRoll1 = die.Next;
                    dieRoll2 = die.Next;
                    // Add the sum of the dice rolls to the array.
                    arrOfDiceRolls[dieRoll1 + dieRoll2 - 1]++;
                    // Creates a frequency distribution based on the array of die roll counts.
                    chrtFreqDist.Series["Dice-Sum Occurence"].Points.DataBindY(arrOfDiceRolls);
                    rollIter++;
                }
            }

            if (rollIter >= numOfDiceRolls)
            { // The total # of rolls are done.

                timerDice.Stop(); // Disable the die timer.
                for (int dieFace = 0; dieFace < arrOfDiceRolls.Length; dieFace++)
                { // Reset the array of die rolls to 0 and graph it.
                    arrOfDiceRolls[dieFace] = 0;
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
            timerDice.Stop(); // Disable the die timer.
            for (int diceFace = 0; diceFace < arrOfDiceRolls.Length; diceFace++)
            { // Reset the array of die rolls to 0 and graph it.
                arrOfDiceRolls[diceFace] = 0;
                chrtFreqDist.Series["Dice-Sum Occurence"].Points.DataBindY(arrOfDiceRolls);
            }
            rollIter = 0; // Reset the whole roll iteration
            //chrtFreqDist.Update(); // Update the frequency distribution chart.
            btnStop.Visible = false; // Make the stop button unavailable and the frequency button available
            btnFreqDist.Visible = true;
        }

        // This button click generates the frequency distribution of dice rolls given by the user.
        // The user can choose the number of dice rolls.
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

            // See if the user entered an integer for the dice rolls.
            tryNumOfDiceRolls = int.TryParse(txtDiceRolls.Text, out numOfDiceRolls);
            if (!tryNumOfDiceRolls) // Guide the user to enter the valid number of die rolls.
            {
                MessageBox.Show("Please enter a valid number of die rolls...", "Enter Die Rolls");
                return; // Exit out of the button click.
            }
            else if (numOfDiceRolls <= 0) // Guide the user to enter a number greater than zero.
            {
                MessageBox.Show("Please enter a number greater than zero", "Enter Die Rolls");
                return; // Exit out of the button click.
            }

            for (int diceFace = 0; diceFace < arrOfDiceRolls.Length; diceFace++)
            { // Set the array of dice rolls to 0 and graph it.
                arrOfDiceRolls[diceFace] = 0;
                chrtFreqDist.Series["Dice-Sum Occurence"].Points.DataBindY(arrOfDiceRolls);
            }

            // Set the timer interval and start it.
            timerDice.Interval = Int32.Parse(cmbBxTickSelect);
            timerDice.Start();
            btnStop.Visible = true; // Make the stop button available and the frequency button unavailable
            btnFreqDist.Visible = false;
        }

    }
}
