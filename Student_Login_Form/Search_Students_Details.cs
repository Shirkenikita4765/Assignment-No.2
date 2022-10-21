using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Login_Form
{
    public partial class frm_Search_Students_Details : Form
    {
        public frm_Search_Students_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Login_Form_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con_Close();
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Moboile_No.Clear();
            dtp_DOB.Text = " ";
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Add_New_student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            this.Hide();
            obj.Show();

        }

        private void btn_View_Students_List_Click(object sender, EventArgs e)
        {
            frm_View_Students_List obj = new frm_View_Students_List();
            this.Hide();
            obj.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Log Out???", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
                this.Hide();
            }
        }

      
      

    }
}
