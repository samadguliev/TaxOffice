
namespace TaxOffice
{
    partial class ListByEntity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            this.EntitySelect = new System.Windows.Forms.ComboBox();
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new TaxOffice.DatabaseDataSet();
            this.entityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.entityTableAdapter();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.activityTableAdapter();
            this.tableAdapterManager = new TaxOffice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ActivityTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ActivityReset = new System.Windows.Forms.Button();
            this.ActivityDelete = new System.Windows.Forms.Button();
            this.ActivitySave = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityTable)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            nameLabel.Location = new System.Drawing.Point(18, 361);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(102, 24);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Название:";
            // 
            // EntitySelect
            // 
            this.EntitySelect.DataSource = this.entityBindingSource;
            this.EntitySelect.DisplayMember = "name";
            this.EntitySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntitySelect.FormattingEnabled = true;
            this.EntitySelect.Location = new System.Drawing.Point(22, 36);
            this.EntitySelect.Name = "EntitySelect";
            this.EntitySelect.Size = new System.Drawing.Size(615, 28);
            this.EntitySelect.TabIndex = 0;
            this.EntitySelect.ValueMember = "Id";
            this.EntitySelect.SelectedIndexChanged += new System.EventHandler(this.EntitySelect_SelectedIndexChanged);
            // 
            // entityBindingSource
            // 
            this.entityBindingSource.DataMember = "entity";
            this.entityBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entityTableAdapter
            // 
            this.entityTableAdapter.ClearBeforeFill = true;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.databaseDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activityTableAdapter = this.activityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entity_activityTableAdapter = null;
            this.tableAdapterManager.entityTableAdapter = this.entityTableAdapter;
            this.tableAdapterManager.UpdateOrder = TaxOffice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ActivityTable
            // 
            this.ActivityTable.AutoGenerateColumns = false;
            this.ActivityTable.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.ActivityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ActivityTable.DataSource = this.activityBindingSource;
            this.ActivityTable.Location = new System.Drawing.Point(22, 99);
            this.ActivityTable.Name = "ActivityTable";
            this.ActivityTable.Size = new System.Drawing.Size(665, 220);
            this.ActivityTable.TabIndex = 1;
            this.ActivityTable.DoubleClick += new System.EventHandler(this.ActivityTable_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(144, 358);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(493, 29);
            this.nameTextBox.TabIndex = 2;
            // 
            // ActivityReset
            // 
            this.ActivityReset.BackColor = System.Drawing.Color.Gold;
            this.ActivityReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityReset.ForeColor = System.Drawing.SystemColors.Control;
            this.ActivityReset.Location = new System.Drawing.Point(307, 434);
            this.ActivityReset.Name = "ActivityReset";
            this.ActivityReset.Size = new System.Drawing.Size(138, 48);
            this.ActivityReset.TabIndex = 20;
            this.ActivityReset.Text = "Reset";
            this.ActivityReset.UseVisualStyleBackColor = false;
            this.ActivityReset.Click += new System.EventHandler(this.ActivityReset_Click);
            // 
            // ActivityDelete
            // 
            this.ActivityDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.ActivityDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.ActivityDelete.Location = new System.Drawing.Point(469, 434);
            this.ActivityDelete.Name = "ActivityDelete";
            this.ActivityDelete.Size = new System.Drawing.Size(138, 48);
            this.ActivityDelete.TabIndex = 19;
            this.ActivityDelete.Text = "Delete";
            this.ActivityDelete.UseVisualStyleBackColor = false;
            this.ActivityDelete.Click += new System.EventHandler(this.ActivityDelete_Click);
            // 
            // ActivitySave
            // 
            this.ActivitySave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ActivitySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivitySave.ForeColor = System.Drawing.SystemColors.Control;
            this.ActivitySave.Location = new System.Drawing.Point(142, 434);
            this.ActivitySave.Name = "ActivitySave";
            this.ActivitySave.Size = new System.Drawing.Size(138, 48);
            this.ActivitySave.TabIndex = 18;
            this.ActivitySave.Text = "Save";
            this.ActivitySave.UseVisualStyleBackColor = false;
            this.ActivitySave.Click += new System.EventHandler(this.ActivitySave_Click);
            // 
            // ListByEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1404, 761);
            this.Controls.Add(this.ActivityReset);
            this.Controls.Add(this.ActivityDelete);
            this.Controls.Add(this.ActivitySave);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ActivityTable);
            this.Controls.Add(this.EntitySelect);
            this.Name = "ListByEntity";
            this.Text = "ListByEntity";
            this.Load += new System.EventHandler(this.ListByEntity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EntitySelect;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource entityBindingSource;
        private DatabaseDataSetTableAdapters.entityTableAdapter entityTableAdapter;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private DatabaseDataSetTableAdapters.activityTableAdapter activityTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ActivityTable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button ActivityReset;
        private System.Windows.Forms.Button ActivityDelete;
        private System.Windows.Forms.Button ActivitySave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}