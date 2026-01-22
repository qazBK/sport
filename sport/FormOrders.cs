
using Microsoft.EntityFrameworkCore;
using sport.Models;
namespace sport
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormOrders(User users, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();

            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            var colDeliveryDate = new DataGridViewTextBoxColumn();

            colDeliveryDate.Name = "colDeliveryDate";
            colDeliveryDate.FillWeight = 10;
            colDeliveryDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvOrders.Columns.AddRange(
                [
                    colInfo, colDeliveryDate
                ]
            );

            CurrentUser = users;
            IsGuest = guest;


            lbUserName.Text = IsGuest ? "Гость" : CurrentUser.Nickname;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new SportDbContext())
                {

                    var orders = db.Orders.Include(i => i.OrderProducts).
                        ThenInclude(i => i.Product).
                        Include(i => i.Point).
                        Include(i => i.OrderStatus).
                        ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        string info = FormatOrdersInfo(order);

                        if (info != null)
                        {

                            int rowIndex = dgvOrders.Rows.Add();
                            var row = dgvOrders.Rows[rowIndex];


                            row.Cells["colInfo"].Value = info;//---------------------------------------

                            row.Cells["colDeliveryDate"].Value = order.DeliveryDate.ToString();

                            //ApplyRowStyles(row, product);
                        }
                        dgvOrders.ResumeLayout();
                        dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string FormatOrdersInfo(Order order)
        {
            string articleText = "";

            foreach (var product in order.OrderProducts)
            {
                if (product.IdOrder == order.Id)
                {
                    articleText += product.Product.Article + ", ";

                }
                ;
            }
            if (string.IsNullOrEmpty(articleText)) { return null; }


            articleText = articleText.Remove(articleText.Length - 2) + "";

            return
            $"Артикул заказа: {articleText}" + Environment.NewLine +
            $"Статус заказ: {order.OrderStatus.OrderStatuses}" + Environment.NewLine +
            $"Адрис пунка выдачи: {order.Point.PointAdres}/{order.Point.Number}" + Environment.NewLine +
            $"Дата заказа: {order.OrderDate}" + Environment.NewLine;
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
