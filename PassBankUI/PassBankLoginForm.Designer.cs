
namespace PassBankUI
{
    partial class PassBankLoginForm
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
            this.masterPasswordLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.masterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createNewPasswordLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // masterPasswordLabel
            // 
            this.masterPasswordLabel.AutoSize = true;
            this.masterPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPasswordLabel.Location = new System.Drawing.Point(205, 15);
            this.masterPasswordLabel.Name = "masterPasswordLabel";
            this.masterPasswordLabel.Size = new System.Drawing.Size(213, 37);
            this.masterPasswordLabel.TabIndex = 0;
            this.masterPasswordLabel.Text = "Master Password";
            // 
            // submitButton
            // 
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(188, 140);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(243, 66);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Login";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // masterPasswordTextBox
            // 
            this.masterPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masterPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPasswordTextBox.Location = new System.Drawing.Point(146, 70);
            this.masterPasswordTextBox.Name = "masterPasswordTextBox";
            this.masterPasswordTextBox.Size = new System.Drawing.Size(329, 50);
            this.masterPasswordTextBox.TabIndex = 2;
            this.masterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // createNewPasswordLink
            // 
            this.createNewPasswordLink.AutoSize = true;
            this.createNewPasswordLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewPasswordLink.Location = new System.Drawing.Point(516, 189);
            this.createNewPasswordLink.Name = "createNewPasswordLink";
            this.createNewPasswordLink.Size = new System.Drawing.Size(104, 20);
            this.createNewPasswordLink.TabIndex = 3;
            this.createNewPasswordLink.TabStop = true;
            this.createNewPasswordLink.Text = "New Password";
            // 
            // PassBankLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 218);
            this.Controls.Add(this.createNewPasswordLink);
            this.Controls.Add(this.masterPasswordTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.masterPasswordLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PassBankLoginForm";
            this.Text = "PassBankLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masterPasswordLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox masterPasswordTextBox;
        private System.Windows.Forms.LinkLabel createNewPasswordLink;
    }
}

