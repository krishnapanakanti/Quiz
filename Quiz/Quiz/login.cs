using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;




namespace Quiz
{
    public partial class login : Form
    {
         public login()
        {
            InitializeComponent();
        }

         private void signin_Click(object sender, EventArgs e) 
         {
             try
             {
                 string myconn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
                 SqlConnection con = new SqlConnection(myconn);


                 SqlCommand command = new SqlCommand(
        "Select * from Student_Info where Username='" + this.username_txt.Text + "' and Password='" + this.password_txt.Text + "';", con);


                 SqlDataReader myReader;
                 con.Open();
                 myReader = command.ExecuteReader();
                 int count = 0;
                 while (myReader.Read())
                 {
                     count = count + 1;
                 }
                 if (count == 1)
                 {
                     welcome f2 = new welcome();
                     f2.Show();
                     this.Hide();
                 }
                 else if (count > 1)
                 {
                     MessageBox.Show("Duplicate username and password.. Access denied");

                 }
                 else
                     MessageBox.Show("Username and password is not correct.. Please try again");




                 con.Close();


             }
             catch (Exception Exception)
             {
                 MessageBox.Show(Exception.Message);
             }
         }

         private void Form1_Load(object sender, EventArgs e)
         {
             this.TopMost = true;
             this.FormBorderStyle = FormBorderStyle.None;
             this.WindowState = FormWindowState.Maximized;
             // Set Form's Transperancy 100 %
             this.Opacity = 0;

             // Start the Timer To Animate Form
             timer1.Enabled = true;
         }

        

         private void timer1_Tick(object sender, EventArgs e)
         {
             this.Opacity += 0.07;
         }
         
    }
}
