namespace WindowsFormsApp12
{
    partial class LoginForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            label1.Location = new System.Drawing.Point(58, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 34);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            label2.Location = new System.Drawing.Point(58, 18);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 34);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(77, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 3);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(77, 248);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 3);
            this.panel2.TabIndex = 7;
            // 
            // passwordIcon
            // 
            this.passwordIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordIcon.BackColor = System.Drawing.Color.White;
            this.passwordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passwordIcon.Location = new System.Drawing.Point(9, 17);
            this.passwordIcon.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(41, 32);
            this.passwordIcon.TabIndex = 9;
            this.passwordIcon.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(163, 299);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(123, 45);
            this.rjButton1.TabIndex = 10;
            this.rjButton1.Text = "Login";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLoginTextBox.Location = new System.Drawing.Point(148, 19);
            this.userLoginTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(202, 23);
            this.userLoginTextBox.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userIcon);
            this.flowLayoutPanel1.Controls.Add(label1);
            this.flowLayoutPanel1.Controls.Add(this.userLoginTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 60);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // userIcon
            // 
            this.userIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userIcon.BackColor = System.Drawing.Color.White;
            this.userIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.Location = new System.Drawing.Point(9, 17);
            this.userIcon.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(41, 32);
            this.userIcon.TabIndex = 8;
            this.userIcon.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.passwordIcon);
            this.flowLayoutPanel2.Controls.Add(label2);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 182);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(380, 60);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(148, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 481);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton loginButton;
        private CustomControls.RJControls.RJButton registerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private CustomControls.RJControls.RJButton rjButton1;
        private TextBox userLoginTextBox;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBox1;
    }
}