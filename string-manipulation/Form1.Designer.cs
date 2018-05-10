namespace string_manipulation
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.explainLabel1 = new System.Windows.Forms.Label();
            this.explainLabel2 = new System.Windows.Forms.Label();
            this.largestWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 67);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(313, 20);
            this.textBox.TabIndex = 0;
            // 
            // explainLabel1
            // 
            this.explainLabel1.AutoSize = true;
            this.explainLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel1.Location = new System.Drawing.Point(100, 31);
            this.explainLabel1.Name = "explainLabel1";
            this.explainLabel1.Size = new System.Drawing.Size(141, 20);
            this.explainLabel1.TabIndex = 1;
            this.explainLabel1.Text = "Enter String Below";
            // 
            // explainLabel2
            // 
            this.explainLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel2.Location = new System.Drawing.Point(100, 103);
            this.explainLabel2.Name = "explainLabel2";
            this.explainLabel2.Size = new System.Drawing.Size(141, 20);
            this.explainLabel2.TabIndex = 2;
            this.explainLabel2.Text = "Select an Option";
            this.explainLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // largestWordButton
            // 
            this.largestWordButton.Location = new System.Drawing.Point(130, 148);
            this.largestWordButton.Name = "largestWordButton";
            this.largestWordButton.Size = new System.Drawing.Size(75, 43);
            this.largestWordButton.TabIndex = 3;
            this.largestWordButton.Text = "Largest Word";
            this.largestWordButton.UseVisualStyleBackColor = true;
            this.largestWordButton.Click += new System.EventHandler(this.largestWordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 381);
            this.Controls.Add(this.largestWordButton);
            this.Controls.Add(this.explainLabel2);
            this.Controls.Add(this.explainLabel1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "String Manipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label explainLabel1;
        private System.Windows.Forms.Label explainLabel2;
        private System.Windows.Forms.Button largestWordButton;
    }
}

