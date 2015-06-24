namespace GeneratorTwierdzen
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
            this.tytul = new System.Windows.Forms.Label();
            this.tresc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Otwórz formularz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wypełnij prosty formularz i poznaj zagadnienie matematyczne, którego będzie dotyc" +
    "zyć Twoja praca magisterska!";
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Location = new System.Drawing.Point(158, 110);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(0, 13);
            this.tytul.TabIndex = 2;
            // 
            // tresc
            // 
            this.tresc.AutoSize = true;
            this.tresc.Location = new System.Drawing.Point(149, 127);
            this.tresc.Name = "tresc";
            this.tresc.Size = new System.Drawing.Size(0, 13);
            this.tresc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 179);
            this.Controls.Add(this.tresc);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator Twierdzeń";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label tresc;
    }
}

