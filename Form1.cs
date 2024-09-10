using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_using_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBUAB5J;Initial Catalog=nafis;Persist Security Info=True;User ID=sa;Password=nafis99;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Practice values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + int.Parse(textBox4.Text) + "', getdate())", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            BindData();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Practice ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Practice set Name='" + textBox2.Text + "',Age ='" + textBox3.Text + "',Type ='" + comboBox1.Text + "',Contact ='" + textBox4.Text + "' where ID = '" + int.Parse(textBox1.Text) + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully Updated.");
            con.Close();
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Practice where ID = '" + int.Parse(textBox1.Text) + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully Deleted.");
            con.Close();
            BindData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Practice where ID = '" + int.Parse(textBox1.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
