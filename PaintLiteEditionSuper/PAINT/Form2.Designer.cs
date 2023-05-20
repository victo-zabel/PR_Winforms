namespace PAINT
{
    partial class Form2
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
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.numeric_Red = new System.Windows.Forms.NumericUpDown();
            this.numeric_Green = new System.Windows.Forms.NumericUpDown();
            this.numeric_Blue = new System.Windows.Forms.NumericUpDown();
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Other = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).BeginInit();
            this.SuspendLayout();
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.LargeChange = 1;
            this.Scroll_Red.Location = new System.Drawing.Point(74, 39);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(143, 17);
            this.Scroll_Red.TabIndex = 0;
            this.Scroll_Red.ValueChanged += new System.EventHandler(this.Scroll_Red_ValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.LargeChange = 1;
            this.Scroll_Green.Location = new System.Drawing.Point(74, 88);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(143, 17);
            this.Scroll_Green.TabIndex = 1;
            this.Scroll_Green.ValueChanged += new System.EventHandler(this.Scroll_Green_ValueChanged);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.LargeChange = 1;
            this.Scroll_Blue.Location = new System.Drawing.Point(74, 133);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(143, 17);
            this.Scroll_Blue.TabIndex = 2;
            this.Scroll_Blue.ValueChanged += new System.EventHandler(this.Scroll_Blue_ValueChanged);
            // 
            // numeric_Red
            // 
            this.numeric_Red.Location = new System.Drawing.Point(259, 39);
            this.numeric_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Red.Name = "numeric_Red";
            this.numeric_Red.Size = new System.Drawing.Size(40, 20);
            this.numeric_Red.TabIndex = 3;
            this.numeric_Red.ValueChanged += new System.EventHandler(this.numeric_Red_ValueChanged);
            // 
            // numeric_Green
            // 
            this.numeric_Green.Location = new System.Drawing.Point(259, 85);
            this.numeric_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Green.Name = "numeric_Green";
            this.numeric_Green.Size = new System.Drawing.Size(40, 20);
            this.numeric_Green.TabIndex = 4;
            this.numeric_Green.ValueChanged += new System.EventHandler(this.numeric_Green_ValueChanged);
            // 
            // numeric_Blue
            // 
            this.numeric_Blue.Location = new System.Drawing.Point(259, 133);
            this.numeric_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Blue.Name = "numeric_Blue";
            this.numeric_Blue.Size = new System.Drawing.Size(40, 20);
            this.numeric_Blue.TabIndex = 5;
            this.numeric_Blue.ValueChanged += new System.EventHandler(this.numeric_Blue_ValueChanged);
            // 
            // picResultColor
            // 
            this.picResultColor.Location = new System.Drawing.Point(340, 39);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(111, 111);
            this.picResultColor.TabIndex = 6;
            this.picResultColor.TabStop = false;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 171);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(93, 171);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.Location = new System.Drawing.Point(403, 171);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(75, 23);
            this.Other.TabIndex = 9;
            this.Other.Text = "Other Colors";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.Other_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 206);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.picResultColor);
            this.Controls.Add(this.numeric_Blue);
            this.Controls.Add(this.numeric_Green);
            this.Controls.Add(this.numeric_Red);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Red);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.NumericUpDown numeric_Red;
        private System.Windows.Forms.NumericUpDown numeric_Green;
        private System.Windows.Forms.NumericUpDown numeric_Blue;
        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Other;
    }
}