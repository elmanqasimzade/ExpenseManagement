namespace ExpenseManagement
{
    partial class AddExpenseTypeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtExpenseType;
        private System.Windows.Forms.Label lblExpenseType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtExpenseType = new System.Windows.Forms.TextBox();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpenseType
            // 
            this.txtExpenseType.Location = new System.Drawing.Point(15, 35);
            this.txtExpenseType.Name = "txtExpenseType";
            this.txtExpenseType.Size = new System.Drawing.Size(250, 23);
            this.txtExpenseType.TabIndex = 0;
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Location = new System.Drawing.Point(12, 15);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(65, 15);
            this.lblExpenseType.TabIndex = 1;
            this.lblExpenseType.Text = "Xərc Növü:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Yadda Saxla";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Ləğv et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddExpenseTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblExpenseType);
            this.Controls.Add(this.txtExpenseType);
            this.Name = "AddExpenseTypeForm";
            this.Text = "Yeni Xərc Növü";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
