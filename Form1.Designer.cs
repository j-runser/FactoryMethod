namespace FactoryMethod
{
    partial class Form1
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
            this.btn_laptop = new System.Windows.Forms.Button();
            this.lbl_desktop = new System.Windows.Forms.Button();
            this.rTxtBox_display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_laptop
            // 
            this.btn_laptop.Location = new System.Drawing.Point(20, 20);
            this.btn_laptop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_laptop.Name = "btn_laptop";
            this.btn_laptop.Size = new System.Drawing.Size(189, 35);
            this.btn_laptop.TabIndex = 0;
            this.btn_laptop.Text = "Produce Laptop";
            this.btn_laptop.UseVisualStyleBackColor = true;
            this.btn_laptop.Click += new System.EventHandler(this.btn_laptop_Click);
            // 
            // lbl_desktop
            // 
            this.lbl_desktop.Location = new System.Drawing.Point(20, 66);
            this.lbl_desktop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_desktop.Name = "lbl_desktop";
            this.lbl_desktop.Size = new System.Drawing.Size(189, 35);
            this.lbl_desktop.TabIndex = 1;
            this.lbl_desktop.Text = "Produce Desktop";
            this.lbl_desktop.UseVisualStyleBackColor = true;
            this.lbl_desktop.Click += new System.EventHandler(this.lbl_desktop_Click);
            // 
            // rTxtBox_display
            // 
            this.rTxtBox_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtBox_display.Location = new System.Drawing.Point(218, 20);
            this.rTxtBox_display.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rTxtBox_display.Name = "rTxtBox_display";
            this.rTxtBox_display.Size = new System.Drawing.Size(188, 361);
            this.rTxtBox_display.TabIndex = 2;
            this.rTxtBox_display.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.rTxtBox_display);
            this.Controls.Add(this.lbl_desktop);
            this.Controls.Add(this.btn_laptop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Factory Method";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_laptop;
        private System.Windows.Forms.Button lbl_desktop;
        private System.Windows.Forms.RichTextBox rTxtBox_display;
    }
}

