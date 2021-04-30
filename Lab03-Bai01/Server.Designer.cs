
namespace Lab03_Bai01
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
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_Listen = new System.Windows.Forms.Button();
            this.ListView_Messages = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(12, 38);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(158, 27);
            this.TextBox_Port.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Received messages";
            // 
            // bttn_Listen
            // 
            this.bttn_Listen.Location = new System.Drawing.Point(503, 32);
            this.bttn_Listen.Name = "bttn_Listen";
            this.bttn_Listen.Size = new System.Drawing.Size(116, 38);
            this.bttn_Listen.TabIndex = 8;
            this.bttn_Listen.Text = "Listen";
            this.bttn_Listen.UseVisualStyleBackColor = true;
            this.bttn_Listen.Click += new System.EventHandler(this.bttn_Listen_Click);
            // 
            // ListView_Messages
            // 
            this.ListView_Messages.HideSelection = false;
            this.ListView_Messages.Location = new System.Drawing.Point(12, 128);
            this.ListView_Messages.Name = "ListView_Messages";
            this.ListView_Messages.Size = new System.Drawing.Size(607, 233);
            this.ListView_Messages.TabIndex = 9;
            this.ListView_Messages.UseCompatibleStateImageBehavior = false;
            this.ListView_Messages.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 391);
            this.Controls.Add(this.ListView_Messages);
            this.Controls.Add(this.bttn_Listen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.label2);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Listen;
        private System.Windows.Forms.ListView ListView_Messages;
    }
}