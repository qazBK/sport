using sport.Models;
using System.Data;

namespace sport
{
    public partial class FormLogin : Form
    {
        public User CurentUser { get; private set; }
        public bool IsGauste { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) || String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Введите логит и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            using (var db = new SportDbContext())
            {
                var user = db.Users.Where(w => w.Login == textBoxLogin.Text && w.Pasvord == textBoxPassword.Text).FirstOrDefault();

                if (user != null)
                {
                    CurentUser = user;

                    IsGauste = false;

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Пользователь ненайден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            CurentUser = null;
            IsGauste = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

