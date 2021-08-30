namespace TradesoftTestTask
{
    partial class DirectoryAnalogsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confidence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindСonnectionButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.articleOne,
            this.manufacturerOne,
            this.articleTwo,
            this.manufacturerTwo,
            this.confidence});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(602, 298);
            this.dataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Номер в базе";
            this.id.Name = "id";
            // 
            // articleOne
            // 
            this.articleOne.DataPropertyName = "articleOne";
            this.articleOne.HeaderText = "Арктикул1";
            this.articleOne.Name = "articleOne";
            // 
            // manufacturerOne
            // 
            this.manufacturerOne.DataPropertyName = "manufacturerOne";
            this.manufacturerOne.HeaderText = "Производитель1";
            this.manufacturerOne.Name = "manufacturerOne";
            // 
            // articleTwo
            // 
            this.articleTwo.DataPropertyName = "articleTwo";
            this.articleTwo.HeaderText = "Артикул2";
            this.articleTwo.Name = "articleTwo";
            // 
            // manufacturerTwo
            // 
            this.manufacturerTwo.DataPropertyName = "manufacturerTwo";
            this.manufacturerTwo.HeaderText = "Производитель2";
            this.manufacturerTwo.Name = "manufacturerTwo";
            // 
            // confidence
            // 
            this.confidence.DataPropertyName = "confidence";
            this.confidence.HeaderText = "Доверие";
            this.confidence.Name = "confidence";
            // 
            // FindСonnectionButton
            // 
            this.FindСonnectionButton.Location = new System.Drawing.Point(499, 347);
            this.FindСonnectionButton.Name = "FindСonnectionButton";
            this.FindСonnectionButton.Size = new System.Drawing.Size(103, 23);
            this.FindСonnectionButton.TabIndex = 1;
            this.FindСonnectionButton.Text = "Найти связь";
            this.FindСonnectionButton.UseVisualStyleBackColor = true;
            this.FindСonnectionButton.Click += new System.EventHandler(this.FindСonnectionButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 347);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(210, 347);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(113, 347);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DirectoryAnalogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 406);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FindСonnectionButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "DirectoryAnalogsForm";
            this.Text = "Справочник аналогов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button FindСonnectionButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn confidence;
    }
}

