namespace W4Exercise6
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
            this.button1 = new System.Windows.Forms.Button();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll Dice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.BackColor = System.Drawing.Color.Black;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.ForeColor = System.Drawing.Color.White;
            this.result1.Location = new System.Drawing.Point(243, 56);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(42, 46);
            this.result1.TabIndex = 1;
            this.result1.Text = "1";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.BackColor = System.Drawing.Color.Black;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2.ForeColor = System.Drawing.Color.White;
            this.result2.Location = new System.Drawing.Point(314, 58);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(42, 46);
            this.result2.TabIndex = 2;
            this.result2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter # of sides of your dice:";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(163, 11);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(57, 20);
            this.userInput.TabIndex = 4;
            this.userInput.Text = "4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 136);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button button2;
    }
}

