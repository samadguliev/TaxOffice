
namespace TaxOffice
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewListByActivity = new System.Windows.Forms.Button();
            this.ViewListByEntity = new System.Windows.Forms.Button();
            this.ViewRelationsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewListByActivity
            // 
            this.ViewListByActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewListByActivity.Location = new System.Drawing.Point(217, 108);
            this.ViewListByActivity.Name = "ViewListByActivity";
            this.ViewListByActivity.Size = new System.Drawing.Size(361, 108);
            this.ViewListByActivity.TabIndex = 1;
            this.ViewListByActivity.Text = "Список юр лиц по виду деятельности";
            this.ViewListByActivity.UseVisualStyleBackColor = true;
            this.ViewListByActivity.Click += new System.EventHandler(this.ViewListByActivity_Click);
            // 
            // ViewListByEntity
            // 
            this.ViewListByEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewListByEntity.Location = new System.Drawing.Point(217, 300);
            this.ViewListByEntity.Name = "ViewListByEntity";
            this.ViewListByEntity.Size = new System.Drawing.Size(361, 108);
            this.ViewListByEntity.TabIndex = 2;
            this.ViewListByEntity.Text = "Список видов деятельности юр лиц";
            this.ViewListByEntity.UseVisualStyleBackColor = true;
            this.ViewListByEntity.Click += new System.EventHandler(this.ViewListByEntity_Click);
            // 
            // ViewRelationsList
            // 
            this.ViewRelationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewRelationsList.Location = new System.Drawing.Point(217, 497);
            this.ViewRelationsList.Name = "ViewRelationsList";
            this.ViewRelationsList.Size = new System.Drawing.Size(361, 108);
            this.ViewRelationsList.TabIndex = 3;
            this.ViewRelationsList.Text = "Список привязок юр лиц к видам деят-ти";
            this.ViewRelationsList.UseVisualStyleBackColor = true;
            this.ViewRelationsList.Click += new System.EventHandler(this.ViewRelationsList_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.ViewRelationsList);
            this.Controls.Add(this.ViewListByEntity);
            this.Controls.Add(this.ViewListByActivity);
            this.Name = "MainMenu";
            this.Text = "Налоговая инспекция";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewListByActivity;
        private System.Windows.Forms.Button ViewListByEntity;
        private System.Windows.Forms.Button ViewRelationsList;
    }
}

