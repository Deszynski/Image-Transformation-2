
namespace Grafika_Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.his1 = new System.Windows.Forms.Panel();
            this.his2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.filter1 = new System.Windows.Forms.PictureBox();
            this.filter2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.suwakA = new System.Windows.Forms.TrackBar();
            this.suwakB = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suwakA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suwakB)).BeginInit();
            this.SuspendLayout();
            // 
            // his1
            // 
            this.his1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.his1.Location = new System.Drawing.Point(687, 140);
            this.his1.Name = "his1";
            this.his1.Size = new System.Drawing.Size(311, 198);
            this.his1.TabIndex = 0;
            // 
            // his2
            // 
            this.his2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.his2.Location = new System.Drawing.Point(1019, 140);
            this.his2.Name = "his2";
            this.his2.Size = new System.Drawing.Size(311, 198);
            this.his2.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(32, 140);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(628, 437);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // filter1
            // 
            this.filter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filter1.Location = new System.Drawing.Point(687, 379);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(311, 198);
            this.filter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filter1.TabIndex = 2;
            this.filter1.TabStop = false;
            // 
            // filter2
            // 
            this.filter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filter2.Location = new System.Drawing.Point(1019, 379);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(311, 198);
            this.filter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filter2.TabIndex = 3;
            this.filter2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "histogram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1105, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "histogram po zmianie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "filtr uśredniający";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1141, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "filtr Gaussa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Załaduj obraz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1124, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // suwakA
            // 
            this.suwakA.Location = new System.Drawing.Point(133, 649);
            this.suwakA.Name = "suwakA";
            this.suwakA.Size = new System.Drawing.Size(138, 56);
            this.suwakA.TabIndex = 11;
            this.suwakA.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // suwakB
            // 
            this.suwakB.Location = new System.Drawing.Point(407, 649);
            this.suwakB.Name = "suwakB";
            this.suwakB.Size = new System.Drawing.Size(138, 56);
            this.suwakB.TabIndex = 12;
            this.suwakB.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "zakres skalowania A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "zakres skalowania B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 767);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.suwakB);
            this.Controls.Add(this.suwakA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter2);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.his2);
            this.Controls.Add(this.his1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suwakA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suwakB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel his1;
        private System.Windows.Forms.Panel his2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox filter1;
        private System.Windows.Forms.PictureBox filter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar suwakA;
        private System.Windows.Forms.TrackBar suwakB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

