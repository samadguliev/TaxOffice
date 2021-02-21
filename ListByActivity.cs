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
    public partial class ListByActivity : Form
    {
        private bool WasFiltered = false;
        private int EntityId = 0;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\TaxOffice\Database.mdf;Integrated Security=True");
        public ListByActivity()
        {
            InitializeComponent();
        }

        private void ListByActivity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.entity_activity". При необходимости она может быть перемещена или удалена.
            this.entity_activityTableAdapter.Fill(this.databaseDataSet.entity_activity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.entity". При необходимости она может быть перемещена или удалена.
            this.entityTableAdapter.Fill(this.databaseDataSet.entity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.activity". При необходимости она может быть перемещена или удалена.
            this.activityTableAdapter.Fill(this.databaseDataSet.activity);
            EntityTable.Columns[0].Visible = false;

        }

        private void getEntityBySelect()
        {
            WasFiltered = true;
            Con.Open();
            string query = "select * from entity_activity left join entity on entity_activity.entity_id = entity.Id where activity_id = '" + ActivitySelect.SelectedValue + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            _ = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EntityTable.DataSource = ds.Tables[0];
            //Kekw.Text = ActivitySelect.SelectedValue.ToString();
            Con.Close();
        }

        private void getAllEntity()
        {
            Con.Open();
            string query = "select * from entity";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            _ = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EntityTable.DataSource = ds.Tables[0];
            Con.Close();
        }


        void RefreshTable()
        {
            if (WasFiltered)
            {
                getEntityBySelect();
            }
            else
            {
                getAllEntity();
            }
        }

        private void ActivitySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            getEntityBySelect();
        }

        private void EntitySave_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand sqlCmd = new SqlCommand("EntityAddOrEdit", Con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                if (EntitySave.Text == "Save")
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@inn", innTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@kpp", kppTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@address", addressTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@phone", phoneTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@entityId", EntityId);
                    sqlCmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@inn", innTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@kpp", kppTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@address", addressTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@phone", phoneTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                }
                Reset();

                Con.Close();
                RefreshTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void EntityTable_DoubleClick(object sender, EventArgs e)
        {
            if (EntityTable.CurrentRow.Index != -1)
            {
                EntityId = Convert.ToInt32(EntityTable.CurrentRow.Cells[0].Value.ToString());
                nameTextBox.Text = EntityTable.CurrentRow.Cells[1].Value.ToString();
                innTextBox.Text = EntityTable.CurrentRow.Cells[2].Value.ToString();
                kppTextBox.Text = EntityTable.CurrentRow.Cells[3].Value.ToString();
                addressTextBox.Text = EntityTable.CurrentRow.Cells[4].Value.ToString();
                phoneTextBox.Text = EntityTable.CurrentRow.Cells[5].Value.ToString();

                EntitySave.Text = "Update";
                EntityDelete.Enabled = true;
            }
        }

        private void Reset()
        {
            nameTextBox.Text = innTextBox.Text = kppTextBox.Text = addressTextBox.Text = phoneTextBox.Text = "";
            EntitySave.Text = "Save";
            EntityId = 0;
            EntityDelete.Enabled = false;
        }

        private void EntityReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EntityDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand sqlCmd = new SqlCommand("EntityDelete", Con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@entityId", EntityId);
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
    }
}
