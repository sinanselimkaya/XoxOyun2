using System.Media;

namespace XoxOyun2
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Resourc.soundLbl);
        SoundPlayer playerWin = new SoundPlayer(Resourc.win);
        SoundPlayer playerberabere = new SoundPlayer(Resourc.berabere);
        int HamleSayacý = 9;
        string xoxDeðeri;
        private void ArkaplanRenk()
        {
            if (HamleSayacý % 2 == 1)
            {
                lbl1.BackColor = Color.Red;
                lbl2.BackColor = Color.Red;
                lbl3.BackColor = Color.Red;
                lbl4.BackColor = Color.Red;
                lbl5.BackColor = Color.Red;
                lbl6.BackColor = Color.Red;
                lbl7.BackColor = Color.Red;
                lbl8.BackColor = Color.Red;
                lbl9.BackColor = Color.Red;
            }
            else
            {
                lbl1.BackColor = Color.Yellow;
                lbl2.BackColor = Color.Yellow;
                lbl3.BackColor = Color.Yellow;
                lbl4.BackColor = Color.Yellow;
                lbl5.BackColor = Color.Yellow;
                lbl6.BackColor = Color.Yellow;
                lbl7.BackColor = Color.Yellow;
                lbl8.BackColor = Color.Yellow;
                lbl9.BackColor = Color.Yellow;

            }

        }
        private void SayacAzalt()
        {
            if (HamleSayacý % 2 == 1)
            {
                xoxDeðeri = "X";
                lblPromter.Text = "O'in sýrasý";
            }
            else
            {
                xoxDeðeri = "O";
                lblPromter.Text = "X'in sýrasý";
            }
            HamleSayacý = HamleSayacý - 1;

        }
        private void LabelSýfýrla()
        {
            lbl1.Text = " ";
            lbl2.Text = " ";
            lbl3.Text = " ";
            lbl4.Text = " ";
            lbl5.Text = " ";
            lbl6.Text = " ";
            lbl7.Text = " ";
            lbl8.Text = " ";
            lbl9.Text = " ";
            HamleSayacý = 9;
            lbl1.Enabled = true;
            lbl2.Enabled = true;
            lbl3.Enabled = true;
            lbl4.Enabled = true;
            lbl5.Enabled = true;
            lbl6.Enabled = true;
            lbl7.Enabled = true;
            lbl8.Enabled = true;
            lbl9.Enabled = true;
            lbl1.BackColor = lblPromter.BackColor;
            lbl2.BackColor = lblPromter.BackColor;
            lbl3.BackColor = lblPromter.BackColor;
            lbl4.BackColor = lblPromter.BackColor;
            lbl5.BackColor = lblPromter.BackColor;
            lbl6.BackColor = lblPromter.BackColor;
            lbl7.BackColor = lblPromter.BackColor;
            lbl8.BackColor = lblPromter.BackColor;
            lbl9.BackColor = lblPromter.BackColor;

            lblPromter.Text = "X'in sýrasý";
        }
        private void KontrolEt()
        {

            if ((lbl1.Text == "X" && lbl2.Text == "X" && lbl3.Text == "X") || (lbl1.Text == "O" && lbl2.Text == "O" && lbl3.Text == "O"))
            {
                playerWin.Play();
                if (lbl1.Text == "X" && lbl2.Text == "X" && lbl3.Text == "X")
                {
                    MessageBox.Show("X Kazandý");

                }

                else if (lbl1.Text == "O" && lbl2.Text == "O" && lbl3.Text == "O")
                {
                    MessageBox.Show("O Kazandý");

                }

                LabelSýfýrla();

            }
            else if ((lbl4.Text == "X" && lbl5.Text == "X" && lbl6.Text == "X") || (lbl4.Text == "O" && lbl5.Text == "O" && lbl6.Text == "O"))
            {
                playerWin.Play();
                if (lbl4.Text == "X" && lbl5.Text == "X" && lbl6.Text == "X")
                    MessageBox.Show("X Kazandý");
                else if (lbl4.Text == "O" && lbl5.Text == "O" && lbl6.Text == "O")
                {
                    MessageBox.Show("O Kazandý");
                }
                LabelSýfýrla();

            }
            else if ((lbl7.Text == "X" && lbl8.Text == "X" && lbl9.Text == "X") || (lbl7.Text == "O" && lbl8.Text == "O" && lbl9.Text == "O"))
            {
                playerWin.Play();
                if (lbl7.Text == "X" && lbl8.Text == "X" && lbl9.Text == "X")
                    MessageBox.Show("X Kazandý");
                else if (lbl7.Text == "O" && lbl8.Text == "O" && lbl9.Text == "O")
                {
                    MessageBox.Show("O Kazandý");
                }
                LabelSýfýrla();

            }
            else if (((lbl1.Text == "X" && lbl5.Text == "X" && lbl9.Text == "X") || (lbl1.Text == "O" && lbl5.Text == "O" && lbl9.Text == "O")))
            {
                playerWin.Play();
                if (lbl1.Text == "X")
                    MessageBox.Show("X Kazandý");
                else if (lbl1.Text == "O")
                    MessageBox.Show("O Kazandý");

                LabelSýfýrla();
            }
            else if ((lbl3.Text == "X" && lbl5.Text == "X" && lbl7.Text == "X") || (lbl3.Text == "O" && lbl5.Text == "O" && lbl7.Text == "O"))
            {
                playerWin.Play();
                if (lbl3.Text == "X" && lbl5.Text == "X" && lbl7.Text == "X")
                    MessageBox.Show("X Kazandý");
                else if (lbl3.Text == "O" && lbl5.Text == "O" && lbl7.Text == "O")
                {
                    MessageBox.Show("O Kazandý");
                }

                LabelSýfýrla();
            }
            else if ((lbl1.Text == "X" && lbl4.Text == "X" && lbl7.Text == "X") || (lbl1.Text == "O" && lbl4.Text == "O" && lbl7.Text == "O"))
            {
                playerWin.Play();
                if (lbl1.Text == "X" && lbl4.Text == "X" && lbl7.Text == "X")
                { MessageBox.Show("X Kazandý"); }

                else if (lbl1.Text == "O" && lbl4.Text == "O" && lbl7.Text == "O")
                {
                    MessageBox.Show("O Kazandý");
                }
                LabelSýfýrla();
            }
            else if ((lbl2.Text == "X" && lbl5.Text == "X" && lbl8.Text == "X") || (lbl2.Text == "O" && lbl5.Text == "O" && lbl8.Text == "O"))
            {
                playerWin.Play();

                if (lbl2.Text == "X" && lbl5.Text == "X" && lbl8.Text == "X")
                { MessageBox.Show("X Kazandý"); }

                else if (lbl2.Text == "O" && lbl5.Text == "O" && lbl8.Text == "O")
                {
                    MessageBox.Show("O Kazandý");
                }
                LabelSýfýrla();

            }
            else if ((lbl3.Text == "X" && lbl6.Text == "X" && lbl9.Text == "X") || (lbl3.Text == "O" && lbl6.Text == "O" && lbl9.Text == "O"))
            {
                playerWin.Play();
                if (lbl3.Text == "X" && lbl6.Text == "X" && lbl9.Text == "X")
                { MessageBox.Show("X Kazandý"); }

                else if (lbl3.Text == "O" && lbl6.Text == "O" && lbl9.Text == "O")
                {
                    MessageBox.Show("O Kazandý");
                }
                LabelSýfýrla();
            }
            else if (HamleSayacý == 0)
            {
                playerberabere.Play();
                MessageBox.Show("Berabere Kaldýnýz");
                LabelSýfýrla();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            player.Play();
            SayacAzalt();
            lbl1.Text = xoxDeðeri;
            lbl1.Enabled = false;
            KontrolEt();
            ArkaplanRenk();

        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl2.Text = xoxDeðeri;
            lbl2.Enabled = false;
            KontrolEt();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl3.Text = xoxDeðeri;
            lbl3.Enabled = false;
            KontrolEt();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl4.Text = xoxDeðeri;
            lbl4.Enabled = false;
            KontrolEt();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl5.Text = xoxDeðeri;
            lbl5.Enabled = false;
            KontrolEt();

        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl6.Text = xoxDeðeri;
            lbl6.Enabled = false;
            KontrolEt();

        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl7.Text = xoxDeðeri;
            lbl7.Enabled = false;
            KontrolEt();
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl8.Text = xoxDeðeri;
            lbl8.Enabled = false;
            KontrolEt();
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            player.Play();
            ArkaplanRenk();
            SayacAzalt();
            lbl9.Text = xoxDeðeri;
            lbl9.Enabled = false;
            KontrolEt();
        }
    }
}
