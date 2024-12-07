using System;

namespace ExpenseManagement
{
    public partial class Form1 : Form
    {
        private readonly UserRepository _userRepository;
        public Form1()
        {
            InitializeComponent();
            _userRepository = new UserRepository(new ExpenseManagementContext());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepository.GetUserByUsernameAndPassword(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MainForm mainForm = new MainForm(user.Username);
                MessageBox.Show("Login successful");
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        }
    }

