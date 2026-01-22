namespace sport
{
    partial class FormMenu
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
            panelHeder = new Panel();
            lbUserName = new Label();
            button1 = new Button();
            btnProduct = new Button();
            buttonOrder = new Button();
            panelHeder.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeder
            // 
            panelHeder.Controls.Add(lbUserName);
            panelHeder.Controls.Add(button1);
            panelHeder.Dock = DockStyle.Top;
            panelHeder.Location = new Point(0, 0);
            panelHeder.Margin = new Padding(4);
            panelHeder.Name = "panelHeder";
            panelHeder.Padding = new Padding(0, 0, 0, 10);
            panelHeder.Size = new Size(681, 50);
            panelHeder.TabIndex = 2;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Dock = DockStyle.Right;
            lbUserName.Location = new Point(514, 0);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(53, 21);
            lbUserName.TabIndex = 6;
            lbUserName.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(67, 97, 238);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(233, 245, 255);
            button1.Location = new Point(567, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 5;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.None;
            btnProduct.BackColor = Color.FromArgb(67, 97, 238);
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.FromArgb(233, 245, 255);
            btnProduct.Location = new Point(165, 126);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(388, 69);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Товары";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += BtnProduct_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Anchor = AnchorStyles.None;
            buttonOrder.BackColor = Color.FromArgb(67, 97, 238);
            buttonOrder.FlatAppearance.BorderSize = 0;
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.ForeColor = Color.FromArgb(233, 245, 255);
            buttonOrder.Location = new Point(165, 236);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(388, 69);
            buttonOrder.TabIndex = 4;
            buttonOrder.Text = "Заказы";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += ButtonOrder_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 392);
            Controls.Add(buttonOrder);
            Controls.Add(btnProduct);
            Controls.Add(panelHeder);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMenu";
            Text = "FormMenu";
            panelHeder.ResumeLayout(false);
            panelHeder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogut;
        private Label lbUserName;
        private Panel panelHeder;
        private Button button1;
        private Button btnProduct;
        private Button buttonOrder;

    }
}