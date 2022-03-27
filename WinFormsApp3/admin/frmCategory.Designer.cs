namespace WinFormsApp3.admin
{
    partial class frmCategory
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
            this.frmcategorynamel = new System.Windows.Forms.Label();
            this.frmcategoryexpl = new System.Windows.Forms.Label();
            this.FrmCategorySave = new System.Windows.Forms.Button();
            this.frmcategoryexpt = new System.Windows.Forms.RichTextBox();
            this.frmcategorynamet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frmcategorynamel
            // 
            this.frmcategorynamel.AutoSize = true;
            this.frmcategorynamel.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmcategorynamel.Location = new System.Drawing.Point(134, 56);
            this.frmcategorynamel.Name = "frmcategorynamel";
            this.frmcategorynamel.Size = new System.Drawing.Size(137, 26);
            this.frmcategorynamel.TabIndex = 0;
            this.frmcategorynamel.Text = "Kategori Adı:";
            this.frmcategorynamel.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmcategoryexpl
            // 
            this.frmcategoryexpl.AutoSize = true;
            this.frmcategoryexpl.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmcategoryexpl.Location = new System.Drawing.Point(163, 116);
            this.frmcategoryexpl.Name = "frmcategoryexpl";
            this.frmcategoryexpl.Size = new System.Drawing.Size(108, 26);
            this.frmcategoryexpl.TabIndex = 1;
            this.frmcategoryexpl.Text = "Açıklama:";
            // 
            // FrmCategorySave
            // 
            this.FrmCategorySave.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrmCategorySave.Location = new System.Drawing.Point(363, 344);
            this.FrmCategorySave.Name = "FrmCategorySave";
            this.FrmCategorySave.Size = new System.Drawing.Size(136, 40);
            this.FrmCategorySave.TabIndex = 2;
            this.FrmCategorySave.Text = "Kaydet";
            this.FrmCategorySave.UseVisualStyleBackColor = true;
            // 
            // frmcategoryexpt
            // 
            this.frmcategoryexpt.Location = new System.Drawing.Point(277, 114);
            this.frmcategoryexpt.Name = "frmcategoryexpt";
            this.frmcategoryexpt.Size = new System.Drawing.Size(313, 224);
            this.frmcategoryexpt.TabIndex = 3;
            this.frmcategoryexpt.Text = "";
            // 
            // frmcategorynamet
            // 
            this.frmcategorynamet.Location = new System.Drawing.Point(277, 54);
            this.frmcategorynamet.Name = "frmcategorynamet";
            this.frmcategorynamet.Size = new System.Drawing.Size(313, 31);
            this.frmcategorynamet.TabIndex = 4;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmcategorynamet);
            this.Controls.Add(this.frmcategoryexpt);
            this.Controls.Add(this.FrmCategorySave);
            this.Controls.Add(this.frmcategoryexpl);
            this.Controls.Add(this.frmcategorynamel);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label frmcategorynamel;
        private Label frmcategoryexpl;
        private Button FrmCategorySave;
        private RichTextBox frmcategoryexpt;
        private TextBox frmcategorynamet;
    }
}