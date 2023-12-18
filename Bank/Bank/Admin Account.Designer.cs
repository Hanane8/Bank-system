namespace Bank
{
    partial class AdminAccount
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
            userBindingSource = new BindingSource(components);
            accountBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            btnsChange = new Button();
            btnDelete = new Button();
            btntransak = new Button();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Account);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(681, 273);
            dataGridView1.TabIndex = 0;
          
            // 
            // btnsChange
            // 
            btnsChange.Location = new Point(0, 12);
            btnsChange.Name = "btnsChange";
            btnsChange.Size = new Size(118, 33);
            btnsChange.TabIndex = 1;
            btnsChange.Text = "Change";
            btnsChange.UseVisualStyleBackColor = true;
            btnsChange.Click += btnsChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(154, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 33);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btntransak
            // 
            btntransak.Location = new Point(301, 12);
            btntransak.Name = "btntransak";
            btntransak.Size = new Size(113, 33);
            btntransak.TabIndex = 3;
            btntransak.Text = "Transaction";
            btntransak.UseVisualStyleBackColor = true;
            btntransak.Click += btntransak_Click;
            // 
            // AdminAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(681, 336);
            Controls.Add(btntransak);
            Controls.Add(btnDelete);
            Controls.Add(btnsChange);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.Highlight;
            Name = "AdminAccount";
            Text = "Admi_Account";
            Load += AdminAccount_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource userBindingSource;
        private BindingSource accountBindingSource;
        private DataGridView dataGridView1;
        private Button btnsChange;
        private Button btnDelete;
        private Button btntransak;
    }
}