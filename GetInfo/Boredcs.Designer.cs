namespace GetInfo
{
    partial class Boredcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boredcs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_type = new System.Windows.Forms.TextBox();
            this.rtb_activity = new System.Windows.Forms.RichTextBox();
            this.btn_GetActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activity Type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Activity";
            // 
            // tbx_type
            // 
            this.tbx_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_type.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_type.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tbx_type.Location = new System.Drawing.Point(148, 12);
            this.tbx_type.Name = "tbx_type";
            this.tbx_type.ReadOnly = true;
            this.tbx_type.Size = new System.Drawing.Size(640, 33);
            this.tbx_type.TabIndex = 0;
            // 
            // rtb_activity
            // 
            this.rtb_activity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_activity.BackColor = System.Drawing.Color.LightSalmon;
            this.rtb_activity.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtb_activity.Location = new System.Drawing.Point(148, 93);
            this.rtb_activity.Name = "rtb_activity";
            this.rtb_activity.ReadOnly = true;
            this.rtb_activity.Size = new System.Drawing.Size(640, 96);
            this.rtb_activity.TabIndex = 1;
            this.rtb_activity.Text = "";
            // 
            // btn_GetActivity
            // 
            this.btn_GetActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetActivity.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_GetActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GetActivity.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_GetActivity.Location = new System.Drawing.Point(368, 244);
            this.btn_GetActivity.Name = "btn_GetActivity";
            this.btn_GetActivity.Size = new System.Drawing.Size(169, 46);
            this.btn_GetActivity.TabIndex = 2;
            this.btn_GetActivity.Text = "SEARCH";
            this.btn_GetActivity.UseVisualStyleBackColor = false;
            this.btn_GetActivity.Click += new System.EventHandler(this.btn_GetActivity_Click);
            // 
            // Boredcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.btn_GetActivity);
            this.Controls.Add(this.rtb_activity);
            this.Controls.Add(this.tbx_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Boredcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boredcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_type;
        private System.Windows.Forms.RichTextBox rtb_activity;
        private System.Windows.Forms.Button btn_GetActivity;
    }
}