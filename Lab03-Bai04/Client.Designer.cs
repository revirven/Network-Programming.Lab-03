
namespace Lab03_Bai04
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
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RichTextBox_RecvMessages = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.RichTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(22, 50);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(428, 27);
            this.TextBox_Name.TabIndex = 0;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(519, 46);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(130, 34);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // RichTextBox_RecvMessages
            // 
            this.RichTextBox_RecvMessages.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBox_RecvMessages.Location = new System.Drawing.Point(22, 111);
            this.RichTextBox_RecvMessages.Name = "RichTextBox_RecvMessages";
            this.RichTextBox_RecvMessages.ReadOnly = true;
            this.RichTextBox_RecvMessages.Size = new System.Drawing.Size(627, 287);
            this.RichTextBox_RecvMessages.TabIndex = 3;
            this.RichTextBox_RecvMessages.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(554, 446);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(95, 71);
            this.button_Send.TabIndex = 6;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // RichTextBox_Message
            // 
            this.RichTextBox_Message.Location = new System.Drawing.Point(22, 446);
            this.RichTextBox_Message.Name = "RichTextBox_Message";
            this.RichTextBox_Message.Size = new System.Drawing.Size(497, 71);
            this.RichTextBox_Message.TabIndex = 4;
            this.RichTextBox_Message.Text = "";
            this.RichTextBox_Message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox_Message_KeyPressed);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 542);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RichTextBox_Message);
            this.Controls.Add(this.RichTextBox_RecvMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.TextBox_Name);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBox_RecvMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.RichTextBox RichTextBox_Message;
    }
}