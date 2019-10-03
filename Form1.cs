using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CreateAndUseClass.UserBehaviors;

namespace CreateAndUseClass
{
    public partial class CreateUseClass1 : Form
    {
        public CreateUseClass1()
        {
            InitializeComponent();
        }

       
        // clsUser starts here. it gets and sets the users name and age for later use in the program
        

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            clsUserDetails objUser = new clsUserDetails();

           
            if(txtName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Error. Please fill in all details");
            }

            else
            {
                objUser.SetName(txtName.Text);

                /*Testing if the Age is a number using try parse, which checks if the text is in the correct format, e.g. int,
                 * and parse, which converts the text to the correct format */
                if(int.TryParse(txtAge.Text, out int iOut)&& txtAge.Text == "")
                {
                    objUser.SetAge(int.Parse(txtAge.Text));
                }

                else
                {
                    MessageBox.Show("Error. Age must be a number");
                }
            }

            txtNamePass.Text = objUser.GetName();
            txtAgePass.Text = Convert.ToString(objUser.GetAge());

            // makes the console beep, 1st num is frequency, 2nd is duration
            Console.Beep(300, 200);
        }
    }
}
