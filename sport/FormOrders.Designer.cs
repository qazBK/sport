namespace sport
{
    partial class FormOrders
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
            lbUserName = new Label();
            btnLogut = new Button();
            panelHeder = new Panel();
            dgvOrders = new DataGridView();
            panelHeder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Dock = DockStyle.Right;
            lbUserName.Location = new Point(956, 0);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(53, 21);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "label1";
            // 
            // btnLogut
            // 
            btnLogut.BackColor = Color.FromArgb(67, 97, 238);
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogut.ForeColor = Color.FromArgb(233, 245, 255);
            btnLogut.Location = new Point(1009, 0);
            btnLogut.Margin = new Padding(4, 4, 40, 4);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(114, 40);
            btnLogut.TabIndex = 3;
            btnLogut.Text = "Выйти";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogut_Click;
            // 
            // panelHeder
            // 
            panelHeder.Controls.Add(lbUserName);
            panelHeder.Controls.Add(btnLogut);
            panelHeder.Dock = DockStyle.Top;
            panelHeder.Location = new Point(10, 10);
            panelHeder.Margin = new Padding(4);
            panelHeder.Name = "panelHeder";
            panelHeder.Padding = new Padding(0, 0, 0, 10);
            panelHeder.Size = new Size(1123, 50);
            panelHeder.TabIndex = 1;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(10, 60);
            dgvOrders.Margin = new Padding(4);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1123, 560);
            dgvOrders.TabIndex = 2;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1143, 630);
            Controls.Add(dgvOrders);
            Controls.Add(panelHeder);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormOrders";
            Padding = new Padding(10);
            Text = "Список заказв";
            panelHeder.ResumeLayout(false);
            panelHeder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbUserName;
        private Button btnLogut;
        private Panel panelHeder;
        private DataGridView dgvOrders;
    }
}