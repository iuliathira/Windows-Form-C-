namespace FirstProgram
{
    partial class Sign
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox1 = new System.Windows.Forms.TextBox();
            this.PassTextBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.CREATEButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(356, 137);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // UserTextBox1
            // 
            this.UserTextBox1.Location = new System.Drawing.Point(356, 213);
            this.UserTextBox1.Name = "UserTextBox1";
            this.UserTextBox1.Size = new System.Drawing.Size(100, 22);
            this.UserTextBox1.TabIndex = 0;
            // 
            // PassTextBox1
            // 
            this.PassTextBox1.Location = new System.Drawing.Point(356, 297);
            this.PassTextBox1.Name = "PassTextBox1";
            this.PassTextBox1.Size = new System.Drawing.Size(100, 22);
            this.PassTextBox1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(313, 38);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "CREATE AN ACCOUNT";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(155, 139);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(141, 20);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "NAME(optional)";
            this.LabelName.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // CREATEButton
            // 
            this.CREATEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CREATEButton.Location = new System.Drawing.Point(211, 404);
            this.CREATEButton.Name = "CREATEButton";
            this.CREATEButton.Size = new System.Drawing.Size(208, 39);
            this.CREATEButton.TabIndex = 2;
            this.CREATEButton.Text = "Create";
            this.CREATEButton.UseVisualStyleBackColor = true;
            this.CREATEButton.Click += new System.EventHandler(this.CREATEButton_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 512);
            this.Controls.Add(this.CREATEButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PassTextBox1);
            this.Controls.Add(this.UserTextBox1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Sign";
            this.Text = "Sign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox UserTextBox1;
        private System.Windows.Forms.TextBox PassTextBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button CREATEButton;
    }
}