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
            this.luckyButton = new System.Windows.Forms.Button();
            this.uniqueButton = new System.Windows.Forms.Button();
            this.chatbotButton1 = new System.Windows.Forms.Button();
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
            this.largestWordButton.Location = new System.Drawing.Point(114, 148);
            this.largestWordButton.Name = "largestWordButton";
            this.largestWordButton.Size = new System.Drawing.Size(111, 43);
            this.largestWordButton.TabIndex = 3;
            this.largestWordButton.Text = "Largest Word";
            this.largestWordButton.UseVisualStyleBackColor = true;
            this.largestWordButton.Click += new System.EventHandler(this.largestWordButton_Click);
            // 
            // luckyButton
            // 
            this.luckyButton.Location = new System.Drawing.Point(114, 197);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.Size = new System.Drawing.Size(111, 43);
            this.luckyButton.TabIndex = 4;
            this.luckyButton.Text = "Feeling Lucky";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // uniqueButton
            // 
            this.uniqueButton.Location = new System.Drawing.Point(114, 246);
            this.uniqueButton.Name = "uniqueButton";
            this.uniqueButton.Size = new System.Drawing.Size(111, 43);
            this.uniqueButton.TabIndex = 5;
            this.uniqueButton.Text = "Longest Unique String";
            this.uniqueButton.UseVisualStyleBackColor = true;
            this.uniqueButton.Click += new System.EventHandler(this.uniqueButton_Click);
            // 
            // chatbotButton1
            // 
            this.chatbotButton1.Location = new System.Drawing.Point(114, 295);
            this.chatbotButton1.Name = "chatbotButton1";
            this.chatbotButton1.Size = new System.Drawing.Size(111, 43);
            this.chatbotButton1.TabIndex = 6;
            this.chatbotButton1.Text = "ChatBot Check Context: Parking";
            this.chatbotButton1.UseVisualStyleBackColor = true;
            this.chatbotButton1.Click += new System.EventHandler(this.chatbotButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 432);
            this.Controls.Add(this.chatbotButton1);
            this.Controls.Add(this.uniqueButton);
            this.Controls.Add(this.luckyButton);
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
        private System.Windows.Forms.Button luckyButton;
        private System.Windows.Forms.Button uniqueButton;
        private System.Windows.Forms.Button chatbotButton1;
    }
}

