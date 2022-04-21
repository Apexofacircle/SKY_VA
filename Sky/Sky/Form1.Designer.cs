namespace Sky
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
            this.TextRecognized = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextRecognized
            // 
            this.TextRecognized.Location = new System.Drawing.Point(208, 142);
            this.TextRecognized.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextRecognized.Multiline = true;
            this.TextRecognized.Name = "TextRecognized";
            this.TextRecognized.Size = new System.Drawing.Size(242, 22);
            this.TextRecognized.TabIndex = 0;
            this.TextRecognized.TextChanged += new System.EventHandler(this.TextRecognized_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.TextRecognized);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextRecognized;
    }
}

