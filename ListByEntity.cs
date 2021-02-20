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
    public partial class ListByEntity : Form
    {
        private bool WasFiltered = false;
        private int ActivityId = 0;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\TaxOffice\Database.mdf;Integrated Security=True");

        public ListByEntity()
        {
            InitializeComponent();
        }

        private void ListByEntity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.activity". При необходимости она может быть перемещена или удалена.
            this.activityTableAdapter.Fill(this.databaseDataSet.activity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.entity". При необходимости она может быть перемещена или удалена.
            this.entityTableAdapter.Fill(this.databaseDataSet.entity);
            ActivityTable.Columns[0].Visible = false;
        }

        private void getAllActivity()
        {
            Con.Open();
            string query = "select * from activity";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            _ = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ActivityTable.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void getActivityBySelect()
        {
            WasFiltered = true;
            Con.Open();
            string query = "select * from entity_activity left join activity on entity_activity.activity_id = activity.Id where entity_id = '" + EntitySelect.SelectedValue + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            _ = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ActivityTable.DataSource = ds.Tables[0];
            Con.Close();
        }

        void RefreshTable()
        {
            if (WasFiltered)
            {
                getActivityBySelect();
            }
            else
            {
                getAllActivity();
            }
        }

        private void EntitySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            getActivityBySelect();
        }

        private void ActivitySave_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand sqlCmd = new SqlCommand("ActivityAddOrEdit", Con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                if (ActivitySave.Text == "Save")
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@activityId", ActivityId);
                    sqlCmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@activityId", ActivityId);
                    sqlCmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
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

        private void ActivityTable_DoubleClick(object sender, EventArgs e)
        {
            if (ActivityTable.CurrentRow.Index != -1)
            {
                ActivityId = Convert.ToInt32(ActivityTable.CurrentRow.Cells[0].Value.ToString());
                nameTextBox.Text = ActivityTable.CurrentRow.Cells[1].Value.ToString();

                ActivitySave.Text = "Update";
                ActivityDelete.Enabled = true;
            }
        }

        private void Reset()
        {
            nameTextBox.Text = "";
            ActivitySave.Text = "Save";
            ActivityId = 0;
            ActivityDelete.Enabled = false;
        }

        private void ActivityReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ActivityDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand sqlCmd = new SqlCommand("ActivityDelete", Con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@activityId", ActivityId);
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
