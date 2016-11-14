namespace WatCalendarToGoogleCalendar
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
            this.uxOutput = new System.Windows.Forms.TextBox();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxOutput
            // 
            this.uxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOutput.Location = new System.Drawing.Point(292, 12);
            this.uxOutput.Multiline = true;
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.Size = new System.Drawing.Size(272, 261);
            this.uxOutput.TabIndex = 1;
            // 
            // uxInput
            // 
            this.uxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uxInput.Location = new System.Drawing.Point(12, 12);
            this.uxInput.Multiline = true;
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(272, 261);
            this.uxInput.TabIndex = 2;
            this.uxInput.TextChanged += new System.EventHandler(this.uxInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 285);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.uxOutput);
            this.Name = "Form1";
            this.Text = "WatCalendarToGoogleCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxOutput;
        private System.Windows.Forms.TextBox uxInput;
    }
}

