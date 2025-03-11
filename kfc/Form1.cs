namespace kfc
{
    public partial class Form1 : Form
    {

        //Form3 Form3;







        public string[] urunler = { "Şefburger", "Twister Junior", "Lunchbox Cemi", "Uşaq Menyusu",
                                 "Cütlük Qutusu", "Dondurma", "Xüsusi Təklif", "Sərfəli Menu" };
        public decimal[] qiymetler = { 3.90m, 2.90m, 13.00m, 8.30m, 10.90m, 0.50m, 3.60m, 6.30m };

        public Form1()
        {
            InitializeComponent();


        }

        decimal total = 0;

        private void btnSifarisEt_Click(object sender, EventArgs e)
        {


            Form3 form3 = new Form3();



            if (numericUpDown1.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown1.Value);
                total += (say * qiymetler[0]);
                form3.label1.Text = urunler[0];
                form3.label17.Text = qiymetler[0].ToString();
                form3.label9.Text = numericUpDown1.Value.ToString();
                form3.label25.Text = (say * qiymetler[0]).ToString();


                form3.label1.Visible = true;
                form3.label9.Visible = true;
                form3.label17.Visible = true;
                form3.label25.Visible = true;
                form3.eded1.Visible = true;
                form3.azn1.Visible = true;
                form3.azn9.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown2.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown2.Value);
                total += (say * qiymetler[1]);
                form3.label2.Text = urunler[1];
                form3.label18.Text = qiymetler[1].ToString();
                form3.label10.Text = numericUpDown2.Value.ToString();
                form3.label26.Text = (say * qiymetler[1]).ToString();


                form3.label2.Visible = true;
                form3.label10.Visible = true;
                form3.label18.Visible = true;
                form3.label26.Visible = true;
                form3.eded2.Visible = true;
                form3.azn2.Visible = true;
                form3.azn10.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown3.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown3.Value);
                total += (say * qiymetler[2]);
                form3.label3.Text = urunler[2];
                form3.label19.Text = qiymetler[2].ToString();
                form3.label11.Text = numericUpDown3.Value.ToString();
                form3.label27.Text = (say * qiymetler[2]).ToString();


                form3.label3.Visible = true;
                form3.label11.Visible = true;
                form3.label19.Visible = true;
                form3.label27.Visible = true;
                form3.eded3.Visible = true;
                form3.azn3.Visible = true;
                form3.azn11.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown4.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown4.Value);
                total += (say * qiymetler[3]);
                form3.label4.Text = urunler[3];
                form3.label20.Text = qiymetler[3].ToString();
                form3.label12.Text = numericUpDown4.Value.ToString();
                form3.label28.Text = (say * qiymetler[3]).ToString();


                form3.label4.Visible = true;
                form3.label12.Visible = true;
                form3.label20.Visible = true;
                form3.label28.Visible = true;
                form3.eded4.Visible = true;
                form3.azn4.Visible = true;
                form3.azn12.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown5.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown5.Value);
                total += (say * qiymetler[4]);
                form3.label5.Text = urunler[4];
                form3.label21.Text = qiymetler[4].ToString();
                form3.label13.Text = numericUpDown5.Value.ToString();
                form3.label29.Text = (say * qiymetler[4]).ToString();


                form3.label5.Visible = true;
                form3.label13.Visible = true;
                form3.label21.Visible = true;
                form3.label29.Visible = true;
                form3.eded5.Visible = true;
                form3.azn5.Visible = true;
                form3.azn13.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown6.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown6.Value);
                total += (say * qiymetler[5]);
                form3.label6.Text = urunler[5];
                form3.label22.Text = qiymetler[5].ToString();
                form3.label14.Text = numericUpDown6.Value.ToString();
                form3.label30.Text = (say * qiymetler[5]).ToString();


                form3.label6.Visible = true;
                form3.label14.Visible = true;
                form3.label22.Visible = true;
                form3.label30.Visible = true;
                form3.eded6.Visible = true;
                form3.azn6.Visible = true;
                form3.azn14.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown7.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown7.Value);
                total += (say * qiymetler[6]);
                form3.label7.Text = urunler[6];
                form3.label23.Text = qiymetler[6].ToString();
                form3.label15.Text = numericUpDown7.Value.ToString();
                form3.label31.Text = (say * qiymetler[6]).ToString();


                form3.label7.Visible = true;
                form3.label15.Visible = true;
                form3.label23.Visible = true;
                form3.label31.Visible = true;
                form3.eded7.Visible = true;
                form3.azn7.Visible = true;
                form3.azn15.Visible = true;
                form3.cem.Text = total.ToString();

            }
            if (numericUpDown8.Value != 0)
            {
                decimal say = Convert.ToDecimal(numericUpDown8.Value);
                total += (say * qiymetler[7]);
                form3.label8.Text = urunler[7];
                form3.label24.Text = qiymetler[7].ToString();
                form3.label16.Text = numericUpDown8.Value.ToString();
                form3.label32.Text = (say * qiymetler[7]).ToString();


                form3.label8.Visible = true;
                form3.label16.Visible = true;
                form3.label24.Visible = true;
                form3.label32.Visible = true;
                form3.eded8.Visible = true;
                form3.azn8.Visible = true;
                form3.azn16.Visible = true;
                form3.cem.Text = total.ToString();

            }










            form3.Show();
            //this.Hide();
        }


















        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

