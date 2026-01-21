namespace sport
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeder = new Panel();
            dgvProducts = new DataGridView();
            lbUserName = new Label();
            btnLogin = new Button();
            panelHeder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panelHeder
            // 
            panelHeder.Controls.Add(btnLogin);
            panelHeder.Controls.Add(lbUserName);
            panelHeder.Dock = DockStyle.Top;
            panelHeder.Location = new Point(10, 10);
            panelHeder.Margin = new Padding(4, 4, 4, 4);
            panelHeder.Name = "panelHeder";
            panelHeder.Padding = new Padding(0, 0, 0, 10);
            panelHeder.Size = new Size(1123, 50);
            panelHeder.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(10, 60);
            dgvProducts.Margin = new Padding(4, 4, 4, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1123, 560);
            dgvProducts.TabIndex = 1;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(933, 6);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(53, 21);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "label1";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 97, 238);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.FromArgb(233, 245, 255);
            btnLogin.Location = new Point(996, 6);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1143, 630);
            Controls.Add(dgvProducts);
            Controls.Add(panelHeder);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormProducts";
            Padding = new Padding(10);
            Text = "Список спорт товаров";
            panelHeder.ResumeLayout(false);
            panelHeder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeder;
        private DataGridView dgvProducts;
        private Label lbUserName;
        private Button btnLogin;
    }
}