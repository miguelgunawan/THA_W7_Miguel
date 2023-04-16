using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_MIguel
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        PictureBox picturefilm;
        Form1 form1;
        Form2 form2;
        Label label1;
        Label layar;
        Label pilihkursi;
        Button[] button1 = new Button[3];
        Button[,] button2 = new Button[10, 10];
        Button submit;
        Button reset;

        Random rnd = new Random();
        string kursi = "";
        List<string> kodekursi = new List<string>();
        public static List<String> jamfilm = new List<String>();
        int moviejam;
        int nofilm = Convert.ToInt32(Form1.moviekebrp);
        int a, b, x, y;
        char[] angka = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'j' };
        int counter = 0;

        public void nampilinkursi()
        {
            a = 40;
            b = 0;
            int probability = rnd.Next(0, 70);
            int count = 0;
            panel1.Controls.Clear();

            layar = new Label();
            layar.Text = "---------------------------------------LAYAR---------------------------------------";
            layar.Location = new Point(30, 600);
            layar.Font = new Font("Arial", 15, FontStyle.Bold);
            layar.Size = new Size(1000, 20);
            layar.ForeColor = Color.Black;
            this.panel1.Controls.Add(layar);

            reset = new Button();
            reset.Location = new Point(550, 550);
            reset.Size = new Size(100, 30);
            reset.Font = new Font("Arial", 15, FontStyle.Bold);
            reset.ForeColor = Color.Black;
            reset.BackColor = Color.Green;
            reset.Text = "Reset";
            reset.Click += Reset_Click;
            this.panel1.Controls.Add(reset);

            submit = new Button();
            submit.Location = new Point(35, 520);
            submit.Size = new Size(480, 30);
            submit.Font = new Font("Arial", 12, FontStyle.Bold);
            submit.ForeColor = Color.Black;
            submit.BackColor = Color.Yellow;
            submit.Text = "Confirm Order";
            submit.Click += Submit_Click;
            this.panel1.Controls.Add(submit);

            //nge-random
            if (Form1.film[nofilm, moviejam] == null)
            {
                Form1.film[nofilm, moviejam] = new List<Button>();
                counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int warna = rnd.Next(2);
                        button2[i, j] = new Button();
                        button2[i, j].Location = new Point(a, b);
                        button2[i, j].Size = new Size(50, 50);
                        button2[i, j].ForeColor = Color.Black;
                        button2[i, j].Font = new Font("Arial", 10, FontStyle.Bold);
                        button2[i, j].Text = angka[counter].ToString() + (j + 1);
                        button2[i, j].Tag = (angka[counter].ToString() + (j + 1)).ToString();
                        button2[i, j].Click += Form2_Clicka;

                        if (count < probability && warna == 0)
                        {
                            button2[i, j].BackColor = Color.Red;
                            count++;
                            button2[i, j].Enabled = false;
                        }
                        else
                        {
                            button2[i, j].BackColor = Color.Green;
                        }

                        Form1.film[nofilm, moviejam].Add(button2[i, j]);
                        a += 60;
                    }
                    b += 50;
                    a = 40;
                    counter++;
                }
                foreach (Button button in Form1.film[nofilm, moviejam])
                {
                    this.panel1.Controls.Add(button);
                }
            }
            else
            {
                foreach (Button button in Form1.film[nofilm, moviejam])
                {
                    this.panel1.Controls.Add(button);
                }
            }
        }

        private void Form2_Clicka(object sender, EventArgs e)
        {
            var send = sender as Button;

            if (send.BackColor == Color.Green)
            {
                send.BackColor = Color.Red;
                kursi = send.Tag.ToString();
                kodekursi.Add(kursi);
                pilihkursi.Text = "";
                pilihkursi.Text = "kursi dipilih: ";

                foreach (string k in kodekursi)
                {
                    pilihkursi.Text += k;
                }
                this.Controls.Add(pilihkursi);
            }

            else if (send.BackColor == Color.Red)
            {
                kursi = send.Tag.ToString();
                kodekursi.Remove(kursi);
                pilihkursi.Text = "";
                pilihkursi.Text = "kursi dipilih: ";
                foreach (string k in kodekursi)
                {
                    pilihkursi.Text += k;
                }
                send.BackColor = Color.Green;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;

            x = 500;
            y = 50;
            for (int i = 0; i < 3; i++)
            {
                button1[i] = new Button();
                button1[i].Location = new Point(x, y);
                button1[i].Size = new Size(200, 50);
                button1[i].ForeColor = Color.Black;
                button1[i].Font = new Font("Arial", 20, FontStyle.Bold);
                button1[i].Tag = i.ToString();
                button1[i].Click += Form2_Click;
                this.Controls.Add(button1[i]);
                x += 200;
            }

            picturefilm = new PictureBox();
            picturefilm.Size = new Size(300, 350);
            picturefilm.Location = new Point(50, 50);
            picturefilm.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picturefilm);

            label1 = new Label();
            label1.Size = new Size(300, 200);
            label1.Location = new Point(50, 400);
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            this.Controls.Add(label1);

            submit = new Button();
            submit.Location = new Point(520, 630);
            submit.Size = new Size(600, 30);
            submit.Font = new Font("Arial", 15, FontStyle.Bold);
            submit.ForeColor = Color.Black;
            submit.BackColor = Color.Orange;
            submit.Text = "Confirm Order";
            submit.Click += Submit_Click;
            this.panel1.Controls.Add(submit);

            pilihkursi = new Label();
            pilihkursi.Size = new Size(200, 200);
            pilihkursi.Location = new Point(45, 650);
            pilihkursi.Font = new Font("Arial", 12, FontStyle.Bold);
            pilihkursi.ForeColor = Color.Black;
            pilihkursi.Text = "kursi dipilih: ";
            this.Controls.Add(pilihkursi);

            switch (nofilm)
            {
                case 1:
                    picturefilm.Image = Image.FromFile(Form1.@picture[0]);
                    label1.Text = "Venom                                                        Venom Spiderman Ireng";
                    button1[0].Text = "13:00";
                    button1[1].Text = "17:00";
                    button1[2].Text = "22:00";
                    break;

                case 2:

                    picturefilm.Image = Image.FromFile(Form1.@picture[1]);
                    label1.Text = "Jurasicc World                                             Dunia Dinosaurus";
                    button1[0].Text = "14:00";
                    button1[1].Text = "17:00";
                    button1[2].Text = "20:00";
                    break;
                case 3:
                    picturefilm.Image = Image.FromFile(Form1.@picture[2]);
                    label1.Text = " IT                                                          Setan Baadut";
                    button1[0].Text = "11:00";
                    button1[1].Text = "15:00";
                    button1[2].Text = "20:00";
                    break;
                case 4:
                    picturefilm.Image = Image.FromFile(Form1.@picture[3]);
                    label1.Text = "Top Gun Maverick";
                    button1[0].Text = "16:00";
                    button1[1].Text = "18:00";
                    button1[2].Text = "22:00";
                    break;
                case 5:
                    picturefilm.Image = Image.FromFile(Form1.@picture[4]);
                    label1.Text = "Fast X";
                    button1[0].Text = "12:00";
                    button1[1].Text = "16:00";
                    button1[2].Text = "22:00";
                    break;
                case 6:
                    picturefilm.Image = Image.FromFile(Form1.@picture[5]);
                    label1.Text = "Avengers End Game";
                    button1[0].Text = "13:00";
                    button1[1].Text = "19:00";
                    button1[2].Text = "23:00";
                    break;
                case 7:
                    picturefilm.Image = Image.FromFile(Form1.@picture[6]);
                    label1.Text = "UP";
                    button1[0].Text = "10:00";
                    button1[1].Text = "19:00";
                    button1[2].Text = "23:00";
                    break;
                case 8:
                    picturefilm.Image = Image.FromFile(Form1.@picture[7]);
                    label1.Text = "John Wick 4";
                    button1[1].Text = "15:00";
                    button1[2].Text = "22:00";
                    break;
            }
        }
        // BUTTON SUBMIT
        private void Submit_Click(object sender, EventArgs e)
        {
            foreach (Button button in Form1.film[nofilm, moviejam])
            {
                if (button.BackColor == Color.Red)
                {
                    button.Enabled = false;
                }
            }
            this.Controls.Clear();

            form1 = new Form1();
            form1.TopLevel = false;
            form1.Dock = DockStyle.Fill;
            this.Controls.Add(form1);
            form1.Show();
        }
        //BUTTON RESET
        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (Button button in Form1.film[nofilm, moviejam])
            {
                button.Enabled = true;
                button.BackColor = Color.Green;
            }
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            var send = sender as MenuStrip;
            for (int i = 0; i < 3; i++)
            {
                if (sender == button1[i])
                {
                    moviejam = Convert.ToInt32(button1[i].Tag.ToString());
                }
            }
            nampilinkursi();
        }
    }
    //Mari
}
