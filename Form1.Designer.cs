namespace GettingStartedWithSourceControl
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
            this.valueOneLabel = new System.Windows.Forms.Label();
            this.operationLabel = new System.Windows.Forms.Label();
            this.valueTwoLabel = new System.Windows.Forms.Label();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.valueOneTextBox = new System.Windows.Forms.TextBox();
            this.valueTwoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valueOneLabel
            // 
            this.valueOneLabel.AutoSize = true;
            this.valueOneLabel.Location = new System.Drawing.Point(12, 20);
            this.valueOneLabel.Name = "valueOneLabel";
            this.valueOneLabel.Size = new System.Drawing.Size(43, 13);
            this.valueOneLabel.TabIndex = 0;
            this.valueOneLabel.Text = "Value 1";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(12, 58);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(53, 13);
            this.operationLabel.TabIndex = 1;
            this.operationLabel.Text = "Operation";
            // 
            // valueTwoLabel
            // 
            this.valueTwoLabel.AutoSize = true;
            this.valueTwoLabel.Location = new System.Drawing.Point(12, 90);
            this.valueTwoLabel.Name = "valueTwoLabel";
            this.valueTwoLabel.Size = new System.Drawing.Size(43, 13);
            this.valueTwoLabel.TabIndex = 2;
            this.valueTwoLabel.Text = "Value 2";
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(71, 50);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(121, 21);
            this.operationComboBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(202, 20);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(202, 58);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // valueOneTextBox
            // 
            this.valueOneTextBox.Location = new System.Drawing.Point(71, 13);
            this.valueOneTextBox.Name = "valueOneTextBox";
            this.valueOneTextBox.Size = new System.Drawing.Size(121, 20);
            this.valueOneTextBox.TabIndex = 8;
            // 
            // valueTwoTextBox
            // 
            this.valueTwoTextBox.Location = new System.Drawing.Point(71, 83);
            this.valueTwoTextBox.Name = "valueTwoTextBox";
            this.valueTwoTextBox.Size = new System.Drawing.Size(121, 20);
            this.valueTwoTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 128);
            this.Controls.Add(this.valueTwoTextBox);
            this.Controls.Add(this.valueOneTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.valueTwoLabel);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.valueOneLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valueOneLabel;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Label valueTwoLabel;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox valueOneTextBox;
        private System.Windows.Forms.TextBox valueTwoTextBox;
    }
}

