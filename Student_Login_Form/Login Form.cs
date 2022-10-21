using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Login_Form
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
             if (((tb_Username.Text == "Admin") && (tb_Password.Text == "A123")) || ((tb_Username.Text == "C") && (tb_Password.Text == "C123")))
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Invalid Username or Password";
                lbl_Error.ForeColor = Color.OrangeRed;
            }
            tb_Username.Clear();
            tb_Password.Clear();
            {
                tb_Password.Enabled = false;
                btn_Submit.Enabled = false;
                tb_Username.Focus();
            }

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            
                btn_Submit.Enabled = true;
            
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;

        }

      
    }
}
