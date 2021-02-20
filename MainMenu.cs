using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxOffice
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ViewListByActivity_Click(object sender, EventArgs e)
        {
            var listByActivity = new ListByActivity();
            listByActivity.Show();
        }

        private void ViewListByEntity_Click(object sender, EventArgs e)
        {
            var listByEntity = new ListByEntity();
            listByEntity.Show();
        }

        private void ViewRelationsList_Click(object sender, EventArgs e)
        {
            var listOfRelations = new ListOfRelations();
            listOfRelations.Show();
        }
    }
}
