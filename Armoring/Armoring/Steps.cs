using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;


namespace Armoring
{

    public partial class Steps : Form
    {

        private Dictionary<int, string> pairService = new Dictionary<int, string>()
        {

        };
        private DateTime start, end;
        private int rate;

        Info user;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["tourismDB"].ConnectionString);
        Graphics g;

        Rectangle circleStepOne = new Rectangle(50, 80, 50, 50);
        Rectangle circleStepTwo = new Rectangle(142, 80, 50, 50);
        Rectangle circleStepThree = new Rectangle(237, 80, 50, 50);
        Rectangle circleStepFour =  new Rectangle(333, 80, 50, 50);


        private bool drag = false;
        private Point MP = new Point();
        private Point p = new Point();
        private Point pos = new Point();

        List<Label> Drags = new List<Label>();
        List<Label> star = new List<Label>();

        private void DragClick(object sender, MouseEventArgs e)
        {
            MP = PointToClient(MousePosition);
            p = new Point(MP.X - (sender as Label).Location.X, MP.Y - (sender as Label).Location.Y);
            drag = true;
            pos = (sender as Label).Location;
        }
        private void DragHover(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                MP = PointToClient(MousePosition);
                (sender as Label).Location =  new Point(MP.X - p.X, MP.Y - p.Y); ;
            }

        }
        private void DragDown(object sender, MouseEventArgs e)
        {
            drag = false;


            foreach (var txt in Drags)
            {
                Point centerLb = new Point((sender as Label).Location.X+(sender as Label).Width/2, (sender as Label).Location.Y+(sender as Label).Height/2);
                Point center = new Point(txt.Location.X+txt.Width/2, txt.Location.Y+txt.Height/2);

                if (centerLb.X> center.X-txt.Width+10 && centerLb.X< center.X+txt.Width-20
                         && centerLb.Y> center.Y-txt.Height+10 && centerLb.Y< center.Y+txt.Height-10)
                {
                    (sender as Label).BackColor = Color.Red;
                    txt.Text = (sender as Label).Text;
                    Drags.Remove(txt);
                    (sender as Label).Enabled = false;
                    break;
                }
            }
            (sender as Label).Location = pos;
        }

        public Steps()
        {
            InitializeComponent();

            trackBar1.TickStyle = TickStyle.None;
            trackBar2.TickStyle = TickStyle.None;

            label6.Text = trackBar1.Value.ToString();
            label7.Text = trackBar2.Value.ToString();

            conn.Open();

            Drags.Add(lb_firstprio);
            Drags.Add(lb_secondprio);
            Drags.Add(lb_thirdprio);

            star.Add(lb_onestar);
            star.Add(lb_twostar);
            star.Add(lb_threestar);
            star.Add(lb_fourstar);
            star.Add(lb_fivestar);

            panel_thirdstep.Hide();
            panel1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("The connection is established!");
                }
                else { throw new InvalidConnectionException(); }
            }
            catch (InvalidConnectionException ice)
            {
                MessageBox.Show(ice.Message);
            }

            panel_secondstep.Hide();

        }
        
        private int SplitLabel(Label label)
        {
            int thisrate = 0;

            string[] rate = label.Text.Split('.');
            thisrate = int.Parse(rate[0]);

            return thisrate;
        }

        private int GiveRate(int one, int two, int three)
        {
            int rate = 0;

            rate = one + two + three;
            MessageBox.Show(rate.ToString());
            return rate;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            panel_firststep.Hide();
            btn_firststep_title.BackColor = Color.Gray;
            btn_secondstep_title.BackColor = Color.Green;
            panel_secondstep.Show();

            /*
            start = dtp_start.Value.Date;
            end = dtp_end.Value.Date;

            int days = int.Parse(tb_days.Text);
            int count = int.Parse(tb_peoplecount.Text);

            DateTime _start = start;
            DateTime _end = end;
            
            bool _checked = cb_kids.Checked;
            */

            user = new Info(start, end, int.Parse(tb_days.Text), int.Parse(tb_peoplecount.Text), cb_kids.Checked);
            
        }

        private void Steps_MouseUp(object sender, MouseEventArgs e)
        {
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            rate = GiveRate(SplitLabel(lb_firstprio), SplitLabel(lb_secondprio), SplitLabel(lb_thirdprio));
            btn_secondstep_title.BackColor = Color.Gray;
            btn_thirdstep.BackColor = Color.Green;
            panel_secondstep.Hide();
            panel_thirdstep.Show();

        }

        private int GetStars(List<Label> star)
        {
            int stars = 0;
            foreach (var value in star)
            {
                if (value.ForeColor == Color.Yellow)
                {
                    stars++;
                }
            }

            return stars;
        }


        private void btn_nextthird_Click(object sender, EventArgs e)
        {
            int stars = 0;
            if (GetStars(star) == 0)
            {
                MessageBox.Show("Выберите хотя бы одну звезду!");
                return;
            }
            else
            {
                // допилить получение инфы
                stars += GetStars(star);
                user.SetMin(double.Parse(trackBar1.Value.ToString()));
                user.SetMax(double.Parse(trackBar2.Value.ToString()));
                DataTable Fill = new DataTable();
                SqlDataAdapter fill = new SqlDataAdapter($"SELECT id, hotelname, places, country, city, stars FROM HotelImport WHERE stars = {stars}", conn);
                fill.Fill(Fill);
                dataGridView1.DataSource = Fill;
            }
           
            panel_thirdstep.Hide();
            panel1.Show();
            btn_thirdstep.BackColor = Color.Gray;
            btn_fourthstep.BackColor = Color.Green;

        }

        private void lb_onestar_Click(object sender, EventArgs e)
        {
            lb_onestar.ForeColor = Color.Yellow;
            lb_twostar.ForeColor = Color.Black;
            lb_threestar.ForeColor = Color.Black;
            lb_fourstar.ForeColor = Color.Black;
            lb_fivestar.ForeColor = Color.Black;
        }

        private void lb_twostar_Click(object sender, EventArgs e)
        {
            lb_onestar.ForeColor = Color.Yellow;
            lb_twostar.ForeColor = Color.Yellow;
            lb_threestar.ForeColor = Color.Black;
            lb_fourstar.ForeColor = Color.Black;
            lb_fivestar.ForeColor = Color.Black;
        }

        private void lb_threestar_Click(object sender, EventArgs e)
        {
            lb_onestar.ForeColor = Color.Yellow;
            lb_twostar.ForeColor = Color.Yellow;
            lb_threestar.ForeColor = Color.Yellow;
            lb_fourstar.ForeColor = Color.Black;
            lb_fivestar.ForeColor = Color.Black;
        }

        private void lb_fourstar_Click(object sender, EventArgs e)
        {
            lb_onestar.ForeColor = Color.Yellow;
            lb_twostar.ForeColor = Color.Yellow;
            lb_threestar.ForeColor = Color.Yellow;
            lb_fourstar.ForeColor = Color.Yellow;
            lb_fivestar.ForeColor = Color.Black;
        }

        private void lb_fivestar_Click(object sender, EventArgs e)
        {
            lb_onestar.ForeColor = Color.Yellow;
            lb_twostar.ForeColor = Color.Yellow;
            lb_threestar.ForeColor = Color.Yellow;
            lb_fourstar.ForeColor = Color.Yellow;
            lb_fivestar.ForeColor = Color.Yellow;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar2.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand all = new SqlCommand("SELECT country FROM HotelList", conn);

            SqlDataReader read = all.ExecuteReader();

            List<string> names = new List<string>();

            while (read.Read())
            {
                names.Add(read.GetValue(0).ToString());
            }
            read.Close();
            MessageBox.Show(names[0]);
            Random random = new Random();
            foreach (var value in names)
            {
                SqlCommand insert = new SqlCommand($"UPDATE HotelList SET places = {random.Next(15, 62)} WHERE country = '{value}'", conn);
                insert.ExecuteNonQueryAsync();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 2; i <= 102; i++)
            {
                SqlCommand insert = new SqlCommand($"INSERT INTO HotelList (cost) VALUES ({random.Next(5000, 250000)})", conn);
                insert.ExecuteNonQueryAsync();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Armor"].Index)
            {
                Armoring armor = new Armoring(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()), user.GiveDays(), user.GiveCount());
                armor.ShowDialog();
                
            }
        }

        private void btn_panel_firststep_skip_Click(object sender, EventArgs e)
        {

        }
    }
}
