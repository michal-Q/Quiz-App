namespace Quiz_App
{
    partial class MenuPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.EndLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionsButton
            // 
            this.QuestionsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.QuestionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuestionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsButton.Location = new System.Drawing.Point(20, 460);
            this.QuestionsButton.Name = "QuestionsButton";
            this.QuestionsButton.Size = new System.Drawing.Size(458, 63);
            this.QuestionsButton.TabIndex = 12;
            this.QuestionsButton.Text = "Questions";
            this.QuestionsButton.UseVisualStyleBackColor = false;
            this.QuestionsButton.Click += new System.EventHandler(this.QuestionsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(20, 543);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(458, 63);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(20, 377);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(458, 63);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EndLabel
            // 
            this.EndLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLabel.Location = new System.Drawing.Point(20, 58);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(460, 115);
            this.EndLabel.TabIndex = 9;
            this.EndLabel.Text = "Quiz App";
            this.EndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.QuestionsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EndLabel);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(500, 665);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuestionsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label EndLabel;
    }
}
