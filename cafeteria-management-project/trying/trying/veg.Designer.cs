namespace trying
{
    partial class veg
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.salad = new System.Windows.Forms.Button();
            this.sandwitch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.frice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(575, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(36, 31);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(825, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(36, 31);
            this.textBox2.TabIndex = 9;
            // 
            // salad
            // 
            this.salad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salad.Location = new System.Drawing.Point(392, 87);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(230, 71);
            this.salad.TabIndex = 6;
            this.salad.Text = "salad   rs.80/-";
            this.salad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salad.UseVisualStyleBackColor = true;
            this.salad.Click += new System.EventHandler(this.salad_Click);
            // 
            // sandwitch
            // 
            this.sandwitch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sandwitch.Location = new System.Drawing.Point(642, 87);
            this.sandwitch.Name = "sandwitch";
            this.sandwitch.Size = new System.Drawing.Size(230, 71);
            this.sandwitch.TabIndex = 7;
            this.sandwitch.Text = "samdwitch    rs.90/-";
            this.sandwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sandwitch.UseVisualStyleBackColor = true;
            this.sandwitch.Click += new System.EventHandler(this.sandwitch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(36, 31);
            this.textBox1.TabIndex = 5;
            // 
            // frice
            // 
            this.frice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frice.Location = new System.Drawing.Point(120, 87);
            this.frice.Name = "frice";
            this.frice.Size = new System.Drawing.Size(230, 71);
            this.frice.TabIndex = 4;
            this.frice.Text = "fried rice      rs.90/-";
            this.frice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frice.UseVisualStyleBackColor = true;
            this.frice.Click += new System.EventHandler(this.frice_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(403, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // veg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 907);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.salad);
            this.Controls.Add(this.sandwitch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frice);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "veg";
            this.Text = "veg";
            this.Load += new System.EventHandler(this.veg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private Button salad;
        private Button sandwitch;
        private TextBox textBox1;
        private Button frice;
        private Button button1;
    }
}