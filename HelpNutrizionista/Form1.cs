using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace HelpNutrizionista
{
    public partial class Form1 : Form
    {
        private static OleDbConnection conn = new OleDbConnection("provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'tabella_alimenti.xls'; Extended properties =\"Excel 8.0;HDR=YES;\"");
        private static DataSet ds = new DataSet();
        private static System.Data.DataTable dt = new System.Data.DataTable();
        private static OleDbDataAdapter dataAdapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCombobox(cbAlimenti1);
        }

        private void fillCombobox(ComboBox cb)
        {
            dataAdapt = new OleDbDataAdapter("Select * From [Foglio4$]", conn);
            dataAdapt.TableMappings.Add("Table", "Alimenti");
            dataAdapt.Fill(ds);
            dataAdapt.Fill(ds);
            dataAdapt.Fill(ds);
            dataAdapt.Fill(ds);
            dataAdapt.Fill(ds);

            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = "Descrizione";
            cb.ValueMember = "ID";

            cb.Text = "--Seleziona un Alimento--";

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string PerCent(string ingresso, string molti)
        {
            double result = (Convert.ToDouble(ingresso) / 100) * Convert.ToDouble(molti);
            return result.ToString();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string ID = cbAlimenti1.SelectedValue.ToString();

            DataRow[] dr = ds.Tables[0].Select("ID = " + ID);

            ListViewItem listitem = new ListViewItem(dr[0][0].ToString());
            listitem.SubItems.Add(dr[0][1].ToString());
            listitem.SubItems.Add(textBox1.Text);
            listitem.SubItems.Add(txtEdibile.Text);
            listitem.SubItems.Add(txtCalorie.Text);
            listitem.SubItems.Add(txtProteine.Text);
            listitem.SubItems.Add(txtGrassi.Text);
            listitem.SubItems.Add(txtSaturi.Text);
            listitem.SubItems.Add(txtColest.Text);
            listitem.SubItems.Add(txtCarb.Text);
            listitem.SubItems.Add(txtZuc.Text);
            listView1.Items.Add(listitem);

            double sumKcal = 0;
            double sumProt = 0;
            double sumGras = 0;
            double sumSat = 0;
            double sumColest = 0;
            double sumCarb = 0;
            double sumZuc = 0;

            foreach (ListViewItem itemRow in this.listView1.Items)
            {

                sumKcal += Convert.ToDouble(itemRow.SubItems[4].Text);
                sumProt += Convert.ToDouble(itemRow.SubItems[5].Text);
                sumGras += Convert.ToDouble(itemRow.SubItems[6].Text);
                sumSat += Convert.ToDouble(itemRow.SubItems[7].Text);
                sumColest += Convert.ToDouble(itemRow.SubItems[8].Text);
                sumCarb += Convert.ToDouble(itemRow.SubItems[9].Text);
                sumZuc += Convert.ToDouble(itemRow.SubItems[10].Text);

            }

            txtTotCal.Text = sumKcal.ToString();
            txtTotProt.Text = sumProt.ToString();
            txtTotGras.Text = sumGras.ToString();
            txtTotSat.Text = sumSat.ToString();
            txtTotCol.Text = sumColest.ToString();
            txtTotCarb.Text = sumCarb.ToString();
            txtTotZuc.Text = sumZuc.ToString();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                string ID = cbAlimenti1.SelectedValue.ToString();

                DataRow[] dr = ds.Tables[0].Select("ID = " + ID);

                string edibile = PerCent(dr[0][2].ToString(), textBox1.Text);
                string calorie = PerCent(dr[0][4].ToString(), textBox1.Text);
                string proteine = PerCent(dr[0][6].ToString(), textBox1.Text);
                string lipidi = PerCent(dr[0][9].ToString(), textBox1.Text);
                string saturi = PerCent(dr[0][12].ToString(), textBox1.Text);
                string colesterolo = PerCent(dr[0][19].ToString(), textBox1.Text);
                string carboidrati = PerCent(dr[0][20].ToString(), textBox1.Text);
                string zuccheri = PerCent(dr[0][22].ToString(), textBox1.Text);

                txtEdibile.Text = edibile;
                txtCalorie.Text = calorie;
                txtProteine.Text = proteine;
                txtGrassi.Text = lipidi;
                txtSaturi.Text = saturi;
                txtColest.Text = colesterolo;
                txtCarb.Text = carboidrati;
                txtZuc.Text = zuccheri;
            }
            else
            {
                MessageBox.Show("Il campo Qtà deve essere compilato!!!", "ERRORE");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string writeLine = null;
            int pointY = 200;

            foreach (ListViewItem itemRow in this.listView1.Items)
            {
                e.Graphics.DrawString(itemRow.SubItems[1].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, pointY));
                e.Graphics.DrawString(itemRow.SubItems[2].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(300, pointY));
                e.Graphics.DrawString(itemRow.SubItems[3].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(350, pointY));
                e.Graphics.DrawString(itemRow.SubItems[4].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(400, pointY));
                e.Graphics.DrawString(itemRow.SubItems[5].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(450, pointY));
                e.Graphics.DrawString(itemRow.SubItems[6].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(500, pointY));
                e.Graphics.DrawString(itemRow.SubItems[7].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(550, pointY));
                e.Graphics.DrawString(itemRow.SubItems[8].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(600, pointY));
                e.Graphics.DrawString(itemRow.SubItems[9].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(650, pointY));
                e.Graphics.DrawString(itemRow.SubItems[10].Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(700, pointY));

                pointY += 20;
            }

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string str = null;
            SaveFileDialog dia = new SaveFileDialog();
            dia.Filter = "Word Document (docx) | *.docx | Word Document (doc) | *.doc";
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                str = dia.FileName;

                object oMissing = System.Reflection.Missing.Value;

                //Start Word and create a new document.
                Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();

                Microsoft.Office.Interop.Word._Document oDoc = new Microsoft.Office.Interop.Word.Document();

                oWord.Visible = true;

                oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                //Insert a paragraph at the beginning of the document.
                Microsoft.Office.Interop.Word.Paragraph oPara1;

                oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = "Dieta Personalizzata";
                oPara1.Range.Font.Bold = 1;
                oPara1.Range.Font.Name = "Arial";
                oPara1.Format.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.

                oDoc.SaveAs2(str);

                oDoc.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtTotCal.Text = "";
            txtTotProt.Text = "";
            txtTotGras.Text = "";
            txtTotSat.Text = "";
            txtTotCol.Text = "";
            txtTotCarb.Text = "";
            txtTotZuc.Text = "";

        }
    }
}
