using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaxOffice
{
    public partial class ListOfRelations : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\TaxOffice\Database.mdf;Integrated Security=True");

        public ListOfRelations()
        {
            InitializeComponent();
        }

        private void entity_activityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entity_activityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void entityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.entityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void entity_activityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.entity_activityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void ListOfRelations_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.entity_activity". При необходимости она может быть перемещена или удалена.
            //this.entity_activityTableAdapter.Fill(this.databaseDataSet.entity_activity);
            //RelationsTable.Columns.Add("name", "name");

            try
            {
                Con.Open();

                SqlDataAdapter sqlData = new SqlDataAdapter("GetListOfRelations", Con);
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                RelationsTable.DataSource = dtbl;

                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
