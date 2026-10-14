namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> secimSirasi = new List<string>();
        public Form1()
        {
            InitializeComponent();

            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.MouseDown += listBox2_MouseDown;

            string[] sehirler =
            {
                "İstanbul",
                "Ankara",
                "İzmir",
                "Bursa",
                "Antalya",
                "Konya",
                "Adana",
                "Gaziantep",
                "Şanlıurfa",
                "Kocaeli"
            };
            listBox2.Items.AddRange(sehirler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            foreach (string sehir in secimSirasi)
            {
                if (listBox2.SelectedItems.Contains(sehir))
                {
                    listBox3.Items.Add(sehir);
                }
            }
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBox2.IndexFromPoint(e.Location);

            if (index == ListBox.NoMatches)
                return;

            string sehir = listBox2.Items[index].ToString();

            BeginInvoke(new Action(() =>
            {
                if (listBox2.SelectedIndices.Contains(index))
                {
                    if (!secimSirasi.Contains(sehir))
                        secimSirasi.Add(sehir);
                }
                else
                {
                    secimSirasi.Remove(sehir);
                }
            }));
        }
    }
}
