using Microsoft.EntityFrameworkCore;
using sport.Models;
using sport.Properties;
using System.Reflection.Emit;
using System.Resources;
using System.Windows.Forms;

namespace sport
{
    public partial class FormProducts : Form
    {
        public User CurentUser { get; private set; }
        public bool IsGauste { get; private set; }
        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            var ColPhoto = new DataGridViewImageColumn();
            ColPhoto.Name = "ColPhoto";
            ColPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColPhoto.Width = 200;
            ColPhoto.FillWeight = 30;

            var ColInfo = new DataGridViewTextBoxColumn();
            ColInfo.Name = "ColInfo";
            ColInfo.FillWeight = 60;
            ColInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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



        }



        private void LoadProducts()
        {
           try
            {
                using (var db = new SportDbContext())
                {
                    var products = db.Products
                        .Include(i => i.ProductCatigory)
                        .Include(i => i.Manufacturer)
                        .Include(i => i.Supplier)
                        .Include(i => i.UnitsOfMeasurement)
                        .ToList();

                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["ColPhoto"].Value = LoadImag(product.Image);
                        row.Cells["ColInfo"].Value = FormatProductInfo(product);
                        row.Cells["ColDiscaunt"].Value = $"{product.Discount}";
                        row.Cells["ColDiscaunt"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        ProductStyle(row, product);



                    }
                }


            }
          catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void ProductStyle(DataGridViewRow row, Product product)
        {
            if (product.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                row.DefaultCellStyle.ForeColor = Color.Wheat;
            }
            if (product.Count <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#4361EE");
                if (product.Discount <= 15)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            if (product.Discount > 0)
            {
                row.Cells["ColDiscaunt"].Style.ForeColor = Color.Red;
                row.Cells["ColDiscaunt"].Style.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            }

        }

        private string FormatProductInfo(Product product)
        {
            string priceText;

            if (product.Discount > 0)
            {

                decimal finalPrice = (decimal)(product.Praise) *//<-----------
                     (100 - (product.Discount ?? 0)) / 100;
    

       

                //priceText = $"Цена: {product.Praise:C\u0336}-> {finalPrice:C}";


               
                string oldPrice = $"{product.Praise:C}";
                string strikePrice = "";
                foreach (char c in oldPrice) strikePrice += c + "\u0336";

                priceText = $"Цена: {strikePrice} -> {finalPrice:C}";
            }
            else
            {
                priceText = $"Цена: {product.Praise:C}";
            }
            return  
                $"{product.ProductCatigory.ProductCatigoriName}\n" +
                $"{product.ProductName}\n"+
                $"Описание товара: {product.Description}\n" +
                $"Производитель: {product.Manufacturer}\n" +
                $"Постовщик: {product.Supplier}\n" +
                $"{priceText}\n" +
                $"Количество на складе : {product.Count} {product.UnitsOfMeasurement.UnitName}";
        }

        private Image LoadImag(string img)
        {
            if (!String.IsNullOrEmpty(img))
            {
                object resourceObject = Resources.ResourceManager.GetObject(img);
                if (resourceObject is Image image)
                {
                    return image;
                }
            }

            return Resources.picture;
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}
