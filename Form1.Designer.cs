namespace Quiz_App
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
            this.TitleLable = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.Button_B = new System.Windows.Forms.Button();
            this.Button_A = new System.Windows.Forms.Button();
            this.Button_C = new System.Windows.Forms.Button();
            this.Button_D = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Tai Le", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.Location = new System.Drawing.Point(19, 23);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(460, 57);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "Question ??/??";
            this.TitleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLable.Click += new System.EventHandler(this.TitleLable_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(17, 145);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(468, 101);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "question...";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_B
            // 
            this.Button_B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_B.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_B.Location = new System.Drawing.Point(19, 461);
            this.Button_B.Name = "Button_B";
            this.Button_B.Size = new System.Drawing.Size(460, 34);
            this.Button_B.TabIndex = 3;
            this.Button_B.Text = "buttonB";
            this.Button_B.UseVisualStyleBackColor = false;
            this.Button_B.Click += new System.EventHandler(this.Button_B_Click);
            // 
            // Button_A
            // 
            this.Button_A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_A.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_A.Location = new System.Drawing.Point(19, 407);
            this.Button_A.Name = "Button_A";
            this.Button_A.Size = new System.Drawing.Size(460, 34);
            this.Button_A.TabIndex = 4;
            this.Button_A.Text = "buttonA";
            this.Button_A.UseVisualStyleBackColor = false;
            this.Button_A.Click += new System.EventHandler(this.Button_A_Click);
            // 
            // Button_C
            // 
            this.Button_C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_C.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_C.Location = new System.Drawing.Point(19, 514);
            this.Button_C.Name = "Button_C";
            this.Button_C.Size = new System.Drawing.Size(460, 34);
            this.Button_C.TabIndex = 5;
            this.Button_C.Text = "buttonC";
            this.Button_C.UseVisualStyleBackColor = false;
            this.Button_C.Click += new System.EventHandler(this.Button_C_Click);
            // 
            // Button_D
            // 
            this.Button_D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_D.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_D.Location = new System.Drawing.Point(19, 569);
            this.Button_D.Name = "Button_D";
            this.Button_D.Size = new System.Drawing.Size(460, 34);
            this.Button_D.TabIndex = 6;
            this.Button_D.Text = "buttonD";
            this.Button_D.UseVisualStyleBackColor = false;
            this.Button_D.Click += new System.EventHandler(this.Button_D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(499, 626);
            this.Controls.Add(this.Button_D);
            this.Controls.Add(this.Button_C);
            this.Controls.Add(this.Button_A);
            this.Controls.Add(this.Button_B);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.TitleLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button Button_B;
        private System.Windows.Forms.Button Button_A;
        private System.Windows.Forms.Button Button_C;
        private System.Windows.Forms.Button Button_D;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

