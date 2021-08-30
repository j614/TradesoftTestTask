namespace TradesoftTestTask
{
    partial class FindForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sourceArtTextBox = new System.Windows.Forms.TextBox();
            this.targetManufTextBox = new System.Windows.Forms.TextBox();
            this.depthsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sourceManuftextBox = new System.Windows.Forms.TextBox();
            this.targetArtTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.targetArtTextBox);
            this.groupBox1.Controls.Add(this.sourceManuftextBox);
            this.groupBox1.Controls.Add(this.sourceArtTextBox);
            this.groupBox1.Controls.Add(this.targetManufTextBox);
            this.groupBox1.Controls.Add(this.depthsNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Связь";
            // 
            // sourceArtTextBox
            // 
            this.sourceArtTextBox.Location = new System.Drawing.Point(160, 40);
            this.sourceArtTextBox.Name = "sourceArtTextBox";
            this.sourceArtTextBox.Size = new System.Drawing.Size(153, 20);
            this.sourceArtTextBox.TabIndex = 5;
            // 
            // targetManufTextBox
            // 
            this.targetManufTextBox.Location = new System.Drawing.Point(160, 148);
            this.targetManufTextBox.Name = "targetManufTextBox";
            this.targetManufTextBox.Size = new System.Drawing.Size(153, 20);
            this.targetManufTextBox.TabIndex = 4;
            // 
            // depthsNumericUpDown
            // 
            this.depthsNumericUpDown.Location = new System.Drawing.Point(266, 174);
            this.depthsNumericUpDown.Name = "depthsNumericUpDown";
            this.depthsNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.depthsNumericUpDown.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Глубина рекурсии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Искомый производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный артикул";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(26, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(196, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sourceManuftextBox
            // 
            this.sourceManuftextBox.Location = new System.Drawing.Point(160, 76);
            this.sourceManuftextBox.Name = "sourceManuftextBox";
            this.sourceManuftextBox.Size = new System.Drawing.Size(153, 20);
            this.sourceManuftextBox.TabIndex = 6;
            // 
            // targetArtTextBox
            // 
            this.targetArtTextBox.Location = new System.Drawing.Point(160, 115);
            this.targetArtTextBox.Name = "targetArtTextBox";
            this.targetArtTextBox.Size = new System.Drawing.Size(153, 20);
            this.targetArtTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Исходный производитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Искомый артикул";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindForm";
            this.Text = "Поиск связей";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.TextBox sourceArtTextBox;
        protected internal System.Windows.Forms.TextBox targetManufTextBox;
        protected internal System.Windows.Forms.NumericUpDown depthsNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox targetArtTextBox;
        protected internal System.Windows.Forms.TextBox sourceManuftextBox;
    }
}