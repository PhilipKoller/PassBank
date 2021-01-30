
namespace PassBankUI
{
    partial class PassBankViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassBankViewerForm));
            this.listBoxAccountViewer = new System.Windows.Forms.ListBox();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addAccountLink = new System.Windows.Forms.LinkLabel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAccountViewer
            // 
            this.listBoxAccountViewer.FormattingEnabled = true;
            this.listBoxAccountViewer.Location = new System.Drawing.Point(37, 60);
            this.listBoxAccountViewer.Name = "listBoxAccountViewer";
            this.listBoxAccountViewer.Size = new System.Drawing.Size(665, 264);
            this.listBoxAccountViewer.TabIndex = 0;
            // 
            // getInfoButton
            // 
            this.getInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.getInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.getInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.getInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInfoButton.Location = new System.Drawing.Point(391, 330);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(243, 66);
            this.getInfoButton.TabIndex = 2;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(104, 330);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(243, 66);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Selected ";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addAccountLink
            // 
            this.addAccountLink.AutoSize = true;
            this.addAccountLink.Location = new System.Drawing.Point(633, 44);
            this.addAccountLink.Name = "addAccountLink";
            this.addAccountLink.Size = new System.Drawing.Size(69, 13);
            this.addAccountLink.TabIndex = 4;
            this.addAccountLink.TabStop = true;
            this.addAccountLink.Text = "Add Account";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(44, 21);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "User:";
            // 
            // PassBankViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 402);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.addAccountLink);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.listBoxAccountViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassBankViewerForm";
            this.Text = "PassBankViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAccountViewer;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.LinkLabel addAccountLink;
        private System.Windows.Forms.Label userNameLabel;
    }
}