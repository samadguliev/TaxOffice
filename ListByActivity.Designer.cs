
namespace TaxOffice
{
    partial class ListByActivity
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
            System.Windows.Forms.Label innLabel;
            System.Windows.Forms.Label kppLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label label1;
            this.databaseDataSet = new TaxOffice.DatabaseDataSet();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.activityTableAdapter();
            this.ActivitySelect = new System.Windows.Forms.ComboBox();
            this.activityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.entityTableAdapter();
            this.tableAdapterManager = new TaxOffice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.entity_activityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.entity_activityTableAdapter();
            this.EntityTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entity_activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntitySave = new System.Windows.Forms.Button();
            this.EntityDelete = new System.Windows.Forms.Button();
            this.EntityReset = new System.Windows.Forms.Button();
            this.EntityAddActivitySelect = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.kppTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            kppLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntityTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            nameLabel.Location = new System.Drawing.Point(61, 382);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(102, 24);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Название:";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            innLabel.ForeColor = System.Drawing.SystemColors.Window;
            innLabel.Location = new System.Drawing.Point(61, 422);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(54, 24);
            innLabel.TabIndex = 7;
            innLabel.Text = "ИНН:";
            // 
            // kppLabel
            // 
            kppLabel.AutoSize = true;
            kppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kppLabel.ForeColor = System.Drawing.SystemColors.Window;
            kppLabel.Location = new System.Drawing.Point(61, 461);
            kppLabel.Name = "kppLabel";
            kppLabel.Size = new System.Drawing.Size(53, 24);
            kppLabel.TabIndex = 9;
            kppLabel.Text = "КПП:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.ForeColor = System.Drawing.SystemColors.Window;
            addressLabel.Location = new System.Drawing.Point(61, 503);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 24);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Адрес:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.ForeColor = System.Drawing.SystemColors.Window;
            phoneLabel.Location = new System.Drawing.Point(61, 548);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(95, 24);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Телефон:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.Window;
            label1.Location = new System.Drawing.Point(61, 596);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 24);
            label1.TabIndex = 19;
            label1.Text = "Вид деят.:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ActivitySelect
            // 
            this.ActivitySelect.DataSource = this.activityBindingSource1;
            this.ActivitySelect.DisplayMember = "name";
            this.ActivitySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivitySelect.FormattingEnabled = true;
            this.ActivitySelect.Location = new System.Drawing.Point(62, 42);
            this.ActivitySelect.Name = "ActivitySelect";
            this.ActivitySelect.Size = new System.Drawing.Size(711, 33);
            this.ActivitySelect.TabIndex = 0;
            this.ActivitySelect.ValueMember = "Id";
            this.ActivitySelect.SelectedIndexChanged += new System.EventHandler(this.ActivitySelect_SelectedIndexChanged);
            // 
            // activityBindingSource1
            // 
            this.activityBindingSource1.DataMember = "activity";
            this.activityBindingSource1.DataSource = this.databaseDataSet;
            // 
            // entityBindingSource
            // 
            this.entityBindingSource.DataMember = "entity";
            this.entityBindingSource.DataSource = this.databaseDataSet;
            // 
            // entityTableAdapter
            // 
            this.entityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activityTableAdapter = this.activityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entity_activityTableAdapter = this.entity_activityTableAdapter;
            this.tableAdapterManager.entityTableAdapter = this.entityTableAdapter;
            this.tableAdapterManager.UpdateOrder = TaxOffice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // entity_activityTableAdapter
            // 
            this.entity_activityTableAdapter.ClearBeforeFill = true;
            // 
            // EntityTable
            // 
            this.EntityTable.AutoGenerateColumns = false;
            this.EntityTable.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.EntityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntityTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2,
            this.inn,
            this.kpp,
            this.address,
            this.phone});
            this.EntityTable.DataSource = this.entityBindingSource;
            this.EntityTable.Location = new System.Drawing.Point(62, 128);
            this.EntityTable.Name = "EntityTable";
            this.EntityTable.ReadOnly = true;
            this.EntityTable.Size = new System.Drawing.Size(1058, 220);
            this.EntityTable.TabIndex = 1;
            this.EntityTable.DoubleClick += new System.EventHandler(this.EntityTable_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // inn
            // 
            this.inn.DataPropertyName = "inn";
            this.inn.HeaderText = "inn";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // kpp
            // 
            this.kpp.DataPropertyName = "kpp";
            this.kpp.HeaderText = "kpp";
            this.kpp.Name = "kpp";
            this.kpp.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // entity_activityBindingSource
            // 
            this.entity_activityBindingSource.DataMember = "entity_activity";
            this.entity_activityBindingSource.DataSource = this.databaseDataSet;
            // 
            // EntitySave
            // 
            this.EntitySave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EntitySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntitySave.ForeColor = System.Drawing.SystemColors.Control;
            this.EntitySave.Location = new System.Drawing.Point(165, 648);
            this.EntitySave.Name = "EntitySave";
            this.EntitySave.Size = new System.Drawing.Size(138, 48);
            this.EntitySave.TabIndex = 15;
            this.EntitySave.Text = "Save";
            this.EntitySave.UseVisualStyleBackColor = false;
            this.EntitySave.Click += new System.EventHandler(this.EntitySave_Click);
            // 
            // EntityDelete
            // 
            this.EntityDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.EntityDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntityDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.EntityDelete.Location = new System.Drawing.Point(492, 648);
            this.EntityDelete.Name = "EntityDelete";
            this.EntityDelete.Size = new System.Drawing.Size(138, 48);
            this.EntityDelete.TabIndex = 16;
            this.EntityDelete.Text = "Delete";
            this.EntityDelete.UseVisualStyleBackColor = false;
            this.EntityDelete.Click += new System.EventHandler(this.EntityDelete_Click);
            // 
            // EntityReset
            // 
            this.EntityReset.BackColor = System.Drawing.Color.Gold;
            this.EntityReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntityReset.ForeColor = System.Drawing.SystemColors.Control;
            this.EntityReset.Location = new System.Drawing.Point(330, 648);
            this.EntityReset.Name = "EntityReset";
            this.EntityReset.Size = new System.Drawing.Size(138, 48);
            this.EntityReset.TabIndex = 17;
            this.EntityReset.Text = "Reset";
            this.EntityReset.UseVisualStyleBackColor = false;
            this.EntityReset.Click += new System.EventHandler(this.EntityReset_Click);
            // 
            // EntityAddActivitySelect
            // 
            this.EntityAddActivitySelect.DataSource = this.activityBindingSource;
            this.EntityAddActivitySelect.DisplayMember = "name";
            this.EntityAddActivitySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntityAddActivitySelect.FormattingEnabled = true;
            this.EntityAddActivitySelect.Location = new System.Drawing.Point(165, 596);
            this.EntityAddActivitySelect.Name = "EntityAddActivitySelect";
            this.EntityAddActivitySelect.Size = new System.Drawing.Size(611, 32);
            this.EntityAddActivitySelect.TabIndex = 20;
            this.EntityAddActivitySelect.ValueMember = "Id";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(165, 386);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(809, 29);
            this.nameTextBox.TabIndex = 21;
            // 
            // innTextBox
            // 
            this.innTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innTextBox.Location = new System.Drawing.Point(165, 427);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(809, 29);
            this.innTextBox.TabIndex = 22;
            // 
            // kppTextBox
            // 
            this.kppTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kppTextBox.Location = new System.Drawing.Point(165, 466);
            this.kppTextBox.Name = "kppTextBox";
            this.kppTextBox.Size = new System.Drawing.Size(809, 29);
            this.kppTextBox.TabIndex = 23;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(165, 553);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(809, 29);
            this.phoneTextBox.TabIndex = 25;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(165, 507);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(809, 29);
            this.addressTextBox.TabIndex = 26;
            // 
            // ListByActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1404, 761);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.kppTextBox);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.EntityAddActivitySelect);
            this.Controls.Add(label1);
            this.Controls.Add(this.EntityReset);
            this.Controls.Add(this.EntityDelete);
            this.Controls.Add(this.EntitySave);
            this.Controls.Add(nameLabel);
            this.Controls.Add(innLabel);
            this.Controls.Add(kppLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.EntityTable);
            this.Controls.Add(this.ActivitySelect);
            this.Name = "ListByActivity";
            this.Text = "Список по виду деятельности";
            this.Load += new System.EventHandler(this.ListByActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntityTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private DatabaseDataSetTableAdapters.activityTableAdapter activityTableAdapter;
        private System.Windows.Forms.ComboBox ActivitySelect;
        private System.Windows.Forms.BindingSource activityBindingSource1;
        private System.Windows.Forms.BindingSource entityBindingSource;
        private DatabaseDataSetTableAdapters.entityTableAdapter entityTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView EntityTable;
        private DatabaseDataSetTableAdapters.entity_activityTableAdapter entity_activityTableAdapter;
        private System.Windows.Forms.BindingSource entity_activityBindingSource;
        private System.Windows.Forms.Button EntitySave;
        private System.Windows.Forms.Button EntityDelete;
        private System.Windows.Forms.Button EntityReset;
        private System.Windows.Forms.ComboBox EntityAddActivitySelect;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox kppTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}