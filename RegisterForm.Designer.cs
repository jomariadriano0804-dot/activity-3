using System.Windows.Forms;

namespace activity_3
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblFull;
        private Label lblUser;
        private Label lblPass;
        private Label lblConfirm;
        private TextBox txtFull;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblFull = new Label();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.lblConfirm = new Label();
            this.txtFull = new TextBox();
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.txtConfirm = new TextBox();
            this.btnSave = new Button();
            this.btnBack = new Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(140, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "REGISTER";

            this.lblFull.AutoSize = true;
            this.lblFull.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFull.Location = new System.Drawing.Point(40, 90);
            this.lblFull.Name = "lblFull";
            this.lblFull.Text = "Full Name:";

            this.txtFull.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFull.Location = new System.Drawing.Point(160, 86);
            this.txtFull.Name = "txtFull";
            this.txtFull.Size = new System.Drawing.Size(250, 29);

            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUser.Location = new System.Drawing.Point(40, 140);
            this.lblUser.Name = "lblUser";
            this.lblUser.Text = "Username:";

            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.Location = new System.Drawing.Point(160, 136);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(250, 29);

            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPass.Location = new System.Drawing.Point(40, 190);
            this.lblPass.Name = "lblPass";
            this.lblPass.Text = "Password:";

            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.Location = new System.Drawing.Point(160, 186);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(250, 29);
            this.txtPass.UseSystemPasswordChar = true;

            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblConfirm.Location = new System.Drawing.Point(40, 240);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Text = "Confirm:";

            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(160, 236);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(250, 29);
            this.txtConfirm.UseSystemPasswordChar = true;

            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(160, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(290, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}