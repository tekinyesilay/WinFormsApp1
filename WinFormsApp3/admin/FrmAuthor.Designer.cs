namespace WinFormsApp3.admin
{
    partial class FrmAuthor
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
            this.frmauthorbiot = new System.Windows.Forms.RichTextBox();
            this.frmauthorsurnamet = new System.Windows.Forms.TextBox();
            this.frmauthornamet = new System.Windows.Forms.TextBox();
            this.frmAuthorSave = new System.Windows.Forms.Button();
            this.frmauthorbiol = new System.Windows.Forms.Label();
            this.frmauthorsurnamel = new System.Windows.Forms.Label();
            this.frmauthornamel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmauthorbiot
            // 
            this.frmauthorbiot.Location = new System.Drawing.Point(302, 186);
            this.frmauthorbiot.Name = "frmauthorbiot";
            this.frmauthorbiot.Size = new System.Drawing.Size(316, 179);
            this.frmauthorbiot.TabIndex = 13;
            this.frmauthorbiot.Text = "";
            // 
            // frmauthorsurnamet
            // 
            this.frmauthorsurnamet.Location = new System.Drawing.Point(302, 114);
            this.frmauthorsurnamet.Name = "frmauthorsurnamet";
            this.frmauthorsurnamet.Size = new System.Drawing.Size(316, 31);
            this.frmauthorsurnamet.TabIndex = 12;
            // 
            // frmauthornamet
            // 
            this.frmauthornamet.Location = new System.Drawing.Point(302, 48);
            this.frmauthornamet.Name = "frmauthornamet";
            this.frmauthornamet.Size = new System.Drawing.Size(316, 31);
            this.frmauthornamet.TabIndex = 11;
            // 
            // frmAuthorSave
            // 
            this.frmAuthorSave.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmAuthorSave.Location = new System.Drawing.Point(397, 371);
            this.frmAuthorSave.Name = "frmAuthorSave";
            this.frmAuthorSave.Size = new System.Drawing.Size(112, 32);
            this.frmAuthorSave.TabIndex = 10;
            this.frmAuthorSave.Text = "Kaydet";
            this.frmAuthorSave.UseVisualStyleBackColor = true;
            this.frmAuthorSave.Click += new System.EventHandler(this.frmAuthorSave_Click);
            // 
            // frmauthorbiol
            // 
            this.frmauthorbiol.AutoSize = true;
            this.frmauthorbiol.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmauthorbiol.Location = new System.Drawing.Point(190, 186);
            this.frmauthorbiol.Name = "frmauthorbiol";
            this.frmauthorbiol.Size = new System.Drawing.Size(103, 26);
            this.frmauthorbiol.TabIndex = 9;
            this.frmauthorbiol.Text = "Biyografi:";
            // 
            // frmauthorsurnamel
            // 
            this.frmauthorsurnamel.AutoSize = true;
            this.frmauthorsurnamel.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmauthorsurnamel.Location = new System.Drawing.Point(207, 114);
            this.frmauthorsurnamel.Name = "frmauthorsurnamel";
            this.frmauthorsurnamel.Size = new System.Drawing.Size(86, 26);
            this.frmauthorsurnamel.TabIndex = 8;
            this.frmauthorsurnamel.Text = "Soyadı:";
            // 
            // frmauthornamel
            // 
            this.frmauthornamel.AutoSize = true;
            this.frmauthornamel.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmauthornamel.Location = new System.Drawing.Point(182, 54);
            this.frmauthornamel.Name = "frmauthornamel";
            this.frmauthornamel.Size = new System.Drawing.Size(111, 26);
            this.frmauthornamel.TabIndex = 7;
            this.frmauthornamel.Text = "Yazar Adı:";
            // 
            // FrmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 474);
            this.Controls.Add(this.frmauthorbiot);
            this.Controls.Add(this.frmauthorsurnamet);
            this.Controls.Add(this.frmauthornamet);
            this.Controls.Add(this.frmAuthorSave);
            this.Controls.Add(this.frmauthorbiol);
            this.Controls.Add(this.frmauthorsurnamel);
            this.Controls.Add(this.frmauthornamel);
            this.Name = "FrmAuthor";
            this.Text = "FrmAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox frmauthorbiot;
        private TextBox frmauthorsurnamet;
        private TextBox frmauthornamet;
        private Button frmAuthorSave;
        private Label frmauthorbiol;
        private Label frmauthorsurnamel;
        private Label frmauthornamel;
    }
}