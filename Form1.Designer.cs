namespace WindowsFormsApp1
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
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(90, 12);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(96, 94);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.A00_Click);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(90, 113);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(96, 94);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.A00_Click);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(90, 213);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(96, 94);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.A00_Click);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(192, 213);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(96, 94);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.A00_Click);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(192, 113);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(96, 94);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.A00_Click);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(192, 13);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(96, 94);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.A00_Click);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(294, 213);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(96, 94);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.A00_Click);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(294, 113);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(96, 94);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.A00_Click);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(294, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(96, 94);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.A00_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(494, 13);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(100, 59);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            this.XWin.Click += new System.EventHandler(this.XWin_Click);
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(494, 113);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(100, 60);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            this.OWin.Click += new System.EventHandler(this.label2_Click);
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(494, 203);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(100, 65);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
    }
}

