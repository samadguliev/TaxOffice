
namespace TaxOffice
{
    partial class ListOfRelations
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfRelations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSet = new TaxOffice.DatabaseDataSet();
            this.entity_activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entity_activityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.entity_activityTableAdapter();
            this.tableAdapterManager = new TaxOffice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.entity_activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.entity_activityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.RelationsTable = new System.Windows.Forms.DataGridView();
            this.RelationDelete = new System.Windows.Forms.Button();
            this.RelationSave = new System.Windows.Forms.Button();
            this.RelationAddEntitySelect = new System.Windows.Forms.ComboBox();
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.entityTableAdapter();
            this.RelationAddActSelect = new System.Windows.Forms.ComboBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new TaxOffice.DatabaseDataSetTableAdapters.activityTableAdapter();
            this.RelationReset = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_activityBindingNavigator)).BeginInit();
            this.entity_activityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RelationsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.Window;
            label1.Location = new System.Drawing.Point(13, 395);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 24);
            label1.TabIndex = 32;
            label1.Text = "Вид деят.:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            nameLabel.Location = new System.Drawing.Point(13, 334);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(102, 24);
            nameLabel.TabIndex = 27;
            nameLabel.Text = "Название:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entity_activityBindingSource
            // 
            this.entity_activityBindingSource.DataMember = "entity_activity";
            this.entity_activityBindingSource.DataSource = this.databaseDataSet;
            // 
            // entity_activityTableAdapter
            // 
            this.entity_activityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entity_activityTableAdapter = this.entity_activityTableAdapter;
            this.tableAdapterManager.entityTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaxOffice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // entity_activityBindingNavigator
            // 
            this.entity_activityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.entity_activityBindingNavigator.BindingSource = this.entity_activityBindingSource;
            this.entity_activityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entity_activityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.entity_activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.entity_activityBindingNavigatorSaveItem});
            this.entity_activityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entity_activityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entity_activityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entity_activityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entity_activityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entity_activityBindingNavigator.Name = "entity_activityBindingNavigator";
            this.entity_activityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entity_activityBindingNavigator.Size = new System.Drawing.Size(1404, 25);
            this.entity_activityBindingNavigator.TabIndex = 0;
            this.entity_activityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // entity_activityBindingNavigatorSaveItem
            // 
            this.entity_activityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entity_activityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entity_activityBindingNavigatorSaveItem.Image")));
            this.entity_activityBindingNavigatorSaveItem.Name = "entity_activityBindingNavigatorSaveItem";
            this.entity_activityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.entity_activityBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.entity_activityBindingNavigatorSaveItem.Click += new System.EventHandler(this.entity_activityBindingNavigatorSaveItem_Click_1);
            // 
            // RelationsTable
            // 
            this.RelationsTable.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RelationsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RelationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RelationsTable.Location = new System.Drawing.Point(12, 56);
            this.RelationsTable.Name = "RelationsTable";
            this.RelationsTable.Size = new System.Drawing.Size(1350, 240);
            this.RelationsTable.TabIndex = 2;
            this.RelationsTable.DoubleClick += new System.EventHandler(this.RelationsTable_DoubleClick);
            // 
            // RelationDelete
            // 
            this.RelationDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.RelationDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelationDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.RelationDelete.Location = new System.Drawing.Point(445, 447);
            this.RelationDelete.Name = "RelationDelete";
            this.RelationDelete.Size = new System.Drawing.Size(138, 48);
            this.RelationDelete.TabIndex = 19;
            this.RelationDelete.Text = "Delete";
            this.RelationDelete.UseVisualStyleBackColor = false;
            this.RelationDelete.Click += new System.EventHandler(this.RelationDelete_Click);
            // 
            // RelationSave
            // 
            this.RelationSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RelationSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelationSave.ForeColor = System.Drawing.SystemColors.Control;
            this.RelationSave.Location = new System.Drawing.Point(118, 447);
            this.RelationSave.Name = "RelationSave";
            this.RelationSave.Size = new System.Drawing.Size(138, 48);
            this.RelationSave.TabIndex = 18;
            this.RelationSave.Text = "Save";
            this.RelationSave.UseVisualStyleBackColor = false;
            this.RelationSave.Click += new System.EventHandler(this.RelationSave_Click);
            // 
            // RelationAddEntitySelect
            // 
            this.RelationAddEntitySelect.DataSource = this.entityBindingSource;
            this.RelationAddEntitySelect.DisplayMember = "name";
            this.RelationAddEntitySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelationAddEntitySelect.FormattingEnabled = true;
            this.RelationAddEntitySelect.Location = new System.Drawing.Point(118, 334);
            this.RelationAddEntitySelect.Name = "RelationAddEntitySelect";
            this.RelationAddEntitySelect.Size = new System.Drawing.Size(611, 32);
            this.RelationAddEntitySelect.TabIndex = 34;
            this.RelationAddEntitySelect.ValueMember = "Id";
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
            // RelationAddActSelect
            // 
            this.RelationAddActSelect.DataSource = this.activityBindingSource;
            this.RelationAddActSelect.DisplayMember = "name";
            this.RelationAddActSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelationAddActSelect.FormattingEnabled = true;
            this.RelationAddActSelect.Location = new System.Drawing.Point(118, 392);
            this.RelationAddActSelect.Name = "RelationAddActSelect";
            this.RelationAddActSelect.Size = new System.Drawing.Size(611, 32);
            this.RelationAddActSelect.TabIndex = 35;
            this.RelationAddActSelect.ValueMember = "Id";
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
            // RelationReset
            // 
            this.RelationReset.BackColor = System.Drawing.Color.Gold;
            this.RelationReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelationReset.ForeColor = System.Drawing.SystemColors.Control;
            this.RelationReset.Location = new System.Drawing.Point(283, 447);
            this.RelationReset.Name = "RelationReset";
            this.RelationReset.Size = new System.Drawing.Size(138, 48);
            this.RelationReset.TabIndex = 20;
            this.RelationReset.Text = "Reset";
            this.RelationReset.UseVisualStyleBackColor = false;
            this.RelationReset.Click += new System.EventHandler(this.RelationReset_Click);
            // 
            // ListOfRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1404, 761);
            this.Controls.Add(this.RelationAddActSelect);
            this.Controls.Add(this.RelationAddEntitySelect);
            this.Controls.Add(label1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.RelationReset);
            this.Controls.Add(this.RelationDelete);
            this.Controls.Add(this.RelationSave);
            this.Controls.Add(this.RelationsTable);
            this.Controls.Add(this.entity_activityBindingNavigator);
            this.Name = "ListOfRelations";
            this.Text = "Список привязок";
            this.Load += new System.EventHandler(this.ListOfRelations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_activityBindingNavigator)).EndInit();
            this.entity_activityBindingNavigator.ResumeLayout(false);
            this.entity_activityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RelationsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource entity_activityBindingSource;
        private DatabaseDataSetTableAdapters.entity_activityTableAdapter entity_activityTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entity_activityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton entity_activityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView RelationsTable;
        private System.Windows.Forms.Button RelationDelete;
        private System.Windows.Forms.Button RelationSave;
        private System.Windows.Forms.ComboBox RelationAddEntitySelect;
        private System.Windows.Forms.BindingSource entityBindingSource;
        private DatabaseDataSetTableAdapters.entityTableAdapter entityTableAdapter;
        private System.Windows.Forms.ComboBox RelationAddActSelect;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private DatabaseDataSetTableAdapters.activityTableAdapter activityTableAdapter;
        private System.Windows.Forms.Button RelationReset;
    }
}