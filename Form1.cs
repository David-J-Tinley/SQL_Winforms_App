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

namespace SqlWinformsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            string Connection_String = @"Server=DJT-LAPTOP\SQLEXPRESS;Database=master;Trusted_Connection=true;";
            Text_Content.Clear();
            Text_Content.Text = "";

            using (SqlConnection conn = new SqlConnection(Connection_String))
            {
                // Set the command to execute against the sql server (this is where the query is set)
                string query = @"SELECT [fileid], [filename] FROM sysfiles";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Open the connection
                conn.Open();

                // The actual command execution
                SqlDataReader reader = cmd.ExecuteReader();

                // If reader has any rows, retrieve them
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Handle the retrieved record i.e. display it
                        Text_Content.AppendText(reader.GetInt16(0) + " - " + reader.GetString(1) + Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show("No data found");
                }
                // Redundant? Connections supposedly close by themselves?
                reader.Close();
            }
        }
    }
}
