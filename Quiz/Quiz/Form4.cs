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
using Microsoft.Office.Client.Education;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using MySql.Data.MySqlClient;




namespace Quiz
{
    public partial class Form4 : Form
    {
        //int slno = 1;
        //int count = 1;
        public Form4()
        {
            InitializeComponent();
            //int count = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (20 * 60 * 1000); // 20 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
 
           
                String myConnection = "datasource=localhost;port=3306;username=root;password=2015";
                MySqlConnection myconn = new MySqlConnection(myConnection);
               
                myconn.Open();   
            MySqlCommand cmdDataBase1 = new MySqlCommand("select * FROM quizdb.qans", myconn);
                
                try
                {
                    
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                   
                    sda.SelectCommand = cmdDataBase1;
                   
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    sda.Fill(dt);


                    foreach (DataRow myRow in dt.Rows)
                    {
                        label1.Text =  myRow[1].ToString();
                        radioButton1.Text = myRow[2].ToString();
                        radioButton2.Text = myRow[3].ToString();
                        radioButton3.Text = myRow[4].ToString();
                        radioButton4.Text = myRow[5].ToString();

                        //label1.Text = myRow[6].ToString();
                       
                    }

               



                }



                catch (Exception Exception)
                {
                    MessageBox.Show(Exception.Message);
                }
                myconn.Close();
            
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now be closed.", "Time Elapsed");
            this.Close();
        }

     

        

    }
}
             

        
            


    




        
            

         
    
                







       

      
        
      

        

       
        
    
   
            

   
       
           
        

       

      


        
    


