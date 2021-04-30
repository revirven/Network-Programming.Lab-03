
namespace Lab03_Bai02
{
    partial class Lab03_Bai02
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
            this.bttn_Listen = new System.Windows.Forms.Button();
            this.ListView_Commands = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bttn_Listen
            // 
            this.bttn_Listen.Location = new System.Drawing.Point(315, 24);
            this.bttn_Listen.Name = "bttn_Listen";
            this.bttn_Listen.Size = new System.Drawing.Size(123, 41);
            this.bttn_Listen.TabIndex = 0;
            this.bttn_Listen.Text = "Listen";
            this.bttn_Listen.UseVisualStyleBackColor = true;
            this.bttn_Listen.Click += new System.EventHandler(this.bttn_Listen_Click);
            // 
            // ListView_Commands
            // 
            this.ListView_Commands.HideSelection = false;
            this.ListView_Commands.Location = new System.Drawing.Point(31, 83);
            this.ListView_Commands.Name = "ListView_Commands";
            this.ListView_Commands.Size = new System.Drawing.Size(407, 326);
            this.ListView_Commands.TabIndex = 2;
            this.ListView_Commands.UseCompatibleStateImageBehavior = false;
            this.ListView_Commands.View = System.Windows.Forms.View.List;
            // 
            // Lab03_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 440);
            this.Controls.Add(this.ListView_Commands);
            this.Controls.Add(this.bttn_Listen);
            this.Name = "Lab03_Bai02";
            this.Text = "Bài 02";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Listener_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Listen;
        private System.Windows.Forms.ListView ListView_Commands;
    }
}

