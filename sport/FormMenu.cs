
using sport.Models;

namespace sport
{
    public partial class FormMenu : Form
    {
        public User CurentUser { get; private set; }
        public bool IsGauste { get; private set; }

        public int IsProduct { get; private set; }

        public FormMenu(User user, bool guest)
        {
            InitializeComponent();
            IsProduct = 0;
            CurentUser = user;
            IsGauste = guest;
            lbUserName.Text = IsGauste ? "Гость" : CurentUser.Nickname;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            IsProduct = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            IsProduct = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
