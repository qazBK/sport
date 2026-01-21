using Microsoft.EntityFrameworkCore;
using sport.Models;
using System.Windows.Forms;

namespace sport
{
    public partial class FormProducts : Form
    {
        public User CurentUser { get; private set; }
        public bool IsGauste { get; private set; }
        public FormProducts(User user,bool guest)
        {
            InitializeComponent();

            var ColPhoto = new DataGridViewImageColumn();
            ColPhoto.Name= "ColPhoto";
            ColPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColPhoto.Width = 200;
            ColPhoto.FillWeight = 30;

            var ColInfo = new DataGridViewTextBoxColumn();
            ColInfo.Name = "ColInfo";
            ColInfo.FillWeight = 60;
            ColInfo.DefaultCellStyle.WrapMode= DataGridViewTriState.True;

            var ColDiscaunt = new DataGridViewTextBoxColumn();
            ColDiscaunt.Name = "ColDiscaunt";
            ColDiscaunt.FillWeight = 10;
            ColDiscaunt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.AddRange(
                ColPhoto, ColInfo, ColDiscaunt
                );

            CurentUser = user;
            IsGauste = guest;


            lbUserName.Text = IsGauste ? "Гость" : CurentUser.Nickname;

            LoadProducts();
            //LoadImag();




            
        }

       

        private void LoadProducts()
        {
            try {
                using (var db = new SportDbContext())
                {
                    var products = db.Products
                        .Include(i => i.IdProductCatigori)
                        .Include(i => i.IdManufacturer)
                        .Include(i => i.IdSupplier)
                        .ToList();
                }


            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private Image LoadImag(string img)
        {
            return Image.FromFile(img);
        }


         
    }
}
