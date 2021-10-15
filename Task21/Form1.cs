﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Task21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = GetPlayersList();
        }

        private DataTable GetPlayersList()
        {
            DataTable dtPlayers = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Players", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtPlayers.Load(reader);
                }
            }

            return dtPlayers;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string conString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection con = new SqlConnection(conString);
            DataTable dt = new DataTable();
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Players WHERE BattingAverage >= @min AND BattingAverage <= @max", con))
                {
                    cmd.Parameters.AddWithValue("min", minimumTextBox.Text);
                    cmd.Parameters.AddWithValue("max", maximumTextBox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(dt);

                    dataGridViewPlayerAvg.DataSource = dt;
                }
            }

        }
    }
}
