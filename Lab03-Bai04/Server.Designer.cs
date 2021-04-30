
namespace Lab03_Bai04
{
    partial class Server
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
            this.button_Listen = new System.Windows.Forms.Button();
            this.RichTextBox_Messages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(317, 39);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(152, 36);
            this.button_Listen.TabIndex = 0;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // RichTextBox_Messages
            // 
            this.RichTextBox_Messages.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBox_Messages.Location = new System.Drawing.Point(33, 109);
            this.RichTextBox_Messages.Name = "RichTextBox_Messages";
            this.RichTextBox_Messages.ReadOnly = true;
            this.RichTextBox_Messages.Size = new System.Drawing.Size(436, 281);
            this.RichTextBox_Messages.TabIndex = 1;
            this.RichTextBox_Messages.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 427);
            this.Controls.Add(this.RichTextBox_Messages);
            this.Controls.Add(this.button_Listen);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.RichTextBox RichTextBox_Messages;
    }
}