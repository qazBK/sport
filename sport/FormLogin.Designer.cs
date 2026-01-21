namespace sport
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            btnGuest = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(btnGuest);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 201);
            panel1.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(32, 94);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 29);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(32, 35);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 29);
            textBoxLogin.TabIndex = 4;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(67, 97, 238);
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.ForeColor = Color.FromArgb(233, 245, 255);
            btnGuest.Location = new Point(82, 160);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 25);
            btnGuest.TabIndex = 3;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 97, 238);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(233, 245, 255);
            btnLogin.Location = new Point(82, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 25);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 67);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 11);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(384, 361);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Button btnGuest;
        private Button btnLogin;
        private Label label2;
        private Label label1;
    }
}