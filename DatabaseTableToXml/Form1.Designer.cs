namespace DatabaseTableToXml
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hasłoTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nazwaBazyTextBox = new System.Windows.Forms.TextBox();
            this.IpBazyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.queryTextBox3 = new System.Windows.Forms.TextBox();
            this.queryTextBox2 = new System.Windows.Forms.TextBox();
            this.queryTextBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tabela1 = new System.Windows.Forms.TabPage();
            this.Tabela2 = new System.Windows.Forms.TabPage();
            this.Tabela3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tabela1.SuspendLayout();
            this.Tabela2.SuspendLayout();
            this.Tabela3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 374);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(730, 374);
            this.dataGridView2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hasłoTextBox);
            this.groupBox1.Controls.Add(this.loginTextBox);
            this.groupBox1.Controls.Add(this.nazwaBazyTextBox);
            this.groupBox1.Controls.Add(this.IpBazyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa Bazy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Bazy";
            // 
            // hasłoTextBox
            // 
            this.hasłoTextBox.Location = new System.Drawing.Point(446, 35);
            this.hasłoTextBox.Name = "hasłoTextBox";
            this.hasłoTextBox.PasswordChar = '*';
            this.hasłoTextBox.Size = new System.Drawing.Size(100, 20);
            this.hasłoTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(306, 35);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Text = "root";
            // 
            // nazwaBazyTextBox
            // 
            this.nazwaBazyTextBox.Location = new System.Drawing.Point(172, 35);
            this.nazwaBazyTextBox.Name = "nazwaBazyTextBox";
            this.nazwaBazyTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaBazyTextBox.TabIndex = 1;
            this.nazwaBazyTextBox.Text = "mysql";
            // 
            // IpBazyTextBox
            // 
            this.IpBazyTextBox.Location = new System.Drawing.Point(46, 35);
            this.IpBazyTextBox.Name = "IpBazyTextBox";
            this.IpBazyTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpBazyTextBox.TabIndex = 0;
            this.IpBazyTextBox.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.queryTextBox3);
            this.groupBox2.Controls.Add(this.queryTextBox2);
            this.groupBox2.Controls.Add(this.queryTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(31, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zapytania";
            // 
            // queryTextBox3
            // 
            this.queryTextBox3.Location = new System.Drawing.Point(26, 85);
            this.queryTextBox3.Name = "queryTextBox3";
            this.queryTextBox3.Size = new System.Drawing.Size(699, 20);
            this.queryTextBox3.TabIndex = 3;
            this.queryTextBox3.Text = "SELECT * FROM columns_priv";
            // 
            // queryTextBox2
            // 
            this.queryTextBox2.Location = new System.Drawing.Point(26, 59);
            this.queryTextBox2.Name = "queryTextBox2";
            this.queryTextBox2.Size = new System.Drawing.Size(699, 20);
            this.queryTextBox2.TabIndex = 2;
            this.queryTextBox2.Text = "SELECT * FROM user";
            // 
            // queryTextBox1
            // 
            this.queryTextBox1.Location = new System.Drawing.Point(26, 33);
            this.queryTextBox1.Name = "queryTextBox1";
            this.queryTextBox1.Size = new System.Drawing.Size(699, 20);
            this.queryTextBox1.TabIndex = 1;
            this.queryTextBox1.Text = "SELECT * FROM db";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tabela1);
            this.tabControl1.Controls.Add(this.Tabela2);
            this.tabControl1.Controls.Add(this.Tabela3);
            this.tabControl1.Location = new System.Drawing.Point(30, 287);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 406);
            this.tabControl1.TabIndex = 5;
            // 
            // Tabela1
            // 
            this.Tabela1.Controls.Add(this.dataGridView1);
            this.Tabela1.Location = new System.Drawing.Point(4, 22);
            this.Tabela1.Name = "Tabela1";
            this.Tabela1.Padding = new System.Windows.Forms.Padding(3);
            this.Tabela1.Size = new System.Drawing.Size(736, 380);
            this.Tabela1.TabIndex = 0;
            this.Tabela1.Text = "Tabela1";
            this.Tabela1.UseVisualStyleBackColor = true;
            // 
            // Tabela2
            // 
            this.Tabela2.Controls.Add(this.dataGridView2);
            this.Tabela2.Location = new System.Drawing.Point(4, 22);
            this.Tabela2.Name = "Tabela2";
            this.Tabela2.Padding = new System.Windows.Forms.Padding(3);
            this.Tabela2.Size = new System.Drawing.Size(736, 380);
            this.Tabela2.TabIndex = 1;
            this.Tabela2.Text = "Tabela2";
            this.Tabela2.UseVisualStyleBackColor = true;
            // 
            // Tabela3
            // 
            this.Tabela3.Controls.Add(this.dataGridView3);
            this.Tabela3.Location = new System.Drawing.Point(4, 22);
            this.Tabela3.Name = "Tabela3";
            this.Tabela3.Size = new System.Drawing.Size(736, 380);
            this.Tabela3.TabIndex = 2;
            this.Tabela3.Text = "Tabela3";
            this.Tabela3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(736, 380);
            this.dataGridView3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gdzie zapisać plik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Tabela1.ResumeLayout(false);
            this.Tabela2.ResumeLayout(false);
            this.Tabela3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hasłoTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nazwaBazyTextBox;
        private System.Windows.Forms.TextBox IpBazyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox queryTextBox3;
        private System.Windows.Forms.TextBox queryTextBox2;
        private System.Windows.Forms.TextBox queryTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tabela1;
        private System.Windows.Forms.TabPage Tabela2;
        private System.Windows.Forms.TabPage Tabela3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

