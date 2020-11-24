namespace Play_Game
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.Number3 = new System.Windows.Forms.Label();
            this.Number4 = new System.Windows.Forms.Label();
            this.GoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.AllowDrop = true;
            this.PlayButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlayButton.Location = new System.Drawing.Point(265, 23);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(191, 109);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Begin Game";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Countdown.Location = new System.Drawing.Point(63, 267);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(393, 50);
            this.Countdown.TabIndex = 2;
            this.Countdown.Text = "Game Will Start In...";
            this.Countdown.Click += new System.EventHandler(this.Countdown_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Number.Location = new System.Drawing.Point(444, 267);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(45, 50);
            this.Number.TabIndex = 3;
            this.Number.Text = "3";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Number2.Location = new System.Drawing.Point(495, 267);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(45, 50);
            this.Number2.TabIndex = 4;
            this.Number2.Text = "2";
            // 
            // Number3
            // 
            this.Number3.AutoSize = true;
            this.Number3.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number3.Location = new System.Drawing.Point(1341, 533);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(45, 50);
            this.Number3.TabIndex = 5;
            this.Number3.Text = "1";
            // 
            // Number4
            // 
            this.Number4.AutoSize = true;
            this.Number4.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Number4.Location = new System.Drawing.Point(546, 267);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(45, 50);
            this.Number4.TabIndex = 6;
            this.Number4.Text = "1";
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // GoLabel
            // 
            this.GoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GoLabel.Location = new System.Drawing.Point(495, 326);
            this.GoLabel.Name = "GoLabel";
            this.GoLabel.Size = new System.Drawing.Size(181, 89);
            this.GoLabel.TabIndex = 7;
            this.GoLabel.Text = "GO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoLabel);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.PlayButton);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label Number3;
        private System.Windows.Forms.Label Number4;
        private System.Windows.Forms.Label GoLabel;
    }
}

