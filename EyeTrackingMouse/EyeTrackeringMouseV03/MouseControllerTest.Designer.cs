namespace MouseControllerTest
{
    partial class MouseControllerTest
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
            this.CommandsBox = new System.Windows.Forms.ListBox();
            this.ExecutionBox = new System.Windows.Forms.ListBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommandsBox
            // 
            this.CommandsBox.FormattingEnabled = true;
            this.CommandsBox.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right",
            "LeftClick",
            "LeftUp",
            "LeftDown",
            "RightClick",
            "RightUp",
            "RightDown",
            "WheelUp",
            "WheelDown"});
            this.CommandsBox.Location = new System.Drawing.Point(13, 13);
            this.CommandsBox.Name = "CommandsBox";
            this.CommandsBox.Size = new System.Drawing.Size(107, 160);
            this.CommandsBox.TabIndex = 0;
            // 
            // ExecutionBox
            // 
            this.ExecutionBox.FormattingEnabled = true;
            this.ExecutionBox.Location = new System.Drawing.Point(161, 13);
            this.ExecutionBox.Name = "ExecutionBox";
            this.ExecutionBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ExecutionBox.Size = new System.Drawing.Size(111, 160);
            this.ExecutionBox.TabIndex = 1;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(127, 54);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(28, 28);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = ">";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(127, 93);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "<";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(13, 180);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(259, 23);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // MouseControllerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ExecutionBox);
            this.Controls.Add(this.CommandsBox);
            this.Name = "MouseControllerTest";
            this.Text = "MouseControllerTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CommandsBox;
        private System.Windows.Forms.ListBox ExecutionBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExecuteButton;
    }
}