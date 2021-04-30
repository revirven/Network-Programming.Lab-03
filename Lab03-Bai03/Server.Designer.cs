
namespace Lab03_Bai03
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
            this.ListView_Messages = new System.Windows.Forms.ListView();
            this.button_Listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView_Messages
            // 
            this.ListView_Messages.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListView_Messages.HideSelection = false;
            this.ListView_Messages.Location = new System.Drawing.Point(33, 94);
            this.ListView_Messages.Name = "ListView_Messages";
            this.ListView_Messages.Size = new System.Drawing.Size(400, 303);
            this.ListView_Messages.TabIndex = 0;
            this.ListView_Messages.UseCompatibleStateImageBehavior = false;
            this.ListView_Messages.View = System.Windows.Forms.View.Tile;
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(290, 32);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(143, 39);
            this.button_Listen.TabIndex = 1;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 431);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.ListView_Messages);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Messages;
        private System.Windows.Forms.Button button_Listen;
    }
}