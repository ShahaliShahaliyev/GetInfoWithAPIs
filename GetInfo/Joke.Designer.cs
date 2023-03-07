namespace GetInfo
{
    partial class Joke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joke));
            this.type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_type = new System.Windows.Forms.TextBox();
            this.rtb_jokeSetub = new System.Windows.Forms.RichTextBox();
            this.rtb_punchline = new System.Windows.Forms.RichTextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.type.Location = new System.Drawing.Point(5, 5);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(56, 25);
            this.type.TabIndex = 5;
            this.type.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Setup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Punchline";
            // 
            // tbx_type
            // 
            this.tbx_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_type.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbx_type.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tbx_type.Location = new System.Drawing.Point(116, 5);
            this.tbx_type.Name = "tbx_type";
            this.tbx_type.ReadOnly = true;
            this.tbx_type.Size = new System.Drawing.Size(672, 33);
            this.tbx_type.TabIndex = 1;
            // 
            // rtb_jokeSetub
            // 
            this.rtb_jokeSetub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_jokeSetub.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtb_jokeSetub.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtb_jokeSetub.Location = new System.Drawing.Point(116, 69);
            this.rtb_jokeSetub.Name = "rtb_jokeSetub";
            this.rtb_jokeSetub.ReadOnly = true;
            this.rtb_jokeSetub.Size = new System.Drawing.Size(672, 96);
            this.rtb_jokeSetub.TabIndex = 2;
            this.rtb_jokeSetub.Text = "";
            this.rtb_jokeSetub.TextChanged += new System.EventHandler(this.rtb_jokeSetub_TextChanged);
            // 
            // rtb_punchline
            // 
            this.rtb_punchline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_punchline.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtb_punchline.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtb_punchline.Location = new System.Drawing.Point(116, 186);
            this.rtb_punchline.Name = "rtb_punchline";
            this.rtb_punchline.ReadOnly = true;
            this.rtb_punchline.Size = new System.Drawing.Size(672, 96);
            this.rtb_punchline.TabIndex = 3;
            this.rtb_punchline.Text = "";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(342, 301);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(149, 47);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Joke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rtb_punchline);
            this.Controls.Add(this.rtb_jokeSetub);
            this.Controls.Add(this.tbx_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Name = "Joke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_type;
        private System.Windows.Forms.RichTextBox rtb_jokeSetub;
        private System.Windows.Forms.RichTextBox rtb_punchline;
        private System.Windows.Forms.Button btn_search;
    }
}