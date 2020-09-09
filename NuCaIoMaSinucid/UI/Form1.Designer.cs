using Microsoft.EntityFrameworkCore;
using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data;
using System;
using System.Windows.Forms;

namespace NuCaIoMaSinucid
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cutieListaCarti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxInfoCarte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butInsertCarte = new System.Windows.Forms.Button();
            this.butInsertClient = new System.Windows.Forms.Button();
            this.butImprumutaCarte = new System.Windows.Forms.Button();
            this.radButLibere = new System.Windows.Forms.RadioButton();
            this.radButImprum = new System.Windows.Forms.RadioButton();
            this.radButToate = new System.Windows.Forms.RadioButton();
            this.radButIntarziate = new System.Windows.Forms.RadioButton();
            this.butEcranClienti = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cutieListaCarti
            // 
            this.cutieListaCarti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutieListaCarti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cutieListaCarti.FormattingEnabled = true;
            this.cutieListaCarti.ItemHeight = 21;
            this.cutieListaCarti.Location = new System.Drawing.Point(10, 40);
            this.cutieListaCarti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cutieListaCarti.Name = "cutieListaCarti";
            this.cutieListaCarti.Size = new System.Drawing.Size(712, 193);
            this.cutieListaCarti.TabIndex = 0;
            this.cutieListaCarti.SelectedIndexChanged += new System.EventHandler(this.cutieListaCarti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carti inregistrate";
            // 
            // boxInfoCarte
            // 
            this.boxInfoCarte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxInfoCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInfoCarte.Location = new System.Drawing.Point(10, 270);
            this.boxInfoCarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxInfoCarte.Multiline = true;
            this.boxInfoCarte.Name = "boxInfoCarte";
            this.boxInfoCarte.PlaceholderText = "Selectati o carte mai intai";
            this.boxInfoCarte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxInfoCarte.Size = new System.Drawing.Size(714, 157);
            this.boxInfoCarte.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informatii pentru cartea selectata";
            // 
            // butInsertCarte
            // 
            this.butInsertCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butInsertCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butInsertCarte.Location = new System.Drawing.Point(548, 9);
            this.butInsertCarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butInsertCarte.Name = "butInsertCarte";
            this.butInsertCarte.Size = new System.Drawing.Size(174, 29);
            this.butInsertCarte.TabIndex = 4;
            this.butInsertCarte.Text = "Introdu carti noi";
            this.butInsertCarte.UseVisualStyleBackColor = true;
            this.butInsertCarte.Click += new System.EventHandler(this.butInsertCarte_Click);
            // 
            // butInsertClient
            // 
            this.butInsertClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butInsertClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butInsertClient.Location = new System.Drawing.Point(10, 444);
            this.butInsertClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butInsertClient.Name = "butInsertClient";
            this.butInsertClient.Size = new System.Drawing.Size(137, 33);
            this.butInsertClient.TabIndex = 5;
            this.butInsertClient.Text = "Client nou";
            this.butInsertClient.UseVisualStyleBackColor = true;
            this.butInsertClient.Click += new System.EventHandler(this.butInsertClient_Click);
            // 
            // butImprumutaCarte
            // 
            this.butImprumutaCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butImprumutaCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butImprumutaCarte.Location = new System.Drawing.Point(470, 444);
            this.butImprumutaCarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butImprumutaCarte.Name = "butImprumutaCarte";
            this.butImprumutaCarte.Size = new System.Drawing.Size(252, 33);
            this.butImprumutaCarte.TabIndex = 6;
            this.butImprumutaCarte.Text = "Imprumuta cartea selectata";
            this.butImprumutaCarte.UseVisualStyleBackColor = true;
            // 
            // radButLibere
            // 
            this.radButLibere.AutoSize = true;
            this.radButLibere.Location = new System.Drawing.Point(223, 16);
            this.radButLibere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radButLibere.Name = "radButLibere";
            this.radButLibere.Size = new System.Drawing.Size(57, 19);
            this.radButLibere.TabIndex = 7;
            this.radButLibere.TabStop = true;
            this.radButLibere.Text = "Libere";
            this.radButLibere.UseVisualStyleBackColor = true;
            this.radButLibere.CheckedChanged += new System.EventHandler(this.radButLibere_CheckedChanged);
            // 
            // radButImprum
            // 
            this.radButImprum.AutoSize = true;
            this.radButImprum.Location = new System.Drawing.Point(290, 16);
            this.radButImprum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radButImprum.Name = "radButImprum";
            this.radButImprum.Size = new System.Drawing.Size(95, 19);
            this.radButImprum.TabIndex = 8;
            this.radButImprum.TabStop = true;
            this.radButImprum.Text = "Imprumutate";
            this.radButImprum.UseVisualStyleBackColor = true;
            this.radButImprum.CheckedChanged += new System.EventHandler(this.radButImprum_CheckedChanged);
            // 
            // radButToate
            // 
            this.radButToate.AutoSize = true;
            this.radButToate.Checked = true;
            this.radButToate.Location = new System.Drawing.Point(153, 16);
            this.radButToate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radButToate.Name = "radButToate";
            this.radButToate.Size = new System.Drawing.Size(53, 19);
            this.radButToate.TabIndex = 9;
            this.radButToate.TabStop = true;
            this.radButToate.Text = "Toate";
            this.radButToate.UseVisualStyleBackColor = true;
            this.radButToate.CheckedChanged += new System.EventHandler(this.radButToate_CheckedChanged);
            // 
            // radButIntarziate
            // 
            this.radButIntarziate.AutoSize = true;
            this.radButIntarziate.Location = new System.Drawing.Point(397, 16);
            this.radButIntarziate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radButIntarziate.Name = "radButIntarziate";
            this.radButIntarziate.Size = new System.Drawing.Size(73, 19);
            this.radButIntarziate.TabIndex = 10;
            this.radButIntarziate.TabStop = true;
            this.radButIntarziate.Text = "Intarziate";
            this.radButIntarziate.UseVisualStyleBackColor = true;
            this.radButIntarziate.CheckedChanged += new System.EventHandler(this.radButIntarziate_CheckedChanged);
            // 
            // butEcranClienti
            // 
            this.butEcranClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEcranClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butEcranClienti.Location = new System.Drawing.Point(153, 444);
            this.butEcranClienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butEcranClienti.Name = "butEcranClienti";
            this.butEcranClienti.Size = new System.Drawing.Size(131, 33);
            this.butEcranClienti.TabIndex = 11;
            this.butEcranClienti.Text = "Clienti";
            this.butEcranClienti.UseVisualStyleBackColor = true;
            this.butEcranClienti.Click += new System.EventHandler(this.butEcranClienti_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butRefresh.Location = new System.Drawing.Point(684, 40);
            this.butRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(38, 29);
            this.butRefresh.TabIndex = 12;
            this.butRefresh.Text = "R";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 492);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butEcranClienti);
            this.Controls.Add(this.radButIntarziate);
            this.Controls.Add(this.radButToate);
            this.Controls.Add(this.radButImprum);
            this.Controls.Add(this.radButLibere);
            this.Controls.Add(this.butImprumutaCarte);
            this.Controls.Add(this.butInsertClient);
            this.Controls.Add(this.butInsertCarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxInfoCarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cutieListaCarti);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(750, 531);
            this.Name = "Form1";
            this.Text = "Lista Carti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cutieListaCarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxInfoCarte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butInsertCarte;
        private System.Windows.Forms.Button butInsertClient;
        private System.Windows.Forms.Button butImprumutaCarte;
        private System.Windows.Forms.RadioButton radButLibere;
        private System.Windows.Forms.RadioButton radButImprum;
        private System.Windows.Forms.RadioButton radButToate;
        private System.Windows.Forms.RadioButton radButIntarziate;
        private System.Windows.Forms.Button butEcranClienti;
        private Button butRefresh;
    }
}

