namespace ExpenseManagement
{
    partial class MainForm
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
        private Label lblWelcome;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWelcome = new Label();
            dgvExpenses = new DataGridView();
            cmbExpenseType = new ComboBox();
            txtAmount = new TextBox();
            btnSaveExpense = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dtpExpenseDate = new DateTimePicker();
            btnAddExpenseType = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.Location = new Point(22, 31);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(110, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xoş gəldin!";
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(474, 112);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.Size = new Size(300, 188);
            dgvExpenses.TabIndex = 0;
            // 
            // cmbExpenseType
            // 
            cmbExpenseType.FormattingEnabled = true;
            cmbExpenseType.Location = new Point(12, 202);
            cmbExpenseType.Name = "cmbExpenseType";
            cmbExpenseType.Size = new Size(151, 28);
            cmbExpenseType.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(12, 323);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 3;
            // 
            // btnSaveExpense
            // 
            btnSaveExpense.Location = new Point(9, 313);
            btnSaveExpense.Name = "btnSaveExpense";
            btnSaveExpense.Size = new Size(94, 29);
            btnSaveExpense.TabIndex = 4;
            btnSaveExpense.Text = "Yadda Saxla";
            btnSaveExpense.UseVisualStyleBackColor = true;
            btnSaveExpense.Click += btnSaveExpense_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Location = new Point(12, 126);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(250, 27);
            dtpExpenseDate.TabIndex = 5;
            // 
            // btnAddExpenseType
            // 
            btnAddExpenseType.Location = new Point(194, 201);
            btnAddExpenseType.Name = "btnAddExpenseType";
            btnAddExpenseType.Size = new Size(37, 29);
            btnAddExpenseType.TabIndex = 7;
            btnAddExpenseType.Text = "...";
            btnAddExpenseType.UseVisualStyleBackColor = true;
            btnAddExpenseType.Click += btnAddExpenseType_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveExpense);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 360);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Xərcim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 9;
            label1.Text = "Tarix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 117);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 10;
            label2.Text = "Xərc Növü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 238);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 11;
            label3.Text = "Məbləğ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAmount);
            Controls.Add(btnAddExpenseType);
            Controls.Add(cmbExpenseType);
            Controls.Add(dtpExpenseDate);
            Controls.Add(lblWelcome);
            Controls.Add(dgvExpenses);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvExpenses;
        private ComboBox cmbExpenseType;
        private TextBox txtAmount;
        private Button btnSaveExpense;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dtpExpenseDate;
        private Button btnAddExpenseType;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}