
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
            this.UnitConversionButton.Location = new System.Drawing.Point(59, 73);
            this.UnitConversionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnitConversionButton.Name = "UnitConversionButton";
            this.UnitConversionButton.Size = new System.Drawing.Size(233, 150);
            this.UnitConversionButton.TabIndex = 0;
            this.UnitConversionButton.Text = "Unit Conversion";
            this.UnitConversionButton.UseVisualStyleBackColor = true;
            this.UnitConversionButton.Click += new System.EventHandler(this.UnitConversionButton_Click);
            // 
            // GraphingButton
            // 
            this.GraphingButton.Location = new System.Drawing.Point(59, 352);
            this.GraphingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GraphingButton.Name = "GraphingButton";
            this.GraphingButton.Size = new System.Drawing.Size(233, 150);
            this.GraphingButton.TabIndex = 1;
            this.GraphingButton.Text = "Graphing";
            this.GraphingButton.UseVisualStyleBackColor = true;
            this.GraphingButton.Click += new System.EventHandler(this.GraphingButton_Click);
            // 
            // CurrencyConversionButton
            // 
            this.CurrencyConversionButton.Location = new System.Drawing.Point(407, 73);
            this.CurrencyConversionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CurrencyConversionButton.Name = "CurrencyConversionButton";
            this.CurrencyConversionButton.Size = new System.Drawing.Size(233, 150);
            this.CurrencyConversionButton.TabIndex = 2;
            this.CurrencyConversionButton.Text = "Currency Conversion";
            this.CurrencyConversionButton.UseVisualStyleBackColor = true;
            this.CurrencyConversionButton.Click += new System.EventHandler(this.CurrencyConversionButton_Click);
            // 
            // BasicOperationsButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(407, 352);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(233, 150);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Basic Operations";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.BasicOperationsButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 613);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.CurrencyConversionButton);
            this.Controls.Add(this.GraphingButton);
            this.Controls.Add(this.UnitConversionButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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