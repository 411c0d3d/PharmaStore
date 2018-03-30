using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Demo
{
    public partial class ClientsForm : UserControl
    {
        Form1 ths;
        public ClientsForm(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            var select = "select * FROM Client ";
            var dataAdapter = new SqlDataAdapter(select,ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.AllowUserToAddRows = false;
        }
        void dataGridView2_CellClick(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count != 0)
            {
                int cid = Int32.Parse(dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                string cname = dataGridView2.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
                string email = dataGridView2.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
                string pwd = dataGridView2.SelectedCells[0].OwningRow.Cells[3].Value.ToString();
                decimal balance = Decimal.Parse(dataGridView2.SelectedCells[0].OwningRow.Cells[4].Value.ToString());
                ths.eClient = new Client(cid, cname, email, pwd, balance);
            }
            if (ths.eClient != null)
            {
                DialogResult dialogResult = MessageBox.Show("Edit Client N' " + ths.eClient.Cid + " ?", "confirm edit Client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Dispose();
                    // to Do display edit Client Form here
                    this.Dispose();
                    ths.ec = new EditClient(ths);
                    ths.bgPanel.Controls.Add(ths.ec);
                    ths.ec.ClientIdLab.Text += " " + ths.eClient.Cid.ToString();
                    ths.ec.nameBox.Text = ths.eClient.Cname.ToString();
                    ths.ec.emailBox.Text = ths.eClient.Email.ToString();
                    ths.ec.balanceBox.Text = ths.eClient.Balance.ToString();
                    ths.ec.submit.Click += new EventHandler(ths.ec.submit_Click);
                    ths.ec.Location = new Point(160, 115);
                }
            }
        }
    }
}
