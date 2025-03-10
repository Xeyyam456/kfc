namespace kfc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
        }

        public Form2(Dictionary<string, int> sifarisler)
        {
            InitializeComponent();
        }

        //public void SetSifaris(string[] urunler, decimal[] qiymetler, int[] ededler)
        //{
        //    decimal umumicemi = 0; // Ümumi məbləğ

        //    for (int i = 0; i < urunler.Length; i++)
        //    {
        //        if (ededler[i] > 0) // Əgər məhsul sifariş edilibsə
        //        {
        //            decimal umumi = qiymetler[i] * ededler[i]; // Məhsulun ümumi qiyməti

        //            // Məhsul adını yazdır
        //            this.Controls.Find($"label{i + 1}", true)[0].Text = urunler[i];

        //            // Ədədini yazdır
        //            this.Controls.Find($"label{i + 9}", true)[0].Text = ededler[i].ToString();

        //            // Qiyməti yazdır
        //            this.Controls.Find($"label{i + 17}", true)[0].Text = $"{qiymetler[i]:0.00} AZN";

        //            // Ümumi qiyməti yazdır
        //            this.Controls.Find($"label{i + 25}", true)[0].Text = $"{umumi:0.00} AZN";

        //            // Ümumi cəmi artır
        //            umumicemi += umumi;
        //        }
        //    }

        //    // Ümumi məbləği yazdır
        //    cem.Text = $"{umumicemi:0.00} AZN";
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
