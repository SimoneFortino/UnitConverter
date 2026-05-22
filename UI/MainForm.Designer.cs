using System.Linq;
using UnitConverter.Utils;

namespace UnitConverter
{
    partial class MainForm
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
            this.startingValueTextBox = new System.Windows.Forms.TextBox();
            this.convertedValueTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.startingUnitComboBox = new System.Windows.Forms.ComboBox();
            this.convertedUnitComboBox = new System.Windows.Forms.ComboBox();
            this.physicalQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startingValueTextBox
            // 
            this.startingValueTextBox.Location = new System.Drawing.Point(12, 127);
            this.startingValueTextBox.Name = "startingValueTextBox";
            this.startingValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.startingValueTextBox.TabIndex = 0;
            // 
            // convertedValueTextBox
            // 
            this.convertedValueTextBox.Location = new System.Drawing.Point(12, 192);
            this.convertedValueTextBox.Name = "convertedValueTextBox";
            this.convertedValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.convertedValueTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(199, 191);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startingUnitComboBox
            // 
            this.startingUnitComboBox.FormattingEnabled = true;
            this.startingUnitComboBox.Location = new System.Drawing.Point(118, 125);
            this.startingUnitComboBox.Name = "startingUnitComboBox";
            this.startingUnitComboBox.Size = new System.Drawing.Size(49, 24);
            this.startingUnitComboBox.TabIndex = 3;
            // 
            // convertedUnitComboBox
            // 
            this.convertedUnitComboBox.FormattingEnabled = true;
            this.convertedUnitComboBox.Location = new System.Drawing.Point(118, 192);
            this.convertedUnitComboBox.Name = "convertedUnitComboBox";
            this.convertedUnitComboBox.Size = new System.Drawing.Size(49, 24);
            this.convertedUnitComboBox.TabIndex = 4;
            // 
            // physicalQuantityComboBox
            // 
            this.physicalQuantityComboBox.FormattingEnabled = true;
            this.physicalQuantityComboBox.Location = new System.Drawing.Point(12, 55);
            this.physicalQuantityComboBox.Name = "physicalQuantityComboBox";
            this.physicalQuantityComboBox.Size = new System.Drawing.Size(155, 24);
            this.physicalQuantityComboBox.TabIndex = 5;
            this.physicalQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.physicalQuantityComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 330);
            this.Controls.Add(this.physicalQuantityComboBox);
            this.Controls.Add(this.convertedUnitComboBox);
            this.Controls.Add(this.startingUnitComboBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedValueTextBox);
            this.Controls.Add(this.startingValueTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox startingUnitComboBox;

        private System.Windows.Forms.ComboBox physicalQuantityComboBox;
        private System.Windows.Forms.ComboBox convertedUnitComboBox;

        private System.Windows.Forms.TextBox startingValueTextBox;
        private System.Windows.Forms.TextBox convertedValueTextBox;
        private System.Windows.Forms.Button convertButton;

        #endregion
    }
}