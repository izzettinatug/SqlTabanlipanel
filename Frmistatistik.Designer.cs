
using System;

namespace personel_kayit
{
    partial class Frmistatistik
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblToplamPersonel = new System.Windows.Forms.Label();
            this.LblEvli = new System.Windows.Forms.Label();
            this.LblBekar = new System.Windows.Forms.Label();
            this.LblSehir = new System.Windows.Forms.Label();
            this.LblToplamMaas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Sayısı:";
            // 
            // LblToplamPersonel
            // 
            this.LblToplamPersonel.AutoSize = true;
            this.LblToplamPersonel.Location = new System.Drawing.Point(329, 57);
            this.LblToplamPersonel.Name = "LblToplamPersonel";
            this.LblToplamPersonel.Size = new System.Drawing.Size(25, 29);
            this.LblToplamPersonel.TabIndex = 4;
            this.LblToplamPersonel.Text = "0";
            // 
            // LblEvli
            // 
            this.LblEvli.AutoSize = true;
            this.LblEvli.Location = new System.Drawing.Point(329, 101);
            this.LblEvli.Name = "LblEvli";
            this.LblEvli.Size = new System.Drawing.Size(25, 29);
            this.LblEvli.TabIndex = 5;
            this.LblEvli.Text = "0";
            this.LblEvli.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblBekar
            // 
            this.LblBekar.AutoSize = true;
            this.LblBekar.Location = new System.Drawing.Point(330, 154);
            this.LblBekar.Name = "LblBekar";
            this.LblBekar.Size = new System.Drawing.Size(25, 29);
            this.LblBekar.TabIndex = 6;
            this.LblBekar.Text = "0";
            // 
            // LblSehir
            // 
            this.LblSehir.AutoSize = true;
            this.LblSehir.Location = new System.Drawing.Point(328, 203);
            this.LblSehir.Name = "LblSehir";
            this.LblSehir.Size = new System.Drawing.Size(25, 29);
            this.LblSehir.TabIndex = 7;
            this.LblSehir.Text = "0";
            // 
            // LblToplamMaas
            // 
            this.LblToplamMaas.AutoSize = true;
            this.LblToplamMaas.Location = new System.Drawing.Point(328, 244);
            this.LblToplamMaas.Name = "LblToplamMaas";
            this.LblToplamMaas.Size = new System.Drawing.Size(25, 29);
            this.LblToplamMaas.TabIndex = 9;
            this.LblToplamMaas.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Maaş:";
            // 
            // Frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.LblToplamMaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblSehir);
            this.Controls.Add(this.LblBekar);
            this.Controls.Add(this.LblEvli);
            this.Controls.Add(this.LblToplamPersonel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmistatistik";
            this.Text = "Frmistatistik";
            this.Load += new System.EventHandler(this.Frmistatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblToplamPersonel;
        private System.Windows.Forms.Label LblEvli;
        private System.Windows.Forms.Label LblBekar;
        private System.Windows.Forms.Label LblSehir;
        private EventHandler label7_Click;
        private System.Windows.Forms.Label LblToplamMaas;
        private System.Windows.Forms.Label label10;
    }
}