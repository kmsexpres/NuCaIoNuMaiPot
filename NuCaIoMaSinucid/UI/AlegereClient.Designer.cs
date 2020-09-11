namespace NuCaIoMaSinucid.UI
{
    partial class AlegereClient
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
            this.cutieListaClienti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxInfoClient = new System.Windows.Forms.TextBox();
            this.butImprumuta = new System.Windows.Forms.Button();
            this.butInapoi = new System.Windows.Forms.Button();
            this.dateImprum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clienti inregistrati";
            // 
            // cutieListaClienti
            // 
            this.cutieListaClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutieListaClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cutieListaClienti.FormattingEnabled = true;
            this.cutieListaClienti.ItemHeight = 28;
            this.cutieListaClienti.Location = new System.Drawing.Point(14, 44);
            this.cutieListaClienti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cutieListaClienti.Name = "cutieListaClienti";
            this.cutieListaClienti.Size = new System.Drawing.Size(468, 284);
            this.cutieListaClienti.TabIndex = 1;
            this.cutieListaClienti.SelectedIndexChanged += new System.EventHandler(this.cutieListaClienti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Info client";
            // 
            // boxInfoClient
            // 
            this.boxInfoClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxInfoClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInfoClient.Location = new System.Drawing.Point(14, 389);
            this.boxInfoClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxInfoClient.Multiline = true;
            this.boxInfoClient.Name = "boxInfoClient";
            this.boxInfoClient.PlaceholderText = "Selectati un client";
            this.boxInfoClient.Size = new System.Drawing.Size(468, 181);
            this.boxInfoClient.TabIndex = 3;
            // 
            // butImprumuta
            // 
            this.butImprumuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butImprumuta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butImprumuta.Location = new System.Drawing.Point(262, 732);
            this.butImprumuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butImprumuta.Name = "butImprumuta";
            this.butImprumuta.Size = new System.Drawing.Size(184, 68);
            this.butImprumuta.TabIndex = 4;
            this.butImprumuta.Text = "Imprumuta";
            this.butImprumuta.UseVisualStyleBackColor = true;
            this.butImprumuta.Click += new System.EventHandler(this.butAlege_Click);
            // 
            // butInapoi
            // 
            this.butInapoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butInapoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butInapoi.Location = new System.Drawing.Point(62, 744);
            this.butInapoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butInapoi.Name = "butInapoi";
            this.butInapoi.Size = new System.Drawing.Size(104, 43);
            this.butInapoi.TabIndex = 5;
            this.butInapoi.Text = "Inapoi";
            this.butInapoi.UseVisualStyleBackColor = true;
            this.butInapoi.Click += new System.EventHandler(this.butInapoi_Click);
            // 
            // dateImprum
            // 
            this.dateImprum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateImprum.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateImprum.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateImprum.CustomFormat = "dd/MMM/yyyy";
            this.dateImprum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateImprum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateImprum.Location = new System.Drawing.Point(35, 645);
            this.dateImprum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateImprum.Name = "dateImprum";
            this.dateImprum.Size = new System.Drawing.Size(177, 34);
            this.dateImprum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "De la";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(262, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pana la";
            // 
            // dateReturn
            // 
            this.dateReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReturn.CustomFormat = "dd/MMM/yyyy";
            this.dateReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReturn.Location = new System.Drawing.Point(262, 645);
            this.dateReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(183, 34);
            this.dateReturn.TabIndex = 9;
            // 
            // AlegereClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 828);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateImprum);
            this.Controls.Add(this.butInapoi);
            this.Controls.Add(this.butImprumuta);
            this.Controls.Add(this.boxInfoClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cutieListaClienti);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(512, 864);
            this.Name = "AlegereClient";
            this.Text = "AlegereClient";
            this.Load += new System.EventHandler(this.AlegereClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox cutieListaClienti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxInfoClient;
        private System.Windows.Forms.Button butImprumuta;
        private System.Windows.Forms.Button butInapoi;
        private System.Windows.Forms.DateTimePicker dateImprum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateReturn;
    }
}