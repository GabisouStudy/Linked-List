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
            this.textIndex = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CreditText = new System.Windows.Forms.Label();
            this.CreditSite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.indexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterValue
            // 
            this.enterValue.Location = new System.Drawing.Point(9, 16);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(405, 20);
            this.enterValue.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(258, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(118, 13);
            this.indexBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(134, 20);
            this.indexBox.TabIndex = 3;
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(13, 220);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(422, 277);
            this.printBox.TabIndex = 4;
            this.printBox.Text = "";
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(339, 13);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(75, 23);
            this.remButton.TabIndex = 5;
            this.remButton.Text = "Remover";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(339, 10);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 32);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Troca!";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addNextButtom
            // 
            this.addNextButtom.Location = new System.Drawing.Point(6, 19);
            this.addNextButtom.Name = "addNextButtom";
            this.addNextButtom.Size = new System.Drawing.Size(125, 23);
            this.addNextButtom.TabIndex = 9;
            this.addNextButtom.Text = "Adicionar após o valor:";
            this.addNextButtom.UseVisualStyleBackColor = true;
            this.addNextButtom.Click += new System.EventHandler(this.addNextButton_Click);
            // 
            // findValue
            // 
            this.findValue.Location = new System.Drawing.Point(253, 22);
            this.findValue.Name = "findValue";
            this.findValue.Size = new System.Drawing.Size(159, 20);
            this.findValue.TabIndex = 10;
            // 
            // remAtButton
            // 
            this.remAtButton.Location = new System.Drawing.Point(137, 19);
            this.remAtButton.Name = "remAtButton";
            this.remAtButton.Size = new System.Drawing.Size(111, 23);
            this.remAtButton.TabIndex = 11;
            this.remAtButton.Text = "Remover no valor:";
            this.remAtButton.UseVisualStyleBackColor = true;
            this.remAtButton.Click += new System.EventHandler(this.remAtButton_Click);
            // 
            // change1
            // 
            this.change1.Location = new System.Drawing.Point(51, 19);
            this.change1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.change1.Name = "change1";
            this.change1.Size = new System.Drawing.Size(112, 20);
            this.change1.TabIndex = 12;
            // 
            // change2
            // 
            this.change2.Location = new System.Drawing.Point(221, 18);
            this.change2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.change2.Name = "change2";
            this.change2.Size = new System.Drawing.Size(112, 20);
            this.change2.TabIndex = 13;
            // 
            // textIndex
            // 
            this.textIndex.AutoSize = true;
            this.textIndex.Location = new System.Drawing.Point(6, 18);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(101, 13);
            this.textIndex.TabIndex = 15;
            this.textIndex.Text = "Índice do Elemento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textIndex);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.indexBox);
            this.groupBox1.Controls.Add(this.remButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 42);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificações por Índice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.change1);
            this.groupBox2.Controls.Add(this.changeButton);
            this.groupBox2.Controls.Add(this.change2);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 45);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema de TROCA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Índice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Índice:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addNextButtom);
            this.groupBox3.Controls.Add(this.findValue);
            this.groupBox3.Controls.Add(this.remAtButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 55);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificações por Valor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.enterValue);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 42);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor do Elemento Adicionado";
            // 
            // CreditText
            // 
            this.CreditText.AutoSize = true;
            this.CreditText.Location = new System.Drawing.Point(10, 500);
            this.CreditText.Name = "CreditText";
            this.CreditText.Size = new System.Drawing.Size(174, 13);
            this.CreditText.TabIndex = 20;
            this.CreditText.Text = "Desenvolvido por Gabriel de Souza";
            // 
            // CreditSite
            // 
            this.CreditSite.AutoSize = true;
            this.CreditSite.Location = new System.Drawing.Point(259, 500);
            this.CreditSite.Name = "CreditSite";
            this.CreditSite.Size = new System.Drawing.Size(176, 13);
            this.CreditSite.TabIndex = 21;
            this.CreditSite.TabStop = true;
            this.CreditSite.Text = "http://github.com/Gabriel-de-Souza";
            this.CreditSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreditSite_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 527);
            this.Controls.Add(this.CreditSite);
            this.Controls.Add(this.CreditText);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.indexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label textIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label CreditText;
        private System.Windows.Forms.LinkLabel CreditSite;
    }
}

