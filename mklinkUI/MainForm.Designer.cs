namespace mklinkUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.srcGroup = new System.Windows.Forms.GroupBox();
            this.srcButton = new System.Windows.Forms.Button();
            this.srcText = new System.Windows.Forms.TextBox();
            this.dstGroup = new System.Windows.Forms.GroupBox();
            this.dstButton = new System.Windows.Forms.Button();
            this.dstText = new System.Windows.Forms.TextBox();
            this.mkButton = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.srcGroup.SuspendLayout();
            this.dstGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcGroup
            // 
            this.srcGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcGroup.Controls.Add(this.srcButton);
            this.srcGroup.Controls.Add(this.srcText);
            this.srcGroup.Location = new System.Drawing.Point(13, 13);
            this.srcGroup.Name = "srcGroup";
            this.srcGroup.Size = new System.Drawing.Size(507, 48);
            this.srcGroup.TabIndex = 0;
            this.srcGroup.TabStop = false;
            this.srcGroup.Text = "Source (where the application is installed)";
            // 
            // srcButton
            // 
            this.srcButton.Location = new System.Drawing.Point(407, 19);
            this.srcButton.Name = "srcButton";
            this.srcButton.Size = new System.Drawing.Size(75, 23);
            this.srcButton.TabIndex = 1;
            this.srcButton.Text = "Browse...";
            this.srcButton.UseVisualStyleBackColor = true;
            this.srcButton.Click += new System.EventHandler(this.srcButton_Click);
            // 
            // srcText
            // 
            this.srcText.Location = new System.Drawing.Point(6, 19);
            this.srcText.Name = "srcText";
            this.srcText.ReadOnly = true;
            this.srcText.Size = new System.Drawing.Size(394, 20);
            this.srcText.TabIndex = 0;
            // 
            // dstGroup
            // 
            this.dstGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dstGroup.Controls.Add(this.dstButton);
            this.dstGroup.Controls.Add(this.dstText);
            this.dstGroup.Location = new System.Drawing.Point(13, 67);
            this.dstGroup.Name = "dstGroup";
            this.dstGroup.Size = new System.Drawing.Size(507, 51);
            this.dstGroup.TabIndex = 1;
            this.dstGroup.TabStop = false;
            this.dstGroup.Text = "Destination (where you want it to be moved)";
            // 
            // dstButton
            // 
            this.dstButton.Location = new System.Drawing.Point(407, 19);
            this.dstButton.Name = "dstButton";
            this.dstButton.Size = new System.Drawing.Size(75, 23);
            this.dstButton.TabIndex = 2;
            this.dstButton.Text = "Browse...";
            this.dstButton.UseVisualStyleBackColor = true;
            this.dstButton.Click += new System.EventHandler(this.dstButton_Click);
            // 
            // dstText
            // 
            this.dstText.Location = new System.Drawing.Point(6, 19);
            this.dstText.Name = "dstText";
            this.dstText.ReadOnly = true;
            this.dstText.Size = new System.Drawing.Size(394, 20);
            this.dstText.TabIndex = 1;
            // 
            // mkButton
            // 
            this.mkButton.Location = new System.Drawing.Point(13, 133);
            this.mkButton.Name = "mkButton";
            this.mkButton.Size = new System.Drawing.Size(136, 23);
            this.mkButton.TabIndex = 2;
            this.mkButton.Text = "Move && Create Link";
            this.mkButton.UseVisualStyleBackColor = true;
            this.mkButton.Click += new System.EventHandler(this.mkButton_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(166, 133);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(354, 23);
            this.progress.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 194);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(2, 199);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/EClaesson/mklinkUI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 216);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.mkButton);
            this.Controls.Add(this.dstGroup);
            this.Controls.Add(this.srcGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "mklinkUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.srcGroup.ResumeLayout(false);
            this.srcGroup.PerformLayout();
            this.dstGroup.ResumeLayout(false);
            this.dstGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox srcGroup;
        private System.Windows.Forms.Button srcButton;
        private System.Windows.Forms.TextBox srcText;
        private System.Windows.Forms.GroupBox dstGroup;
        private System.Windows.Forms.Button dstButton;
        private System.Windows.Forms.TextBox dstText;
        private System.Windows.Forms.Button mkButton;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

