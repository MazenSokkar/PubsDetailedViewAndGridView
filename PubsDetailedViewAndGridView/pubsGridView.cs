using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsDetailedViewAndGridView
{
    public partial class pubsGridView : Form
    {
        public pubsGridView()
        {
            InitializeComponent();

            sqlCN = new SqlConnection("Data Source=.;Initial Catalog=pubs;Integrated Security=true;TrustServerCertificate=True;");
        }

        SqlConnection sqlCN;
        SqlCommand sqlCMD;
        SqlDataAdapter DA;
        DataTable DT = new DataTable();
        BindingSource TitleBindingSource;

        private void pubsGridView_Load(object sender, EventArgs e)
        {
            sqlCMD = new SqlCommand("SELECT * FROM titles", sqlCN);

            DA = new SqlDataAdapter(sqlCMD);

            DA.Fill(DT);

            TitleBindingSource = new BindingSource();
            TitleBindingSource.DataSource = DT;

            titleGV.DataSource = TitleBindingSource;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(DA);

            DA.Update(DT);
        }
    }
}
