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
    public partial class BuyHistory : UserControl
    {
        Form1 F;
        public BuyHistory(Form1 frm)
        {
            F = frm;
            InitializeComponent();
        }

        private void BuyHistory_Load(object sender, EventArgs e)
        {
            var select = "select pname,img,price,category,provider,buyDate FROM BuyHistory bh join Product p on p.pid=bh.pid and cid="+F.client.Cid;
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            } 
        }
    }

    
}
