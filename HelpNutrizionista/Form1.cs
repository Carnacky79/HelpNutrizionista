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

namespace HelpNutrizionista
{
    public partial class Form1 : Form
    {
        private static OleDbConnection conn = new OleDbConnection("provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'C:\\Users\\carna\\Desktop\\tabella_alimenti.xls'; Extended properties =\"Excel 8.0;HDR=YES;\"");
        private static DataSet ds = new DataSet();
        private static DataTable dt = new DataTable();
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

            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = "Descrizione";
            cb.ValueMember = "ID";

            cb.Text = "--Seleziona un Alimento--";

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private float PerCent(float ingresso, float molti)
        {
            return (ingresso / 100) * molti;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string ID = cbAlimenti1.SelectedValue.ToString();

            DataRow[] dr = ds.Tables[0].Select("ID = " + ID);

            listBox1.Items.Add(dr[0][0].ToString() + " | " + dr[0][1].ToString() + " | " + dr[0][2].ToString() + " | ");

            MessageBox.Show(dr[0][2].ToString());
        }
    }
}
