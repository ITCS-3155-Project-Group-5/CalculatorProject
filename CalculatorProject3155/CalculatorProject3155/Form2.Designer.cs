
namespace CalculatorProject3155
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
            this.UnitConversionButton = new System.Windows.Forms.Button();
            this.GraphingButton = new System.Windows.Forms.Button();
            this.CurrencyConversionButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnitConversionButton
            // 
            this.UnitConversionButton.Location = new System.Drawing.Point(44, 59);
            this.UnitConversionButton.Name = "UnitConversionButton";
            this.UnitConversionButton.Size = new System.Drawing.Size(175, 122);
            this.UnitConversionButton.TabIndex = 0;
            this.UnitConversionButton.Text = "Unit Conversion";
            this.UnitConversionButton.UseVisualStyleBackColor = true;
            this.UnitConversionButton.Click += new System.EventHandler(this.UnitConversionButton_Click);
            // 
            // GraphingButton
            // 
            this.GraphingButton.Location = new System.Drawing.Point(44, 286);
            this.GraphingButton.Name = "GraphingButton";
            this.GraphingButton.Size = new System.Drawing.Size(175, 122);
            this.GraphingButton.TabIndex = 1;
            this.GraphingButton.Text = "Graphing";
            this.GraphingButton.UseVisualStyleBackColor = true;
            this.GraphingButton.Click += new System.EventHandler(this.GraphingButton_Click);
            // 
            // CurrencyConversionButton
            // 
            this.CurrencyConversionButton.Location = new System.Drawing.Point(305, 59);
            this.CurrencyConversionButton.Name = "CurrencyConversionButton";
            this.CurrencyConversionButton.Size = new System.Drawing.Size(175, 122);
            this.CurrencyConversionButton.TabIndex = 2;
            this.CurrencyConversionButton.Text = "Currency Conversion";
            this.CurrencyConversionButton.UseVisualStyleBackColor = true;
            this.CurrencyConversionButton.Click += new System.EventHandler(this.CurrencyConversionButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(305, 286);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(175, 122);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(513, 498);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.CurrencyConversionButton);
            this.Controls.Add(this.GraphingButton);
            this.Controls.Add(this.UnitConversionButton);
            this.Name = "Form2";
            this.Text = "More Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnitConversionButton;
        private System.Windows.Forms.Button GraphingButton;
        private System.Windows.Forms.Button CurrencyConversionButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}