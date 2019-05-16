using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çizgeler
{
    public partial class frmGraph : Form
    {
        int size;
        public Graph birGraph;
        public frmGraph()
        {
            InitializeComponent();
        }

        private void btnKoseKaydet_Click(object sender, EventArgs e)
        {
            grpKenar.Visible = true;
            size = int.Parse(txtKose.Text);
            birGraph = new Graph(size);
        }

        private void btnKenarKaydet_Click(object sender, EventArgs e)
        {
            birGraph.ekle(int.Parse(txtBaslangic.Text) - 1, int.Parse(txtBitis.Text) - 1, int.Parse(txtUzaklik.Text));

            txtBaslangic.Clear();
            txtBitis.Clear();
            txtUzaklik.Clear();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {

            grpKoseCiftiBilgi.Visible = true;
            grpKoseBilgi.Visible = false;
        }

        private void btnKoseCiftiNoKaydet_Click(object sender, EventArgs e)
        {
            int a, b, uzaklık;

            a = int.Parse(txtKoseCiftiNo2.Text);
            b = int.Parse(txtKoseCiftiNo1.Text);

            uzaklık = birGraph.Dijktras(a - 1, b - 1);

            if (uzaklık != 1000)
                MessageBox.Show("Köşe çifti arasındaki en kısa uzaklık: " + uzaklık);
            else
                MessageBox.Show("Köşe çifti arasında bir yol yok!! ");

            txtKoseCiftiNo2.Clear();
            txtKoseCiftiNo1.Clear();
            grpKoseCiftiBilgi.Visible = false;
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            grpKoseBilgi.Visible = true;
        }

        private void btnKoseNoKaydet_Click(object sender, EventArgs e)
        {
            int x;
            ArrayList isimSırası = new ArrayList();

            lstListe.Items.Clear();

            x = int.Parse(txtKoseNo.Text);

            isimSırası = birGraph.BFS(x - 1);

            lstListe.Visible = true;

            foreach (int i in isimSırası)
                lstListe.Items.Add((i + 1) + "\n");

            txtBitis.Clear();
        }

        private void btnPrimTabanliAgac_Click(object sender, EventArgs e)
        {
            grpKoseBilgi.Visible = false;

            birGraph.MST();

            frmMinKapsayanAgac frmMinAgac = new frmMinKapsayanAgac(birGraph); 
            frmMinAgac.Show();

        }

        private void btnCizgeCiz_Click(object sender, EventArgs e)
        {
            grpKoseBilgi.Visible = false;
            frmCizgeCiz frmCiz = new frmCizgeCiz(birGraph);
            frmCiz.Show();
        }
    }
}
