using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AbdurrahmanPadela_HospitalManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lastnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void agelabel_Click(object sender, EventArgs e)
        {

        }

        private void phonenumberlabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // code used to exit the form
            this.Close();
            // code to clear items (male, female, other) from gender listbox
            genderlistBox.Items.Clear();
        }

        private void addpatientbutton_Click(object sender, EventArgs e)
        {
            // create string variable gender
            string Gender;
            // create string variable name
            string Name;
            // create string variable age
            string Age;


            // create string variable stateresidence
            string stateresidence;
            // create string variable zipcode
            string zipcode;
            // create string variable operation
            string operation;
            // create string variable date
            string date;
            // hold double variable room to zero
            double room = 0;
            // create object for random class
            Random rand = new Random();
            // hold double variable to be 50. This is the dollar charge to see the doctor per visit.
            double visit = 50;
            // hold double variable for number of visits
            double numbervisits;
            // total cost is set to zero to ensure that the $50 visit charge will efficiently multiply with the number of patient visits to see the doctor.
            double totalcost = 0;
            // hold int value for systolic pressure
            int systolic;
            // hold int value for diastolic pressure
            int diastolic;

            //array size declarator is 3, with a positive integer and literal value. Size declarator is also set with textbox which will include emailtextbox, phonetextbox, and hometextbox. 
            const int SIZE = 3;
            string[] textbox = new string[SIZE];
            textbox[0] = emailtextBox.Text;
            textbox[1] = phonetextBox.Text;
            textbox[2] = hometextBox.Text;

            // MessageBoxes showing values that have been set for textbox 0 - emailtextbox, textbox 1 - phonetextbox, and textbox 2 - hometextbox.
            MessageBox.Show(textbox[0]);
            MessageBox.Show(textbox[1]);
            MessageBox.Show(textbox[2]);

            // string age is declared with age textbox.
            Age = agetextBox.Text;
            // MessageBox to show age.
            MessageBox.Show(Age);
            // string stateresidence is declared with statetextBox.
            stateresidence = statetextBox.Text;
            // MessageBox to show state residence.
            MessageBox.Show(stateresidence);
            // string zipcode is delcared with ziptextbox.
            zipcode = ziptextBox.Text;
            // MessageBox to show zip.
            MessageBox.Show(zipcode);
            // string operation is delcared with operation textbox.
            operation = operationtextBox.Text;
            // MessageBox to show operation.
            MessageBox.Show(operation);
            // string date is declared with date textbox.
            date = datetextBox.Text;
            // MessageBox to show date.
            MessageBox.Show(date);
            // Random room value is set between these values.
            room = rand.Next(100 - 50);
            // Random room value is then converted to roomnumberlabel using room.ToString method.
            roomnumberlabel.Text = room.ToString();
            {
                // If radio button showing doctor michael is checked, messagebox will show "Dr.Michael" as patient's doctor.
                if (michaelradioButton.Checked == true)
                    MessageBox.Show("Dr.Michael");
            }
            //value for numbervisitstextbox is converted to double which then gives an out value of numbervisits.
            if (double.TryParse(numbervisitstextBox.Text, out numbervisits))
                //visit (which is the base value charge of $50) multiplied by the numbervisits results in the totalcost charge.
                totalcost = visit * numbervisits;
            // totalpatientvisitcostlabel displays the totalcost amount.
            totalpatientvisitcostlabel.Text = totalcost.ToString();

            // value and messagebox of full name is given by adding the textvalues of both firstnametextbox.Text and lastnametextBox.text
            Name = firstnametextBox.Text + lastnametextBox.Text;
            MessageBox.Show(Name);

            // Inside the listbox, if one of the items(male, female, other) are selected, it will then give the resulting gender value for the item you selected
            if (genderlistBox.SelectedIndex != -1)
            {
                // the item of gender from the listbox is converted to a string value.
                Gender = genderlistBox.SelectedItem.ToString();
                MessageBox.Show(Gender);
            }
            //Bloodpressure systolic textBox input is classified as int variable systolic.
            if (int.TryParse(bloodpressureStextBox.Text, out systolic))
            {
                // if systolic value is less than 120 or greater than 120, messagebox warning will be shown.
                if (systolic < 120 || systolic > 120)
                    MessageBox.Show("Warning! Systolic blood pressure is abnormal.");
            }
            // Bloodpressure Diastolic textbox input classified as int variable diastolic.
            if (int.TryParse(bloodpressureDtextBox.Text, out diastolic))
            {
                // if diastolic value is less than 80, diastolic blood pressure is too low
                if (diastolic < 80)
                    MessageBox.Show("Warning! Diastolic blood pressure is too low!");
            }
            // else if statement stating that if the diastolic value is greater than 80, that means the diastolic blood pressure is too high.
            else if (diastolic > 80)
            {
                MessageBox.Show("Warning! Your diastolic blood pressure is too high!");
            }
            // the systolic value through streamwriter is classified to a new txtfile called systolicvalue. The txtfile will only be created if the systolic int values are greater than 120. then
            int[] numbers = { systolic };
            StreamWriter outputFile;
            outputFile = File.CreateText("SystolicValue.txt");
            for (int index = 0; index > 120; index++)
            {
                outputFile.WriteLine(numbers[index]);
            }
        }
        private void agetextBox_TextChanged(object sender, EventArgs e)
        {

        }
        // DisplayMessage method t
        private void DisplayMessage(string v)
        {
            DisplayMessage("Please enter accurate information.");
        }
        // If radio button showing doctor steven is checked, messagebox will show "Dr.Steven" as patient's doctor.
        private void stevenradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stevenradioButton.Checked == true)
                MessageBox.Show("Dr.Steven");
        }
        // If radio button showing doctor michael is checked, messagebox will show "Dr.Michael" as patient's doctor.
        private void michaelradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (michaelradioButton.Checked == true)
                MessageBox.Show("Dr.Michael");
        }

        private void exportbutton_Click(object sender, EventArgs e)
        {
            // through the use of streamwrite outputFile, a new textfile is created with the textlines of textBoxes listed below.
            StreamWriter outputFile;
            outputFile = File.CreateText("Patient Data.txt");
            outputFile.WriteLine(agetextBox.Text, emailtextBox.Text, hometextBox.Text, statetextBox.Text, ziptextBox.Text, operationtextBox.Text, datetextBox.Text, datetextBox.Text, roomnumberlabel.Text, numbervisitstextBox.Text, totalpatientvisitcostlabel.Text, bloodpressureStextBox.Text, bloodpressureDtextBox.Text, weighttextBox.Text);

        }
        // Private void method to show name up to 5 times using while.
        private void ShowName(string name)
        {
            int count = 1;
            while (count <= 5)
                MessageBox.Show(name);
        }

        // Private void method to give overweight or underweight warning messages if the weight value is 250 or 100.
        private void distolebutton_Click(object sender, EventArgs e)
        {
            // Switch statement is used with a separate case for 250 and a separate case for 100.
            int weight;
            if (int.TryParse(weighttextBox.Text, out weight))
                switch (weight)
                {
                    case 250:
                        MessageBox.Show("You are overweight!");
                        break;
                    case 100:
                        MessageBox.Show("You are underweight!");
                        break;
                }
        }

        // private void method when pressing the button, hello. When you press the button, helo, messagebox will be shown up to 2 times with count value to be +1, since ++ is used.
        private void hellobutton_Click(object sender, EventArgs e)
        {
            for (int count = 1; count <= 2; count++)
            {
                MessageBox.Show("Hello, welcome to the hospital management software system. Please follow all directions.");
            }
        }
    }
}
