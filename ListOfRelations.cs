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
        private int RelationId = 0;

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

        private void RefreshTable()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sqlData = new SqlDataAdapter("GetListOfRelations", Con);
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                RelationsTable.DataSource = dtbl;
                RelationAddEntitySelect.SelectedIndex = -1;
                RelationAddActSelect.SelectedIndex = -1;

                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Reset()
        {
            RelationSave.Text = "Save";
            RelationId = 0;
            RelationDelete.Enabled = false;

            RelationAddEntitySelect.SelectedIndex = -1;
            RelationAddActSelect.SelectedIndex = -1;
        }

        private void ListOfRelations_Load(object sender, EventArgs e)
        {
            this.activityTableAdapter.Fill(this.databaseDataSet.activity);
            this.entityTableAdapter.Fill(this.databaseDataSet.entity);
            RefreshTable();
        }

        private void RelationSave_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand sqlCmd = new SqlCommand("RelationAddOrEdit", Con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                if (RelationSave.Text == "Save")
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Id", RelationId);
                    sqlCmd.Parameters.AddWithValue("@entityId", Convert.ToInt32(RelationAddEntitySelect.SelectedValue));
                    sqlCmd.Parameters.AddWithValue("@activityId", Convert.ToInt32(RelationAddActSelect.SelectedValue));
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");
                }
                else 
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Id", RelationId);
                    sqlCmd.Parameters.AddWithValue("@entityId", Convert.ToInt32(RelationAddEntitySelect.SelectedValue));
                    sqlCmd.Parameters.AddWithValue("@activityId", Convert.ToInt32(RelationAddActSelect.SelectedValue));
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                }
                Con.Close();
                RefreshTable();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void RelationDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand sqlCmd = new SqlCommand("RelationDelete", Con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@Id", RelationId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully");
                Reset();

                Con.Close();
                RefreshTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void RelationReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void RelationsTable_DoubleClick(object sender, EventArgs e)
        {
            if (RelationsTable.CurrentRow.Index != -1)
            {
                RelationId = Convert.ToInt32(RelationsTable.CurrentRow.Cells[0].Value.ToString());

                RelationAddEntitySelect.SelectedValue = Convert.ToInt32(RelationsTable.CurrentRow.Cells[1].Value.ToString());
                RelationAddActSelect.SelectedValue = Convert.ToInt32(RelationsTable.CurrentRow.Cells[2].Value.ToString());

                RelationSave.Text = "Update";
                RelationDelete.Enabled = true;
            }
        }
    }
}
