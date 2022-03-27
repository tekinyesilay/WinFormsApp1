namespace WinFormsApp3.admin
{
    partial class frmBook
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
            this.frmbooknamel = new System.Windows.Forms.Label();
            this.frmbookauthorl = new System.Windows.Forms.Label();
            this.frmbookpagel = new System.Windows.Forms.Label();
            this.frmbookpricel = new System.Windows.Forms.Label();
            this.frmbookpublisherl = new System.Windows.Forms.Label();
            this.frmbookyearl = new System.Windows.Forms.Label();
            this.frmbookexpl = new System.Windows.Forms.Label();
            this.frmbooknamet = new System.Windows.Forms.TextBox();
            this.frmbookauthort = new System.Windows.Forms.TextBox();
            this.frmbookpaget = new System.Windows.Forms.TextBox();
            this.frmbookyeart = new System.Windows.Forms.TextBox();
            this.frmbookpublishert = new System.Windows.Forms.TextBox();
            this.frmbookpricet = new System.Windows.Forms.TextBox();
            this.frmbookexpt = new System.Windows.Forms.RichTextBox();
            this.FrmBookSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmbooknamel
            // 
            this.frmbooknamel.AutoSize = true;
            this.frmbooknamel.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbooknamel.Location = new System.Drawing.Point(214, 60);
            this.frmbooknamel.Name = "frmbooknamel";
            this.frmbooknamel.Size = new System.Drawing.Size(106, 26);
            this.frmbooknamel.TabIndex = 0;
            this.frmbooknamel.Text = "Kitap Adı:";
            // 
            // frmbookauthorl
            // 
            this.frmbookauthorl.AutoSize = true;
            this.frmbookauthorl.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbookauthorl.Location = new System.Drawing.Point(241, 110);
            this.frmbookauthorl.Name = "frmbookauthorl";
            this.frmbookauthorl.Size = new System.Drawing.Size(79, 26);
            this.frmbookauthorl.TabIndex = 1;
            this.frmbookauthorl.Text = "Yazarı:";
            // 
            // frmbookpagel
            // 
            this.frmbookpagel.AutoSize = true;
            this.frmbookpagel.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbookpagel.Location = new System.Drawing.Point(179, 164);
            this.frmbookpagel.Name = "frmbookpagel";
            this.frmbookpagel.Size = new System.Drawing.Size(141, 26);
            this.frmbookpagel.TabIndex = 3;
            this.frmbookpagel.Text = "Sayfa Sayısı:";
            // 
            // frmbookpricel
            // 
            this.frmbookpricel.AutoSize = true;
            this.frmbookpricel.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbookpricel.Location = new System.Drawing.Point(255, 220);
            this.frmbookpricel.Name = "frmbookpricel";
            this.frmbookpricel.Size = new System.Drawing.Size(65, 26);
            this.frmbookpricel.TabIndex = 2;
            this.frmbookpricel.Text = "Fiyat:";
            // 
            // frmbookpublisherl
            // 
            this.frmbookpublisherl.AutoSize = true;
            this.frmbookpublisherl.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbookpublisherl.Location = new System.Drawing.Point(220, 270);
            this.frmbookpublisherl.Name = "frmbookpublisherl";
            this.frmbookpublisherl.Size = new System.Drawing.Size(100, 26);
            this.frmbookpublisherl.TabIndex = 5;
            this.frmbookpublisherl.Text = "Yayınevi:";
            // 
            // frmbookyearl
            // 
            this.frmbookyearl.AutoSize = true;
            this.frmbookyearl.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbookyearl.Location = new System.Drawing.Point(202, 321);
            this.frmbookyearl.Name = "frmbookyearl";
            this.frmbookyearl.Size = new System.Drawing.Size(118, 26);
            this.frmbookyearl.TabIndex = 4;
            this.frmbookyearl.Text = "Basım Yılı:";
            // 
            // frmbookexpl
            // 
            this.frmbookexpl.AutoSize = true;
            this.frmbookexpl.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmbookexpl.Location = new System.Drawing.Point(212, 376);
            this.frmbookexpl.Name = "frmbookexpl";
            this.frmbookexpl.Size = new System.Drawing.Size(108, 26);
            this.frmbookexpl.TabIndex = 6;
            this.frmbookexpl.Text = "Açıklama:";
            // 
            // frmbooknamet
            // 
            this.frmbooknamet.Location = new System.Drawing.Point(327, 54);
            this.frmbooknamet.Name = "frmbooknamet";
            this.frmbooknamet.Size = new System.Drawing.Size(378, 31);
            this.frmbooknamet.TabIndex = 7;
            // 
            // frmbookauthort
            // 
            this.frmbookauthort.Location = new System.Drawing.Point(327, 104);
            this.frmbookauthort.Name = "frmbookauthort";
            this.frmbookauthort.Size = new System.Drawing.Size(378, 31);
            this.frmbookauthort.TabIndex = 8;
            // 
            // frmbookpaget
            // 
            this.frmbookpaget.Location = new System.Drawing.Point(327, 158);
            this.frmbookpaget.Name = "frmbookpaget";
            this.frmbookpaget.Size = new System.Drawing.Size(378, 31);
            this.frmbookpaget.TabIndex = 9;
            // 
            // frmbookyeart
            // 
            this.frmbookyeart.Location = new System.Drawing.Point(327, 318);
            this.frmbookyeart.Name = "frmbookyeart";
            this.frmbookyeart.Size = new System.Drawing.Size(378, 31);
            this.frmbookyeart.TabIndex = 15;
            // 
            // frmbookpublishert
            // 
            this.frmbookpublishert.Location = new System.Drawing.Point(327, 264);
            this.frmbookpublishert.Name = "frmbookpublishert";
            this.frmbookpublishert.Size = new System.Drawing.Size(378, 31);
            this.frmbookpublishert.TabIndex = 14;
            // 
            // frmbookpricet
            // 
            this.frmbookpricet.Location = new System.Drawing.Point(327, 214);
            this.frmbookpricet.Name = "frmbookpricet";
            this.frmbookpricet.Size = new System.Drawing.Size(378, 31);
            this.frmbookpricet.TabIndex = 13;
            // 
            // frmbookexpt
            // 
            this.frmbookexpt.Location = new System.Drawing.Point(327, 373);
            this.frmbookexpt.Name = "frmbookexpt";
            this.frmbookexpt.Size = new System.Drawing.Size(378, 193);
            this.frmbookexpt.TabIndex = 16;
            this.frmbookexpt.Text = "";
            // 
            // FrmBookSave
            // 
            this.FrmBookSave.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrmBookSave.Location = new System.Drawing.Point(404, 572);
            this.FrmBookSave.Name = "FrmBookSave";
            this.FrmBookSave.Size = new System.Drawing.Size(202, 51);
            this.FrmBookSave.TabIndex = 17;
            this.FrmBookSave.Text = "Kaydet";
            this.FrmBookSave.UseVisualStyleBackColor = true;
            this.FrmBookSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 721);
            this.Controls.Add(this.FrmBookSave);
            this.Controls.Add(this.frmbookexpt);
            this.Controls.Add(this.frmbookyeart);
            this.Controls.Add(this.frmbookpublishert);
            this.Controls.Add(this.frmbookpricet);
            this.Controls.Add(this.frmbookpaget);
            this.Controls.Add(this.frmbookauthort);
            this.Controls.Add(this.frmbooknamet);
            this.Controls.Add(this.frmbookexpl);
            this.Controls.Add(this.frmbookpublisherl);
            this.Controls.Add(this.frmbookyearl);
            this.Controls.Add(this.frmbookpagel);
            this.Controls.Add(this.frmbookpricel);
            this.Controls.Add(this.frmbookauthorl);
            this.Controls.Add(this.frmbooknamel);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label frmbooknamel;
        private Label frmbookauthorl;
        private Label frmbookpagel;
        private Label frmbookpricel;
        private Label frmbookpublisherl;
        private Label frmbookyearl;
        private Label frmbookexpl;
        private TextBox frmbooknamet;
        private TextBox frmbookauthort;
        private TextBox frmbookpaget;
        private TextBox frmbookyeart;
        private TextBox frmbookpublishert;
        private TextBox frmbookpricet;
        private RichTextBox frmbookexpt;
        private Button FrmBookSave;
    }
}