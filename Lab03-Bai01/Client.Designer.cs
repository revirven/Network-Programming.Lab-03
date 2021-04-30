
namespace Lab03_Bai01
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_IP = new System.Windows.Forms.TextBox();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote host";
            // 
            // TextBox_IP
            // 
            this.TextBox_IP.Location = new System.Drawing.Point(12, 32);
            this.TextBox_IP.Name = "TextBox_IP";
            this.TextBox_IP.Size = new System.Drawing.Size(410, 27);
            this.TextBox_IP.TabIndex = 1;
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(475, 32);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(158, 27);
            this.TextBox_Port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // TextBox_Message
            // 
            this.TextBox_Message.Location = new System.Drawing.Point(12, 102);
            this.TextBox_Message.Multiline = true;
            this.TextBox_Message.Name = "TextBox_Message";
            this.TextBox_Message.Size = new System.Drawing.Size(621, 167);
            this.TextBox_Message.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // bttn_Send
            // 
            this.bttn_Send.Location = new System.Drawing.Point(12, 295);
            this.bttn_Send.Name = "bttn_Send";
            this.bttn_Send.Size = new System.Drawing.Size(116, 38);
            this.bttn_Send.TabIndex = 6;
            this.bttn_Send.Text = "Send";
            this.bttn_Send.UseVisualStyleBackColor = true;
            this.bttn_Send.Click += new System.EventHandler(this.bttn_Send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 345);
            this.Controls.Add(this.bttn_Send);
            this.Controls.Add(this.TextBox_Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_IP);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_IP;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn_Send;
    }
}