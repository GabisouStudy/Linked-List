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
            this.value1 = new System.Windows.Forms.ListBox();
            this.value2 = new System.Windows.Forms.ListBox();
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
            this.printBox.Location = new System.Drawing.Point(12, 170);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(405, 286);
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
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(342, 42);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 30);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Troca!";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // addNextButtom
            // 
            this.addNextButtom.Location = new System.Drawing.Point(12, 78);
            this.addNextButtom.Name = "addNextButtom";
            this.addNextButtom.Size = new System.Drawing.Size(125, 23);
            this.addNextButtom.TabIndex = 9;
            this.addNextButtom.Text = "Adicionar após o valor:";
            this.addNextButtom.UseVisualStyleBackColor = true;
            this.addNextButtom.Click += new System.EventHandler(this.addNextButton_Click);
            // 
            // findValue
            // 
            this.findValue.Location = new System.Drawing.Point(274, 78);
            this.findValue.Name = "findValue";
            this.findValue.Size = new System.Drawing.Size(143, 20);
            this.findValue.TabIndex = 10;
            // 
            // remAtButton
            // 
            this.remAtButton.Location = new System.Drawing.Point(143, 78);
            this.remAtButton.Name = "remAtButton";
            this.remAtButton.Size = new System.Drawing.Size(125, 23);
            this.remAtButton.TabIndex = 11;
            this.remAtButton.Text = "Remover após o valor:";
            this.remAtButton.UseVisualStyleBackColor = true;
            this.remAtButton.Click += new System.EventHandler(this.remAtButton_Click);
            // 
            // value1
            // 
            this.value1.FormattingEnabled = true;
            this.value1.Location = new System.Drawing.Point(12, 42);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(159, 30);
            this.value1.TabIndex = 12;
            this.value1.Click += new System.EventHandler(this.UpdateList);
            // 
            // value2
            // 
            this.value2.FormattingEnabled = true;
            this.value2.Location = new System.Drawing.Point(177, 42);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(159, 30);
            this.value2.TabIndex = 13;
            this.value2.Click += new System.EventHandler(this.UpdateList);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 468);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addNextButtom;
        private System.Windows.Forms.TextBox findValue;
        private System.Windows.Forms.Button remAtButton;
        private System.Windows.Forms.ListBox value1;
        private System.Windows.Forms.ListBox value2;

    }
}

