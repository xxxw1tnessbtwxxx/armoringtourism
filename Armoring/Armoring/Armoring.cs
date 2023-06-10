using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armoring
{
    public partial class Armoring : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["tourismDB"].ConnectionString);

        private string hotelname;
        private int days, count;
        private double cost;
        private int id;

        public Armoring(int id, int days, int childrens)
        {
            InitializeComponent();
            this.id = id;
            this.days = days;
            count = childrens;
            conn.Open();
           
            
        }

        private void btn_armor_Click(object sender, EventArgs e)
        {
            if (tb_surname.Text != String.Empty && tb_lastname.Text != String.Empty && tb_Phone.Text != String.Empty && tb_pass.Text != String.Empty)
            {

                SqlCommand armor = new SqlCommand($"INSERT INTO Armor VALUES ('{tb_name.Text}', '{tb_surname.Text}', '{tb_lastname.Text}', '{tb_Phone.Text}', '{tb_pass.Text}', '{tb_countdays.Text}', '{tb_countchild.Text}', '{cost}')", conn);
                armor.ExecuteNonQuery();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cost = double.Parse(tb_countdays.Text + tb_countchild.Text);
            label7.Text = $"Итого к оплате: {cost}";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cost = double.Parse(tb_countdays.Text + tb_countchild.Text);
            label7.Text = $"Итого к оплате: {cost}";
        }

        private void Armoring_Load(object sender, EventArgs e)
        {
            tb_countdays.Text = days.ToString();
            tb_countchild.Text = count.ToString();
            SqlCommand getId = new SqlCommand($"SELECT cost FROM HotelImport WHERE id = {id}", conn);
            
            SqlDataReader read = getId.ExecuteReader();
            read.Read();
            cost = double.Parse(read.GetValue(0).ToString());
            read.Close();
            cost = double.Parse(tb_countdays.Text + tb_countchild.Text);
            label7.Text = $"Итого к оплате: {cost}";
        }
    }
}
