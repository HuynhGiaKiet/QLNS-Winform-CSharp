namespace QuanLyNhanSu
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            btndangnhap = new Button();
            pictureBox1 = new PictureBox();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(210, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(176, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 2;
            label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(194, 166);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu:";
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(310, 122);
            txttendangnhap.Margin = new Padding(4, 3, 4, 3);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(192, 27);
            txttendangnhap.TabIndex = 0;
            txttendangnhap.Text = "Admin";
            txttendangnhap.TextChanged += textBox1_TextChanged;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(310, 162);
            txtmatkhau.Margin = new Padding(4, 3, 4, 3);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(192, 27);
            txtmatkhau.TabIndex = 1;
            txtmatkhau.Text = "132456";
            txtmatkhau.TextChanged += textBox2_TextChanged;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.Turquoise;
            btndangnhap.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndangnhap.ForeColor = Color.FromArgb(64, 0, 64);
            btndangnhap.Location = new Point(214, 207);
            btndangnhap.Margin = new Padding(4, 3, 4, 3);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(120, 50);
            btndangnhap.TabIndex = 2;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(15, 109);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 123);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Turquoise;
            btnthoat.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.ForeColor = Color.FromArgb(64, 0, 64);
            btnthoat.Location = new Point(341, 207);
            btnthoat.Margin = new Padding(4, 3, 4, 3);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(121, 50);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += button2_Click;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(548, 322);
            Controls.Add(btnthoat);
            Controls.Add(pictureBox1);
            Controls.Add(btndangnhap);
            Controls.Add(txtmatkhau);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txttendangnhap);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 128, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += FrmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private Button btndangnhap;
        private Button btnthoat;
        private PictureBox pictureBox1;
        
    }
}