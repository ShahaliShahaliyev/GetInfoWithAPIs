namespace GetInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cats = new System.Windows.Forms.Button();
            this.btn_bored = new System.Windows.Forms.Button();
            this.btn_joke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cats
            // 
            this.btn_cats.BackColor = System.Drawing.Color.HotPink;
            this.btn_cats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cats.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_cats.ForeColor = System.Drawing.Color.Black;
            this.btn_cats.Location = new System.Drawing.Point(56, 100);
            this.btn_cats.Name = "btn_cats";
            this.btn_cats.Size = new System.Drawing.Size(170, 70);
            this.btn_cats.TabIndex = 1;
            this.btn_cats.Text = "About Cats";
            this.btn_cats.UseVisualStyleBackColor = false;
            this.btn_cats.Click += new System.EventHandler(this.btn_cats_Click);
            // 
            // btn_bored
            // 
            this.btn_bored.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_bored.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_bored.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bored.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_bored.ForeColor = System.Drawing.Color.Black;
            this.btn_bored.Location = new System.Drawing.Point(56, 12);
            this.btn_bored.Name = "btn_bored";
            this.btn_bored.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_bored.Size = new System.Drawing.Size(170, 70);
            this.btn_bored.TabIndex = 0;
            this.btn_bored.Text = "Are you boring?";
            this.btn_bored.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_bored.UseVisualStyleBackColor = false;
            this.btn_bored.Click += new System.EventHandler(this.btn_bored_Click);
            // 
            // btn_joke
            // 
            this.btn_joke.BackColor = System.Drawing.Color.IndianRed;
            this.btn_joke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_joke.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_joke.ForeColor = System.Drawing.Color.Black;
            this.btn_joke.Location = new System.Drawing.Point(56, 195);
            this.btn_joke.Name = "btn_joke";
            this.btn_joke.Size = new System.Drawing.Size(170, 70);
            this.btn_joke.TabIndex = 2;
            this.btn_joke.Text = "Jokes";
            this.btn_joke.UseVisualStyleBackColor = false;
            this.btn_joke.Click += new System.EventHandler(this.btn_joke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(1, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "©Powered by Shahali";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(282, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_joke);
            this.Controls.Add(this.btn_bored);
            this.Controls.Add(this.btn_cats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cats;
        private System.Windows.Forms.Button btn_bored;
        private System.Windows.Forms.Button btn_joke;
        private System.Windows.Forms.Label label1;
    }
}
