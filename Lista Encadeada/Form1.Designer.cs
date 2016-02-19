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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.enterValue = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.indexBox = new System.Windows.Forms.NumericUpDown();
            this.printBox = new System.Windows.Forms.RichTextBox();
            this.remButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addNextButtom = new System.Windows.Forms.Button();
            this.findValue = new System.Windows.Forms.TextBox();
            this.remAtButton = new System.Windows.Forms.Button();
            this.change1 = new System.Windows.Forms.NumericUpDown();
            this.change2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.indexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change2)).BeginInit();
            this.SuspendLayout();
            // 
            // enterValue
            // 
            this.enterValue.Location = new System.Drawing.Point(18, 18);
            this.enterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(236, 26);
            this.enterValue.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(392, 15);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(266, 18);
            this.indexBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indexBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(117, 26);
            this.indexBox.TabIndex = 3;
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(18, 165);
            this.printBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(606, 535);
            this.printBox.TabIndex = 4;
            this.printBox.Text = "";
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(513, 15);
            this.remButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(112, 35);
            this.remButton.TabIndex = 5;
            this.remButton.Text = "Remover";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(513, 65);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(112, 46);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Troca!";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addNextButtom
            // 
            this.addNextButtom.Location = new System.Drawing.Point(18, 120);
            this.addNextButtom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNextButtom.Name = "addNextButtom";
            this.addNextButtom.Size = new System.Drawing.Size(188, 35);
            this.addNextButtom.TabIndex = 9;
            this.addNextButtom.Text = "Adicionar após o valor:";
            this.addNextButtom.UseVisualStyleBackColor = true;
            this.addNextButtom.Click += new System.EventHandler(this.addNextButton_Click);
            // 
            // findValue
            // 
            this.findValue.Location = new System.Drawing.Point(388, 124);
            this.findValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findValue.Name = "findValue";
            this.findValue.Size = new System.Drawing.Size(236, 26);
            this.findValue.TabIndex = 10;
            // 
            // remAtButton
            // 
            this.remAtButton.Location = new System.Drawing.Point(214, 120);
            this.remAtButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remAtButton.Name = "remAtButton";
            this.remAtButton.Size = new System.Drawing.Size(167, 35);
            this.remAtButton.TabIndex = 11;
            this.remAtButton.Text = "Remover no valor:";
            this.remAtButton.UseVisualStyleBackColor = true;
            this.remAtButton.Click += new System.EventHandler(this.remAtButton_Click);
            // 
            // change1
            // 
            this.change1.Location = new System.Drawing.Point(13, 76);
            this.change1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.change1.Name = "change1";
            this.change1.Size = new System.Drawing.Size(236, 26);
            this.change1.TabIndex = 12;
            // 
            // change2
            // 
            this.change2.Location = new System.Drawing.Point(262, 76);
            this.change2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.change2.Name = "change2";
            this.change2.Size = new System.Drawing.Size(236, 26);
            this.change2.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 720);
            this.Controls.Add(this.change2);
            this.Controls.Add(this.change1);
            this.Controls.Add(this.remAtButton);
            this.Controls.Add(this.findValue);
            this.Controls.Add(this.addNextButtom);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.remButton);
            this.Controls.Add(this.printBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.indexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterValue;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown indexBox;
        private System.Windows.Forms.RichTextBox printBox;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addNextButtom;
        private System.Windows.Forms.TextBox findValue;
        private System.Windows.Forms.Button remAtButton;
        private System.Windows.Forms.NumericUpDown change1;
        private System.Windows.Forms.NumericUpDown change2;
    }
}

