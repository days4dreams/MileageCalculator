namespace MileageCalculator
{
    partial class MileageForm
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
            this.StartInput = new System.Windows.Forms.NumericUpDown();
            this.EndInput = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.IntroMessageLabel = new System.Windows.Forms.Label();
            this.StartMileageLabel = new System.Windows.Forms.Label();
            this.EndMileageLabel = new System.Windows.Forms.Label();
            this.AmountOwedLabel = new System.Windows.Forms.Label();
            this.AmountOwedText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndInput)).BeginInit();
            this.SuspendLayout();
            // 
            // StartInput
            // 
            this.StartInput.Location = new System.Drawing.Point(200, 54);
            this.StartInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.StartInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartInput.Name = "StartInput";
            this.StartInput.Size = new System.Drawing.Size(153, 20);
            this.StartInput.TabIndex = 0;
            this.StartInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndInput
            // 
            this.EndInput.Location = new System.Drawing.Point(200, 80);
            this.EndInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.EndInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndInput.Name = "EndInput";
            this.EndInput.Size = new System.Drawing.Size(153, 20);
            this.EndInput.TabIndex = 1;
            this.EndInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(126, 139);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(163, 28);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // IntroMessageLabel
            // 
            this.IntroMessageLabel.AutoSize = true;
            this.IntroMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroMessageLabel.Location = new System.Drawing.Point(21, 21);
            this.IntroMessageLabel.Name = "IntroMessageLabel";
            this.IntroMessageLabel.Size = new System.Drawing.Size(375, 13);
            this.IntroMessageLabel.TabIndex = 3;
            this.IntroMessageLabel.Text = "Enter your start and end mileage to see how much you are owed.";
            this.IntroMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IntroMessageLabel.Click += new System.EventHandler(this.IntroMessageLabel_Click);
            // 
            // StartMileageLabel
            // 
            this.StartMileageLabel.AutoSize = true;
            this.StartMileageLabel.Location = new System.Drawing.Point(56, 54);
            this.StartMileageLabel.Name = "StartMileageLabel";
            this.StartMileageLabel.Size = new System.Drawing.Size(83, 13);
            this.StartMileageLabel.TabIndex = 4;
            this.StartMileageLabel.Text = "Starting Mileage";
            // 
            // EndMileageLabel
            // 
            this.EndMileageLabel.AutoSize = true;
            this.EndMileageLabel.Location = new System.Drawing.Point(56, 80);
            this.EndMileageLabel.Name = "EndMileageLabel";
            this.EndMileageLabel.Size = new System.Drawing.Size(80, 13);
            this.EndMileageLabel.TabIndex = 5;
            this.EndMileageLabel.Text = "Ending Mileage";
            // 
            // AmountOwedLabel
            // 
            this.AmountOwedLabel.AutoSize = true;
            this.AmountOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOwedLabel.Location = new System.Drawing.Point(56, 109);
            this.AmountOwedLabel.Name = "AmountOwedLabel";
            this.AmountOwedLabel.Size = new System.Drawing.Size(89, 13);
            this.AmountOwedLabel.TabIndex = 6;
            this.AmountOwedLabel.Text = "Amount Owed:";
            // 
            // AmountOwedText
            // 
            this.AmountOwedText.AutoSize = true;
            this.AmountOwedText.Location = new System.Drawing.Point(197, 109);
            this.AmountOwedText.Name = "AmountOwedText";
            this.AmountOwedText.Size = new System.Drawing.Size(34, 13);
            this.AmountOwedText.TabIndex = 7;
            this.AmountOwedText.Text = "£0.00";
            // 
            // MileageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 179);
            this.Controls.Add(this.AmountOwedText);
            this.Controls.Add(this.AmountOwedLabel);
            this.Controls.Add(this.EndMileageLabel);
            this.Controls.Add(this.StartMileageLabel);
            this.Controls.Add(this.IntroMessageLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.EndInput);
            this.Controls.Add(this.StartInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MileageForm";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.StartInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown StartInput;
        private System.Windows.Forms.NumericUpDown EndInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label IntroMessageLabel;
        private System.Windows.Forms.Label StartMileageLabel;
        private System.Windows.Forms.Label EndMileageLabel;
        private System.Windows.Forms.Label AmountOwedLabel;
        private System.Windows.Forms.Label AmountOwedText;
    }
}

