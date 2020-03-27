namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x1_box = new System.Windows.Forms.TextBox();
            this.x2_box = new System.Windows.Forms.TextBox();
            this.wynik_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "zadanie 3 C# Patryk-Krawczak";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // x1_box
            // 
            this.x1_box.Location = new System.Drawing.Point(40, 148);
            this.x1_box.Name = "x1_box";
            this.x1_box.Size = new System.Drawing.Size(136, 26);
            this.x1_box.TabIndex = 2;
            // 
            // x2_box
            // 
            this.x2_box.Location = new System.Drawing.Point(40, 228);
            this.x2_box.Name = "x2_box";
            this.x2_box.Size = new System.Drawing.Size(136, 26);
            this.x2_box.TabIndex = 3;
            this.x2_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // wynik_box
            // 
            this.wynik_box.Location = new System.Drawing.Point(253, 76);
            this.wynik_box.Multiline = true;
            this.wynik_box.Name = "wynik_box";
            this.wynik_box.Size = new System.Drawing.Size(504, 202);
            this.wynik_box.TabIndex = 4;
            this.wynik_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "x2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wynik_box);
            this.Controls.Add(this.x2_box);
            this.Controls.Add(this.x1_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x1_box;
        private System.Windows.Forms.TextBox x2_box;
        private System.Windows.Forms.TextBox wynik_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

