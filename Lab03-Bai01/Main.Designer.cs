
namespace Lab03_Bai01
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttn_Client = new System.Windows.Forms.Button();
            this.bttn_Server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_Client
            // 
            this.bttn_Client.Location = new System.Drawing.Point(62, 53);
            this.bttn_Client.Name = "bttn_Client";
            this.bttn_Client.Size = new System.Drawing.Size(149, 58);
            this.bttn_Client.TabIndex = 0;
            this.bttn_Client.Text = "Client";
            this.bttn_Client.UseVisualStyleBackColor = true;
            this.bttn_Client.Click += new System.EventHandler(this.bttn_Client_Click);
            // 
            // bttn_Server
            // 
            this.bttn_Server.Location = new System.Drawing.Point(281, 53);
            this.bttn_Server.Name = "bttn_Server";
            this.bttn_Server.Size = new System.Drawing.Size(149, 58);
            this.bttn_Server.TabIndex = 1;
            this.bttn_Server.Text = "Server";
            this.bttn_Server.UseVisualStyleBackColor = true;
            this.bttn_Server.Click += new System.EventHandler(this.bttn_Server_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 155);
            this.Controls.Add(this.bttn_Server);
            this.Controls.Add(this.bttn_Client);
            this.Name = "Main";
            this.Text = "Bài 01";
            this.Load += new System.EventHandler(this.Lab03_Bai01_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Client;
        private System.Windows.Forms.Button bttn_Server;
    }
}

