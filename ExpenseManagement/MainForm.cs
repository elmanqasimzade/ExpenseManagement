using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManagement.Utils;

namespace ExpenseManagement
{
    public partial class MainForm : Form
    {
        private readonly GenericRepository<Expense> _expenseRepository;
        private readonly GenericRepository<ExpenseType> _expenseTypeRepository;
        private string _username;
        public MainForm(string username)
        {
            InitializeComponent();
            _expenseRepository = new GenericRepository<Expense>(new ExpenseManagementContext());
            _expenseTypeRepository = new GenericRepository<ExpenseType>(new ExpenseManagementContext());
            LoadExpenses();
            LoadExpenseTypes();

            _username = username; 
            UpdateWelcomeMessage();
        }
        private void UpdateWelcomeMessage()
        {
            lblWelcome.Text = $"Xoş gəldin, {_username}!";
        }
        private void LoadExpenseTypes()
        {
            try
            {
                var db = new ExpenseManagementContext();
                var expenseTypes = db.ExpenseTypes.ToList();
                cmbExpenseType.DataSource = expenseTypes;
                cmbExpenseType.DisplayMember = "Name";
                cmbExpenseType.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xərc növləri yüklənərkən xəta baş verdi: " + ex.Message);
            }
        }
        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDate = dtpExpenseDate.Value.Date;
                var newExpense = new Expense
                {
                    ExpenseTypeId = int.Parse(cmbExpenseType.SelectedValue.ToString()),
                    Amount = decimal.Parse(txtAmount.Text),
                    Date = selectedDate
                };

                _expenseRepository.Add(newExpense);
                _expenseRepository.Save();
                LoadExpenses();
                MessageBox.Show("Xərc uğurla yadda saxlandı!");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                MessageBox.Show("Xəta baş verdi. Xətanın izlənməsi üçün log faylını yoxlayın.");
            }
        }

        private void LoadExpenses()
        {
            try
            {
                var expenses = _expenseRepository.GetAll();
                dgvExpenses.DataSource = expenses;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                MessageBox.Show("Xərcləri yükləyərkən xeta baş verdi.");
            }
        }
        private System.Windows.Forms.Timer _timer;
        private void SetupTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 24 * 60 * 60 * 1000; // 24 saat interval
            _timer.Tick += timer1_Tick;
            _timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var expenses = _expenseRepository.GetAll();
                EmailService.SendExpenseEmail(expenses);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        private void btnAddExpenseType_Click(object sender, EventArgs e)
        {
            using (var form = new AddExpenseTypeForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string newExpenseType = form.ExpenseType;

                    // Yeni xərc növünü bazaya əlavə edin (burada DbContext istifadə edilir)
                    using (var db = new ExpenseManagementContext())
                    {
                        var expenseType = new ExpenseType { Name = newExpenseType };
                        db.ExpenseTypes.Add(expenseType);
                        db.SaveChanges();
                    }

                    // ComboBox-u yeniləyin
                    LoadExpenseTypes();
                }
            }
        }
    }
}
