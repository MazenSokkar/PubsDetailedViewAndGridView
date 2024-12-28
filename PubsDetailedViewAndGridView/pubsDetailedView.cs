using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsDetailedViewAndGridView
{
    public partial class pubsDetailedView : Form
    {
        public pubsDetailedView()
        {
            InitializeComponent();

            sqlCn = new SqlConnection("Data Source=Mazen\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=true;TrustServerCertificate=True;");

        }

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT = new DataTable();
        BindingSource TitleBindingSource;

        private void pubsDetailedView_Load(object sender, EventArgs e)
        {
            sqlCmd = new SqlCommand("SELECT * FROM titles;", sqlCn);

            DA = new SqlDataAdapter(sqlCmd);

            DA.Fill(DT);

            TitleBindingSource = new BindingSource();
            TitleBindingSource.DataSource = DT;

            titleIdCB.DataSource = TitleBindingSource;
            titleIdCB.DisplayMember = "title_id";
            titleIdCB.ValueMember = "title_id";

            titleTB.DataBindings.Add("Text", TitleBindingSource, "title");

            typeCB.DataSource = TitleBindingSource;
            typeCB.DisplayMember = "type";

            priceTB.DataBindings.Add("Text", TitleBindingSource, "price");
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            TitleBindingSource.MovePrevious();
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            TitleBindingSource.MoveNext();
        }
    }
}
