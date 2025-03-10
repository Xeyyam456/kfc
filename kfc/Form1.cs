namespace kfc
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        //public string[] urunler = { "Şefburger", "Twister Junior", "Lunchbox Cemi", "Uşaq Menyusu",
        //                         "Cütlük Qutusu", "Dondurma", "Xüsusi Təklif", "Sərfəli Menu" };
        //public decimal[] qiymetler = { 3.90m, 2.90m, 13.00m, 8.30m, 10.90m, 0.50m, 3.60m, 6.30m };

        public Form1()
        {
            InitializeComponent();


        }

        private void btnSifarisEt_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }


        //private void btnSifarisEt_Click_1(object sender, EventArgs e)
        //{


        //    //int[] ededler = new int[8]; // Seçilmiş ədədləri tutmaq üçün array

        //    //for (int i = 0; i < 8; i++)
        //    //{
        //    //    NumericUpDown numericUpDown = (NumericUpDown)this.Controls.Find($"numericUpDown{i + 1}", true)[0];
        //    //    ededler[i] = (int)numericUpDown.Value;
        //    //}

        //    Form2 form2 = new Form2();
        //    form2.ShowDialog();


        //    //try
        //{



        //    //form2.SetSifaris(urunler, qiymetler, ededler);
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Bir hata oluştu: " + ex.Message);
        //}


        //}

        //private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        //{

        //}
    }
}

