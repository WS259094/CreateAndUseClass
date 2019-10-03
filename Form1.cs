using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateAndUseClass
{
    public partial class CreateUseClass1 : Form
    {
        public CreateUseClass1()
        {
            InitializeComponent();
        }

        // clsUser starts here. it gets and sets the users name and age for later use in the program
        class clsUser
        {
            private string m_sName;
            private int m_iAge;

            public string GetName(string sName)
            {
                return m_sName;
            }
            
            public void SetName(string sName)
            {
                m_sName = sName;
            }

             public int GetAge(int iAge)
            {
                return m_iAge;
            }
            public void SetAge(int iAge)
            {
                m_iAge = iAge;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            clsUser objUser = new clsUser();
            if(txtName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Error. Please fill in all details");
            }

            else
            {
                objUser.SetName(txtName.Text);

                /*Testing if the Age is a number using try parse, which checks if the text is in the correct format, e.g. int,
                 * and parse, which converts the text to the correct format */
                if(int.TryParse(txtAge.Text, out int iOut))
                {
                    objUser.SetAge(int.Parse(txtAge.Text));
                }

                else
                {
                    MessageBox.Show("Error. Age must be a number");
                }
            }
            

            Console.Beep(20, 20);
        }
    }
}
