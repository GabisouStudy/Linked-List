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
            this.addButton.Location = new System.Drawing.Point(231, 9);
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
            this.indexBox.Size = new System.Drawing.Size(48, 20);
            this.indexBox.TabIndex = 3;
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(12, 41);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(294, 415);
            this.printBox.TabIndex = 4;
            this.printBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 468);
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

    }
}

