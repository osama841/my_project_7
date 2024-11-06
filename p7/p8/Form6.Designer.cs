namespace p8
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.جمعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طرحToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ضربToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قسمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قسمةToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.االملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "جمع ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "طرح";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "ضرب";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(189, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "قسمة";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جمعToolStripMenuItem,
            this.االملفToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // جمعToolStripMenuItem
            // 
            this.جمعToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طرحToolStripMenuItem,
            this.ضربToolStripMenuItem,
            this.قسمةToolStripMenuItem,
            this.قسمةToolStripMenuItem1});
            this.جمعToolStripMenuItem.Name = "جمعToolStripMenuItem";
            this.جمعToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.جمعToolStripMenuItem.Text = "المعلومات";
            // 
            // طرحToolStripMenuItem
            // 
            this.طرحToolStripMenuItem.Name = "طرحToolStripMenuItem";
            this.طرحToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.طرحToolStripMenuItem.Text = "جمع";
            this.طرحToolStripMenuItem.Click += new System.EventHandler(this.طرحToolStripMenuItem_Click);
            // 
            // ضربToolStripMenuItem
            // 
            this.ضربToolStripMenuItem.Name = "ضربToolStripMenuItem";
            this.ضربToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ضربToolStripMenuItem.Text = "طرح";
            this.ضربToolStripMenuItem.Click += new System.EventHandler(this.ضربToolStripMenuItem_Click);
            // 
            // قسمةToolStripMenuItem
            // 
            this.قسمةToolStripMenuItem.Name = "قسمةToolStripMenuItem";
            this.قسمةToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.قسمةToolStripMenuItem.Text = "ضرب";
            this.قسمةToolStripMenuItem.Click += new System.EventHandler(this.قسمةToolStripMenuItem_Click);
            // 
            // قسمةToolStripMenuItem1
            // 
            this.قسمةToolStripMenuItem1.Name = "قسمةToolStripMenuItem1";
            this.قسمةToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.قسمةToolStripMenuItem1.Text = "قسمة";
            this.قسمةToolStripMenuItem1.Click += new System.EventHandler(this.قسمةToolStripMenuItem1_Click);
            // 
            // االملفToolStripMenuItem
            // 
            this.االملفToolStripMenuItem.Name = "االملفToolStripMenuItem";
            this.االملفToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.االملفToolStripMenuItem.Text = "الملف";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 486);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "Form6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem جمعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طرحToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ضربToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قسمةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قسمةToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem االملفToolStripMenuItem;
    }
}