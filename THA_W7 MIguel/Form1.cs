using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_MIguel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Label cinema;
        PictureBox venom;
        PictureBox jurasicc;
        PictureBox it;
        PictureBox endgame;
        PictureBox up;
        PictureBox johnwick4;
        PictureBox fastx;
        PictureBox maverick;

        Button buttonvenom;
        Button buttonjurasicc;
        Button buttonit;
        Button buttonendgame;
        Button buttonup;
        Button buttonjohnwick;
        Button buttonfastx;
        Button buttonmaverick;

        Form1 form1;
        Form2 form2;
        
        public static string moviekebrp;
        public static List<Button>[,] film = new List<Button>[100, 100];
        public static List<string> picture = new List<string>();
        public static List<string> judulfilm = new List<string>();
        string filmlist = File.ReadAllText(@"C:\Users\Michiellin Natalie G\source\repos\THA_W7 MIguel\THA_W7 MIguel\bin\Debug\listfilm.txt");

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] judul = filmlist.Split(',');
            foreach (string a in judul)
            {
                if (a[0] == 'C')
                {
                    picture.Add(a);
                }
                else
                {
                    judulfilm.Add(a);
                }
            }
            
            //judul
            cinema = new Label();
            cinema.Text = "Cinema Jelek";
            cinema.Font = new Font("Arial", 18, FontStyle.Bold);
            cinema.Location = new Point(500,5);
            cinema.Size = new Size(300, 30);
            cinema.ForeColor = Color.Black;
            this.Controls.Add(cinema);



            //film 1
            venom = new PictureBox();
            venom.Image = Image.FromFile(@picture[0]);
            venom.SizeMode = PictureBoxSizeMode.StretchImage;
            venom.Location = new Point(20,80);
            venom.Size = new Size(200, 230);
            this.Controls.Add(venom);

            buttonvenom = new Button();
            buttonvenom.Text = "WATCH";
            buttonvenom.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonvenom.Size = new Size(200, 30);
            buttonvenom.BackColor = Color.Red;
            buttonvenom.Location = new Point(20,330);
            buttonvenom.Click += Buttonvenom_Click;
            buttonvenom.Tag = "1";
            this.Controls.Add(buttonvenom);

            //film2
            jurasicc = new PictureBox();
            jurasicc.Image = Image.FromFile(@picture[1]);
            jurasicc.SizeMode = PictureBoxSizeMode.StretchImage;
            jurasicc.Location = new Point(320, 80);
            jurasicc.Size = new Size(200, 230);
            this.Controls.Add(jurasicc);

            buttonjurasicc = new Button();
            buttonjurasicc.Text = "WATCH";
            buttonjurasicc.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonjurasicc.Size = new Size(200, 30);
            buttonjurasicc.BackColor = Color.Red;
            buttonjurasicc.Location = new Point(320,330);
            buttonjurasicc.Click += Buttonjurasicc_Click;
            buttonjurasicc.Tag = "2";
            this.Controls.Add(buttonjurasicc);


            //film3
            it = new PictureBox();
            it.Image = Image.FromFile(@picture[2]);
            it.SizeMode = PictureBoxSizeMode.StretchImage;
            it.Location = new Point(620, 80);
            it.Size = new Size(200, 230);
            this.Controls.Add(it);

            buttonit = new Button();
            buttonit.Text = "WATCH";
            buttonit.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonit.Size = new Size(200, 30);
            buttonit.BackColor = Color.Red;
            buttonit.Location = new Point(620, 330);
            buttonit.Click += Buttonit_Click;
            buttonit.Tag = "3";
            this.Controls.Add(buttonit);


            //film4
            maverick = new PictureBox();
            maverick.Image = Image.FromFile(@picture[3]);
            maverick.SizeMode = PictureBoxSizeMode.StretchImage;
            maverick.Location = new Point(920, 80);
            maverick.Size = new Size(200, 230);
            this.Controls.Add(maverick);

            buttonmaverick = new Button();
            buttonmaverick.Text = "WATCH";
            buttonmaverick.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonmaverick.Size = new Size(200, 30);
            buttonmaverick.BackColor = Color.Red;
            buttonmaverick.Location = new Point(920, 330);
            buttonmaverick.Click += Buttonmaverick_Click;
            buttonmaverick.Tag = "4";
            this.Controls.Add(buttonmaverick);

            //film5
            fastx = new PictureBox();
            fastx.Image = Image.FromFile(@picture[4]);
            fastx.SizeMode = PictureBoxSizeMode.StretchImage;
            fastx.Location = new Point(20, 420);
            fastx.Size = new Size(200, 230);
            this.Controls.Add(fastx);

            buttonfastx = new Button();
            buttonfastx.Text = "WATCH";
            buttonfastx.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonfastx.Size = new Size(200, 30);
            buttonfastx.BackColor = Color.Red;
            buttonfastx.Location = new Point(20, 670);
            buttonfastx.Click += Buttonfastx_Click;
            buttonfastx.Tag = "5";
            this.Controls.Add(buttonfastx);

            //film6
            endgame = new PictureBox();
            endgame.Image = Image.FromFile(@picture[5]);
            endgame.SizeMode = PictureBoxSizeMode.StretchImage;
            endgame.Location = new Point(320, 420);
            endgame.Size = new Size(200, 230);
            this.Controls.Add(endgame);

            buttonendgame = new Button();
            buttonendgame.Text = "WATCH";
            buttonendgame.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonendgame.Size = new Size(200, 30);
            buttonendgame.BackColor = Color.Red;
            buttonendgame.Location = new Point(320, 670);
            buttonendgame.Click += Buttonendgame_Click;
            buttonendgame.Tag = "6";
            this.Controls.Add(buttonendgame);

            //film7
            up = new PictureBox();
            up.Image = Image.FromFile(@picture[6]);
            up.SizeMode = PictureBoxSizeMode.StretchImage;
            up.Location = new Point(620, 420);
            up.Size = new Size(200, 230);
            this.Controls.Add(up);

            buttonup = new Button();
            buttonup.Text = "WATCH";
            buttonup.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonup.Size = new Size(200, 30);
            buttonup.BackColor = Color.Red;
            buttonup.Location = new Point(620, 670);
            buttonup.Click += Buttonup_Click;
            buttonup.Tag = "7";
            this.Controls.Add(buttonup);

            //film8
            johnwick4 = new PictureBox();
            johnwick4.Image = Image.FromFile(@picture[7]);
            johnwick4.SizeMode = PictureBoxSizeMode.StretchImage;
            johnwick4.Location = new Point(920, 420);
            johnwick4.Size = new Size(200, 230);
            this.Controls.Add(johnwick4);

            buttonjohnwick = new Button();
            buttonjohnwick.Text = "WATCH";
            buttonjohnwick.Font = new Font("Arial", 15, FontStyle.Bold);
            buttonjohnwick.Size = new Size(200, 30);
            buttonjohnwick.BackColor = Color.Red;
            buttonjohnwick.Location = new Point(920, 670);
            buttonjohnwick.Click += Buttonjohnwick_Click;
            buttonjohnwick.Tag = "7";
            this.Controls.Add(buttonjohnwick);
        }

        private void Buttonvenom_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;
            it.Visible = false;
            up.Visible = false;
            johnwick4.Visible = false;
            

            buttonvenom.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonit.Visible = false;
            buttonup.Visible = false;
            buttonjohnwick.Visible = false;
        }

        private void Buttonjurasicc_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
        private void Buttonit_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
        private void Buttonmaverick_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
        private void Buttonfastx_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
        private void Buttonendgame_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
        private void Buttonup_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
        private void Buttonjohnwick_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            moviekebrp = send.Tag.ToString();
            this.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.Controls.Add(form2);
            form2.Show();

            cinema.Visible = false;
            venom.Visible = false;
            up.Visible = false;
            maverick.Visible = false;
            jurasicc.Visible = false;
            johnwick4.Visible = false;
            it.Visible = false;
            fastx.Visible = false;
            endgame.Visible = false;

            buttonvenom.Visible = false;
            buttonup.Visible = false;
            buttonmaverick.Visible = false;
            buttonjurasicc.Visible = false;
            buttonjohnwick.Visible = false;
            buttonit.Visible = false;
            buttonfastx.Visible = false;
            buttonendgame.Visible = false;
        }
    }
}
