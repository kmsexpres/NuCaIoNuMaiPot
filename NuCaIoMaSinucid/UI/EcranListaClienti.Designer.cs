﻿namespace NuCaIoMaSinucid.UI
{
    partial class EcranListaClienti
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
            this.butClientNou = new System.Windows.Forms.Button();
            this.butInapoi = new System.Windows.Forms.Button();
            this.butRefreshListaClienti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cititori inregistrati";
            // 
            // cutieListaClienti
            // 
            this.cutieListaClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutieListaClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cutieListaClienti.FormattingEnabled = true;
            this.cutieListaClienti.ItemHeight = 28;
            this.cutieListaClienti.Location = new System.Drawing.Point(12, 45);
            this.cutieListaClienti.Name = "cutieListaClienti";
            this.cutieListaClienti.Size = new System.Drawing.Size(528, 256);
            this.cutieListaClienti.TabIndex = 1;
            this.cutieListaClienti.SelectedIndexChanged += new System.EventHandler(this.cutieListaClienti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informatii complete despre client";
            // 
            // boxInfoClient
            // 
            this.boxInfoClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxInfoClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInfoClient.Location = new System.Drawing.Point(13, 362);
            this.boxInfoClient.Multiline = true;
            this.boxInfoClient.Name = "boxInfoClient";
            this.boxInfoClient.PlaceholderText = "Selectati un client";
            this.boxInfoClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxInfoClient.Size = new System.Drawing.Size(527, 198);
            this.boxInfoClient.TabIndex = 3;
            // 
            // butClientNou
            // 
            this.butClientNou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClientNou.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butClientNou.Location = new System.Drawing.Point(327, 566);
            this.butClientNou.Name = "butClientNou";
            this.butClientNou.Size = new System.Drawing.Size(180, 54);
            this.butClientNou.TabIndex = 4;
            this.butClientNou.Text = "Client nou";
            this.butClientNou.UseVisualStyleBackColor = true;
            this.butClientNou.Click += new System.EventHandler(this.butClientNou_Click);
            // 
            // butInapoi
            // 
            this.butInapoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butInapoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butInapoi.Location = new System.Drawing.Point(78, 572);
            this.butInapoi.Name = "butInapoi";
            this.butInapoi.Size = new System.Drawing.Size(87, 43);
            this.butInapoi.TabIndex = 5;
            this.butInapoi.Text = "Inapoi";
            this.butInapoi.UseVisualStyleBackColor = true;
            this.butInapoi.Click += new System.EventHandler(this.butInapoi_Click);
            // 
            // butRefreshListaClienti
            // 
            this.butRefreshListaClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRefreshListaClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butRefreshListaClienti.Location = new System.Drawing.Point(497, 45);
            this.butRefreshListaClienti.Name = "butRefreshListaClienti";
            this.butRefreshListaClienti.Size = new System.Drawing.Size(43, 39);
            this.butRefreshListaClienti.TabIndex = 6;
            this.butRefreshListaClienti.Text = "R";
            this.butRefreshListaClienti.UseVisualStyleBackColor = true;
            this.butRefreshListaClienti.Click += new System.EventHandler(this.butRefreshListaClienti_Click);
            // 
            // EcranListaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 638);
            this.Controls.Add(this.butRefreshListaClienti);
            this.Controls.Add(this.butInapoi);
            this.Controls.Add(this.butClientNou);
            this.Controls.Add(this.boxInfoClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cutieListaClienti);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(570, 685);
            this.Name = "EcranListaClienti";
            this.Text = "Clienti inregistrati";
            this.Load += new System.EventHandler(this.EcranListaClienti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox cutieListaClienti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxInfoClient;
        private System.Windows.Forms.Button butClientNou;
        private System.Windows.Forms.Button butInapoi;
        private System.Windows.Forms.Button butRefreshListaClienti;
    }
}