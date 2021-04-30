
namespace Lab03_Bai03
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
            this.button_SendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Location = new System.Drawing.Point(12, 12);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(371, 38);
            this.button_SendMessage.TabIndex = 0;
            this.button_SendMessage.Text = "Send message";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            this.button_SendMessage.Click += new System.EventHandler(this.button_SendMessage_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 62);
            this.Controls.Add(this.button_SendMessage);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SendMessage;
    }
}