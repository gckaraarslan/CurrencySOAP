namespace Döviz_Güncel
{
    partial class Form1
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
            this.USDTEXT = new System.Windows.Forms.Label();
            this.HESAPLABUTTON = new System.Windows.Forms.Button();
            this.EUROTEXT = new System.Windows.Forms.Label();
            this.POUNDTEXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // USDTEXT
            // 
            this.USDTEXT.AutoSize = true;
            this.USDTEXT.Location = new System.Drawing.Point(307, 69);
            this.USDTEXT.Name = "USDTEXT";
            this.USDTEXT.Size = new System.Drawing.Size(29, 15);
            this.USDTEXT.TabIndex = 0;
            this.USDTEXT.Text = "USD";
            this.USDTEXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // HESAPLABUTTON
            // 
            this.HESAPLABUTTON.Location = new System.Drawing.Point(298, 212);
            this.HESAPLABUTTON.Name = "HESAPLABUTTON";
            this.HESAPLABUTTON.Size = new System.Drawing.Size(75, 23);
            this.HESAPLABUTTON.TabIndex = 1;
            this.HESAPLABUTTON.Text = "HESAPLA";
            this.HESAPLABUTTON.UseVisualStyleBackColor = true;
            this.HESAPLABUTTON.Click += new System.EventHandler(this.HESAPLABUTTON_Click);
            // 
            // EUROTEXT
            // 
            this.EUROTEXT.AutoSize = true;
            this.EUROTEXT.Location = new System.Drawing.Point(307, 101);
            this.EUROTEXT.Name = "EUROTEXT";
            this.EUROTEXT.Size = new System.Drawing.Size(37, 15);
            this.EUROTEXT.TabIndex = 0;
            this.EUROTEXT.Text = "EURO";
            this.EUROTEXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // POUNDTEXT
            // 
            this.POUNDTEXT.AutoSize = true;
            this.POUNDTEXT.Location = new System.Drawing.Point(307, 140);
            this.POUNDTEXT.Name = "POUNDTEXT";
            this.POUNDTEXT.Size = new System.Drawing.Size(48, 15);
            this.POUNDTEXT.TabIndex = 0;
            this.POUNDTEXT.Text = "POUND";
            this.POUNDTEXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HESAPLABUTTON);
            this.Controls.Add(this.POUNDTEXT);
            this.Controls.Add(this.EUROTEXT);
            this.Controls.Add(this.USDTEXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label USDTEXT;
        private Button HESAPLABUTTON;
        private Label EUROTEXT;
        private Label POUNDTEXT;
    }
}