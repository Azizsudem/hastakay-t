using System.ComponentModel;

namespace deneme
{
    public partial class Form1 : Form
    {
        BindingList<Hasta> hastalar = new BindingList<Hasta>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hasta hasta1 = new Hasta { Id = 1, AdSoyad = "Sudem Aziz", Birim = "Göz", Tarih = DateTime.Now, Yas = 25, Sigorta = true };
            Hasta hasta2 = new Hasta { Id = 2, AdSoyad = "Ceren Meriç", Birim = "KBB", Tarih = DateTime.Now, Yas = 26, Sigorta = false };
            Hasta hasta3 = new Hasta { Id = 3, AdSoyad = "Gülsüm Tunç", Birim = "Dahiliye", Tarih = DateTime.Now, Yas = 27, Sigorta = true };

            hastalar.Add(hasta1);
            hastalar.Add(hasta2);
            hastalar.Add(hasta3);

            dataGridView1.DataSource = hastalar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textId.Text);
            string adSoyad = textAdSoyad.Text;
            string birim = cmbBirim.Text;
            int yas = Convert.ToInt32(textYas.Text);
            bool sigorta = Sigorta.Checked;
            DateTime dateTime = dtTarih.Value;

            Hasta hasta = new Hasta { Id = Id, AdSoyad = adSoyad, Birim = birim, Tarih = dateTime, Sigorta = sigorta, Yas = yas };

            hastalar.Add(hasta);
        }
        private void dataGridViev1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0);
            {
                Hasta hasta = (Hasta)dataGridView1.SelectedRows[0].DataBoundItem;

                textId.Text = hasta.Id.ToString();
                textAdSoyad.Text = hasta.AdSoyad;
                textYas.Text = hasta.Yas.ToString();   
                cmbBirim.Text = hasta.Birim;
                dtTarih.Value = hasta.Tarih;
                Sigorta.Checked = hasta.Sigorta;
            }
        }
    }
}
