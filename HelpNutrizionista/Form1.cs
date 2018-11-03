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
        private static OleDbConnection conn = new OleDbConnection("provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'C:\\Users\\carna\\Desktop\\tabella_alimenti.xls'; Extended properties = Excel 8.0");
        private static DataSet dt = new DataSet();
        private static OleDbDataAdapter command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataset();
        }

        private void fillDataset()
        {
            command = new OleDbDataAdapter("Select * From [Foglio1$]", conn);
            command.TableMappings.Add("Table", "TestTable");
            command.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            conn.Close();
        }
    }
}
