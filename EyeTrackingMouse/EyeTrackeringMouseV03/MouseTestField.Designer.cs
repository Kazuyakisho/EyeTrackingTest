namespace EyeTrackeringMouseV03
{
    partial class MouseTestField
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
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.MinimumSize = new System.Drawing.Size(120, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 120);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(9, 550);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(530, 17);
            this.hScrollBar1.TabIndex = 26;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(91, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 144);
            this.vScrollBar1.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plLabel);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(55, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 144);
            this.panel1.TabIndex = 28;
            // 
            // plLabel
            // 
            this.plLabel.AutoSize = true;
            this.plLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.plLabel.Location = new System.Drawing.Point(17, 23);
            this.plLabel.MinimumSize = new System.Drawing.Size(50, 50);
            this.plLabel.Name = "plLabel";
            this.plLabel.Size = new System.Drawing.Size(50, 50);
            this.plLabel.TabIndex = 28;
            // 
            // MouseTestField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label1);
            this.Name = "MouseTestField";
            this.Text = "MouseTestField";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label plLabel;
    }
}