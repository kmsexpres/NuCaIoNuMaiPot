namespace NuCaIoMaSinucid.UI
{
    partial class EcranInsertCartiNoi
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
            this.boxCodInventar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTitlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxDetaliiCarte = new System.Windows.Forms.TextBox();
            this.butFinishBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Inventar";
            // 
            // boxCodInventar
            // 
            this.boxCodInventar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxCodInventar.Location = new System.Drawing.Point(176, 20);
            this.boxCodInventar.Name = "boxCodInventar";
            this.boxCodInventar.Size = new System.Drawing.Size(97, 34);
            this.boxCodInventar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titlu";
            // 
            // boxTitlu
            // 
            this.boxTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxTitlu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxTitlu.Location = new System.Drawing.Point(101, 83);
            this.boxTitlu.Name = "boxTitlu";
            this.boxTitlu.Size = new System.Drawing.Size(245, 34);
            this.boxTitlu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor";
            // 
            // boxAutor
            // 
            this.boxAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxAutor.Location = new System.Drawing.Point(101, 152);
            this.boxAutor.Name = "boxAutor";
            this.boxAutor.Size = new System.Drawing.Size(245, 34);
            this.boxAutor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Detalii";
            // 
            // boxDetaliiCarte
            // 
            this.boxDetaliiCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDetaliiCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxDetaliiCarte.Location = new System.Drawing.Point(27, 244);
            this.boxDetaliiCarte.Multiline = true;
            this.boxDetaliiCarte.Name = "boxDetaliiCarte";
            this.boxDetaliiCarte.PlaceholderText = "Mai multe informatii despre carte";
            this.boxDetaliiCarte.Size = new System.Drawing.Size(319, 122);
            this.boxDetaliiCarte.TabIndex = 7;
            // 
            // butFinishBook
            // 
            this.butFinishBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFinishBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butFinishBook.Location = new System.Drawing.Point(176, 387);
            this.butFinishBook.Name = "butFinishBook";
            this.butFinishBook.Size = new System.Drawing.Size(170, 68);
            this.butFinishBook.TabIndex = 8;
            this.butFinishBook.Text = "Adauga";
            this.butFinishBook.UseVisualStyleBackColor = true;
            this.butFinishBook.Click += new System.EventHandler(this.butFinishBook_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(27, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mergi inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EcranInsertCartiNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butFinishBook);
            this.Controls.Add(this.boxDetaliiCarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxTitlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxCodInventar);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(400, 520);
            this.Name = "EcranInsertCartiNoi";
            this.Text = "Adauga carte noua";
            this.Load += new System.EventHandler(this.EcranInsertCartiNoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxCodInventar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxTitlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxDetaliiCarte;
        private System.Windows.Forms.Button butFinishBook;
        private System.Windows.Forms.Button button1;
    }
}