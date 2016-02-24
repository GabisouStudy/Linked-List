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
            this.enterValue.Location = new System.Drawing.Point(14, 25);
            this.enterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(606, 26);
            this.enterValue.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(387, 20);
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
            this.indexBox.Location = new System.Drawing.Point(177, 20);
            this.indexBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indexBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(201, 26);
            this.indexBox.TabIndex = 3;
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(20, 338);
            this.printBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(631, 424);
            this.printBox.TabIndex = 4;
            this.printBox.Text = "";
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(508, 20);
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
            this.changeButton.Location = new System.Drawing.Point(508, 15);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(112, 49);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Troca!";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addNextButtom
            // 
            this.addNextButtom.Location = new System.Drawing.Point(9, 29);
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
            this.findValue.Location = new System.Drawing.Point(380, 34);
            this.findValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findValue.Name = "findValue";
            this.findValue.Size = new System.Drawing.Size(236, 26);
            this.findValue.TabIndex = 10;
            // 
            // remAtButton
            // 
            this.remAtButton.Location = new System.Drawing.Point(206, 29);
            this.remAtButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remAtButton.Name = "remAtButton";
            this.remAtButton.Size = new System.Drawing.Size(166, 35);
            this.remAtButton.TabIndex = 11;
            this.remAtButton.Text = "Remover no valor:";
            this.remAtButton.UseVisualStyleBackColor = true;
            this.remAtButton.Click += new System.EventHandler(this.remAtButton_Click);
            // 
            // change1
            // 
            this.change1.Location = new System.Drawing.Point(76, 29);
            this.change1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.change1.Name = "change1";
            this.change1.Size = new System.Drawing.Size(168, 26);
            this.change1.TabIndex = 12;
            // 
            // change2
            // 
            this.change2.Location = new System.Drawing.Point(332, 28);
            this.change2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.change2.Name = "change2";
            this.change2.Size = new System.Drawing.Size(168, 26);
            this.change2.TabIndex = 13;
            // 
            // textIndex
            // 
            this.textIndex.AutoSize = true;
            this.textIndex.Location = new System.Drawing.Point(9, 28);
            this.textIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(150, 20);
            this.textIndex.TabIndex = 15;
            this.textIndex.Text = "Índice do Elemento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textIndex);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.indexBox);
            this.groupBox1.Controls.Add(this.remButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(634, 65);
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
            this.groupBox2.Location = new System.Drawing.Point(18, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(634, 69);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema de TROCA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Índice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Índice:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addNextButtom);
            this.groupBox3.Controls.Add(this.findValue);
            this.groupBox3.Controls.Add(this.remAtButton);
            this.groupBox3.Location = new System.Drawing.Point(18, 245);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(634, 85);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificações por Valor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.enterValue);
            this.groupBox4.Location = new System.Drawing.Point(18, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(633, 65);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor do Elemento Adicionado";
            // 
            // CreditText
            // 
            this.CreditText.AutoSize = true;
            this.CreditText.Location = new System.Drawing.Point(15, 769);
            this.CreditText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreditText.Name = "CreditText";
            this.CreditText.Size = new System.Drawing.Size(257, 20);
            this.CreditText.TabIndex = 20;
            this.CreditText.Text = "Desenvolvido por Gabriel de Souza";
            // 
            // CreditSite
            // 
            this.CreditSite.AutoSize = true;
            this.CreditSite.Location = new System.Drawing.Point(388, 769);
            this.CreditSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreditSite.Name = "CreditSite";
            this.CreditSite.Size = new System.Drawing.Size(256, 20);
            this.CreditSite.TabIndex = 21;
            this.CreditSite.TabStop = true;
            this.CreditSite.Text = "http://github.com/Gabriel-de-Souza";
            this.CreditSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreditSite_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 822);
            this.Controls.Add(this.CreditSite);
            this.Controls.Add(this.CreditText);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(692, 878);
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

