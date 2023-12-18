namespace Bank
{
    partial class UserAccount
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            accountNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource = new BindingSource(components);
            tabPage1 = new TabPage();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            btnDeposit = new Button();
            tabPage3 = new TabPage();
            label11 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            btnWithdraw = new Button();
            label4 = new Label();
            label3 = new Label();
            tabPage4 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            btnPayment = new Button();
            userBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(696, 502);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(656, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "All Accounts";
            tabPage2.UseVisualStyleBackColor = true;
           
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { accountNumberDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = accountBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(650, 458);
            dataGridView1.TabIndex = 2;
         
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            accountNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            accountNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Account);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnDeposit);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 464);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Deposit";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(201, 43);
            label10.Name = "label10";
            label10.Size = new Size(206, 45);
            label10.TabIndex = 6;
            label10.Text = "Cash Deposit";
           
            // 
            // comboBox1
            // 
            comboBox1.DataSource = accountBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(294, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 251);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 4;
            label2.Text = "Amount";
           
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 147);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Select Account";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(294, 343);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(147, 42);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(btnWithdraw);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(688, 464);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "withdraw";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(194, 36);
            label11.Name = "label11";
            label11.Size = new Size(239, 45);
            label11.TabIndex = 7;
            label11.Text = "Cash Withdraw";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 31);
            textBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.DataSource = accountBindingSource;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(250, 126);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 33);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(250, 293);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(150, 42);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 218);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 1;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 126);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 0;
            label3.Text = "Select Account";
            
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dateTimePicker1);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(comboBox3);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(btnPayment);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(688, 464);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Payement";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(279, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 348);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 10;
            label9.Text = "Date";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(279, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 31);
            textBox5.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 270);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 8;
            label8.Text = "Amount";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(274, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 31);
            textBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 197);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 5;
            label7.Text = "OCR ";
            // 
            // comboBox3
            // 
            comboBox3.DataSource = accountBindingSource;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(279, 41);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(170, 33);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 126);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 2;
            label6.Text = "To Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 49);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 1;
            label5.Text = "From Account";
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(274, 418);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(142, 40);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Pay";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 502);
            Controls.Add(tabControl1);
            Name = "UserAccount";
            Text = "UserAccount";
            Load += UserAccount_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button btnDeposit;
        private ComboBox comboBox1;
        private BindingSource accountBindingSource;
        private Button btnWithdraw;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button btnPayment;
        private Label label5;
        private TextBox textBox3;
        private Label label7;
        private ComboBox comboBox3;
        private Label label6;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Label label10;
        private Label label11;
    }
}