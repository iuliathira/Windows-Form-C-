namespace FirstProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.TwitterButton = new System.Windows.Forms.Button();
            this.InstaButton = new System.Windows.Forms.Button();
            this.FacebookButton = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PizzaButton = new System.Windows.Forms.Button();
            this.PastaButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.homeCustomControl1 = new FirstProgram.HomeCustomControl();
            this.firstCustomControl2 = new FirstProgram.FirstCustomControl();
            this.secondCustomControl1 = new FirstProgram.SecondCustomControl();
            this.firstCustomControl1 = new FirstProgram.FirstCustomControl();
            this.LogButton = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Maroon;
            this.Panel1.Controls.Add(this.LogButton);
            this.Panel1.Controls.Add(this.ShutDownButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TwitterButton);
            this.Panel1.Controls.Add(this.InstaButton);
            this.Panel1.Controls.Add(this.FacebookButton);
            this.Panel1.Location = new System.Drawing.Point(186, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1526, 162);
            this.Panel1.TabIndex = 0;
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownButton.ForeColor = System.Drawing.Color.Maroon;
            this.ShutDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ShutDownButton.Image")));
            this.ShutDownButton.Location = new System.Drawing.Point(1429, 7);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(75, 58);
            this.ShutDownButton.TabIndex = 3;
            this.ShutDownButton.UseVisualStyleBackColor = true;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(10, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(277, 50);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Italian Restaurant";
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(3, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(412, 156);
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // TwitterButton
            // 
            this.TwitterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwitterButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitterButton.ForeColor = System.Drawing.Color.Maroon;
            this.TwitterButton.Image = ((System.Drawing.Image)(resources.GetObject("TwitterButton.Image")));
            this.TwitterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TwitterButton.Location = new System.Drawing.Point(773, -2);
            this.TwitterButton.Margin = new System.Windows.Forms.Padding(0);
            this.TwitterButton.Name = "TwitterButton";
            this.TwitterButton.Size = new System.Drawing.Size(47, 61);
            this.TwitterButton.TabIndex = 0;
            this.TwitterButton.Text = "    ";
            this.TwitterButton.UseVisualStyleBackColor = true;
            this.TwitterButton.Click += new System.EventHandler(this.TwitterButton_Click);
            // 
            // InstaButton
            // 
            this.InstaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstaButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstaButton.ForeColor = System.Drawing.Color.Maroon;
            this.InstaButton.Image = ((System.Drawing.Image)(resources.GetObject("InstaButton.Image")));
            this.InstaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstaButton.Location = new System.Drawing.Point(684, -2);
            this.InstaButton.Margin = new System.Windows.Forms.Padding(0);
            this.InstaButton.Name = "InstaButton";
            this.InstaButton.Size = new System.Drawing.Size(45, 61);
            this.InstaButton.TabIndex = 0;
            this.InstaButton.Text = "    ";
            this.InstaButton.UseVisualStyleBackColor = true;
            this.InstaButton.Click += new System.EventHandler(this.InstaButton_Click);
            // 
            // FacebookButton
            // 
            this.FacebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacebookButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacebookButton.ForeColor = System.Drawing.Color.Maroon;
            this.FacebookButton.Image = ((System.Drawing.Image)(resources.GetObject("FacebookButton.Image")));
            this.FacebookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FacebookButton.Location = new System.Drawing.Point(592, -2);
            this.FacebookButton.Margin = new System.Windows.Forms.Padding(0);
            this.FacebookButton.Name = "FacebookButton";
            this.FacebookButton.Size = new System.Drawing.Size(51, 61);
            this.FacebookButton.TabIndex = 0;
            this.FacebookButton.Text = " ";
            this.FacebookButton.UseVisualStyleBackColor = true;
            this.FacebookButton.Click += new System.EventHandler(this.FacebookButton_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Maroon;
            this.Panel2.Controls.Add(this.PizzaButton);
            this.Panel2.Controls.Add(this.PastaButton);
            this.Panel2.Controls.Add(this.LogoPicture);
            this.Panel2.Controls.Add(this.HomeButton);
            this.Panel2.Location = new System.Drawing.Point(-3, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(193, 809);
            this.Panel2.TabIndex = 1;
            // 
            // PizzaButton
            // 
            this.PizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PizzaButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PizzaButton.Image = ((System.Drawing.Image)(resources.GetObject("PizzaButton.Image")));
            this.PizzaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PizzaButton.Location = new System.Drawing.Point(15, 284);
            this.PizzaButton.Margin = new System.Windows.Forms.Padding(0);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(178, 61);
            this.PizzaButton.TabIndex = 0;
            this.PizzaButton.Text = "    Pizza";
            this.PizzaButton.UseVisualStyleBackColor = true;
            this.PizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // PastaButton
            // 
            this.PastaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PastaButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PastaButton.Image = ((System.Drawing.Image)(resources.GetObject("PastaButton.Image")));
            this.PastaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PastaButton.Location = new System.Drawing.Point(15, 405);
            this.PastaButton.Margin = new System.Windows.Forms.Padding(0);
            this.PastaButton.Name = "PastaButton";
            this.PastaButton.Size = new System.Drawing.Size(178, 61);
            this.PastaButton.TabIndex = 0;
            this.PastaButton.Text = "    Pasta";
            this.PastaButton.UseVisualStyleBackColor = true;
            this.PastaButton.Click += new System.EventHandler(this.PastaButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(12, 163);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(178, 61);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "    Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // homeCustomControl1
            // 
            this.homeCustomControl1.Location = new System.Drawing.Point(190, 164);
            this.homeCustomControl1.Name = "homeCustomControl1";
            this.homeCustomControl1.Size = new System.Drawing.Size(1522, 643);
            this.homeCustomControl1.TabIndex = 4;
            // 
            // firstCustomControl2
            // 
            this.firstCustomControl2.Location = new System.Drawing.Point(189, 164);
            this.firstCustomControl2.Name = "firstCustomControl2";
            this.firstCustomControl2.Size = new System.Drawing.Size(1522, 643);
            this.firstCustomControl2.TabIndex = 2;
            // 
            // secondCustomControl1
            // 
            this.secondCustomControl1.Location = new System.Drawing.Point(190, 164);
            this.secondCustomControl1.Name = "secondCustomControl1";
            this.secondCustomControl1.Size = new System.Drawing.Size(1522, 643);
            this.secondCustomControl1.TabIndex = 3;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(190, 164);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(1522, 643);
            this.firstCustomControl1.TabIndex = 2;
            // 
            // LogButton
            // 
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.ForeColor = System.Drawing.Color.Maroon;
            this.LogButton.Image = ((System.Drawing.Image)(resources.GetObject("LogButton.Image")));
            this.LogButton.Location = new System.Drawing.Point(1348, 12);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 49);
            this.LogButton.TabIndex = 4;
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 809);
            this.Controls.Add(this.homeCustomControl1);
            this.Controls.Add(this.firstCustomControl2);
            this.Controls.Add(this.secondCustomControl1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button PizzaButton;
        private System.Windows.Forms.Button PastaButton;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button TwitterButton;
        private System.Windows.Forms.Button InstaButton;
        private System.Windows.Forms.Button FacebookButton;
        private FirstCustomControl firstCustomControl1;
        private FirstCustomControl firstCustomControl2;
        private SecondCustomControl secondCustomControl1;
        private HomeCustomControl homeCustomControl1;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Button LogButton;
    }
}

