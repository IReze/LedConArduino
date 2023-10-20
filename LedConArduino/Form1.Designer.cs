namespace LedConArduino
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
            this.btn_prender = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_prender
            // 
            this.btn_prender.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_prender.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_prender.Location = new System.Drawing.Point(113, 107);
            this.btn_prender.Name = "btn_prender";
            this.btn_prender.Size = new System.Drawing.Size(156, 62);
            this.btn_prender.TabIndex = 0;
            this.btn_prender.Text = "PRENDER";
            this.btn_prender.UseVisualStyleBackColor = false;
            this.btn_prender.Click += new System.EventHandler(this.btn_prender_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(113, 259);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(156, 61);
            this.btn_apagar.TabIndex = 1;
            this.btn_apagar.Text = "APAGAR";
            this.btn_apagar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 521);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_prender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prender;
        private System.Windows.Forms.Button btn_apagar;
    }
}

