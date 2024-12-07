using System;
using System.Windows.Forms;

namespace ExpenseManagement
{
    public partial class AddExpenseTypeForm : Form
    {
        public string ExpenseType { get; private set; } // Xərc növünü qaytarır

        public AddExpenseTypeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent; // Form mərkəzdə açılsın
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Xərc növü daxil edilməyibsə, xəbərdarlıq göstər
            if (string.IsNullOrWhiteSpace(txtExpenseType.Text))
            {
                MessageBox.Show("Xərc növü daxil edilməlidir!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExpenseType = txtExpenseType.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
