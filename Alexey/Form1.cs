using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Alexey.Properties;

namespace Alexey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alexeyDataSet1.vAlexey' table. You can move, or remove it, as needed.
            this.vAlexeyTableAdapter.Fill(this.alexeyDataSet1.vAlexey);

            // TODO: This line of code loads data into the 'alexeyDataSet.alexey' table. You can move, or remove it, as needed.
            this.alexeyTableAdapter.Fill(this.alexeyDataSet.alexey);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SqlConnection Conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=alexey;Integrated Security=True;Pooling=False");
            SqlConnection Conn = new SqlConnection(Settings.Default.alexeyConnectionString);

            SqlCommand CMD = new SqlCommand("InsertData", Conn);
            CMD.CommandType = CommandType.StoredProcedure;

            SqlParameter myParm1 = CMD.Parameters.Add("@Name", SqlDbType.NVarChar, 255);
            myParm1.Value = textBox1.Text;
            SqlParameter myParm2 = CMD.Parameters.Add("@Kolvo", SqlDbType.Int);
            myParm2.Value = textBox2.Text;
            SqlParameter myParm3 = CMD.Parameters.Add("@tsena", SqlDbType.Float);
            myParm3.Value = textBox3.Text;

            Conn.Open();

            CMD.ExecuteNonQuery();
            Conn.Close();

            alexeyTableAdapter.Fill(alexeyDataSet.alexey);
            vAlexeyTableAdapter.Fill(alexeyDataSet1.vAlexey);
        }
    }
}
