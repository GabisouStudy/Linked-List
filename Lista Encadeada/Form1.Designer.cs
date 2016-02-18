namespace Lista_Encadeada
{
    partial class MainWindow
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
            this.enterValue = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.indexBox = new System.Windows.Forms.NumericUpDown();
            this.printBox = new System.Windows.Forms.RichTextBox();
            this.remButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.indexBox)).BeginInit();
            this.SuspendLayout();
            // 
            // enterValue
            // 
            this.enterValue.Location = new System.Drawing.Point(12, 12);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(159, 20);
            this.enterValue.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(261, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(177, 12);
            this.indexBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(78, 20);
            this.indexBox.TabIndex = 3;
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(12, 94);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(405, 362);
            this.printBox.TabIndex = 4;
            this.printBox.Text = "";
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(342, 10);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(75, 23);
            this.remButton.TabIndex = 5;
            this.remButton.Text = "Remover";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(342, 36);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Troca!";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(12, 65);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(125, 23);
            this.getButton.TabIndex = 9;
            this.getButton.Text = "Adicionar após o valor:";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remover após o valor:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.remButton);
            this.Controls.Add(this.printBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.indexBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterValue;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown indexBox;
        private System.Windows.Forms.RichTextBox printBox;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

    }
}

