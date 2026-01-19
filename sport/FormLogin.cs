using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sport
{
    public partial class FormLogin : Form
    {
        public User CurentUser {  get; private set; }
        public bool IsGauste { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
                if (String.IsNullOrWhiteSpace(textBoxLogin.Text) || String.IsNullOrWhiteSpace(textBoxPassword.Text)) {
                    MessageBox.Show("Введите логит и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
