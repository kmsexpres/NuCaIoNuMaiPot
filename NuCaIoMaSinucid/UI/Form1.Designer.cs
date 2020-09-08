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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
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
            this.cutieListaCarti.ItemHeight = 28;
            this.cutieListaCarti.Location = new System.Drawing.Point(12, 54);
            this.cutieListaCarti.Name = "cutieListaCarti";
            this.cutieListaCarti.Size = new System.Drawing.Size(813, 256);
            this.cutieListaCarti.TabIndex = 0;
            this.cutieListaCarti.SelectedIndexChanged += new System.EventHandler(this.cutieListaCarti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carti inregistrate";
            // 
            // boxInfoCarte
            // 
            this.boxInfoCarte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxInfoCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInfoCarte.Location = new System.Drawing.Point(12, 360);
            this.boxInfoCarte.Multiline = true;
            this.boxInfoCarte.Name = "boxInfoCarte";
            this.boxInfoCarte.PlaceholderText = "Selectati o carte mai intai";
            this.boxInfoCarte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxInfoCarte.Size = new System.Drawing.Size(815, 208);
            this.boxInfoCarte.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informatii pentru cartea selectata";
            // 
            // butInsertCarte
            // 
            this.butInsertCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butInsertCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butInsertCarte.Location = new System.Drawing.Point(626, 12);
            this.butInsertCarte.Name = "butInsertCarte";
            this.butInsertCarte.Size = new System.Drawing.Size(199, 39);
            this.butInsertCarte.TabIndex = 4;
            this.butInsertCarte.Text = "Introdu carti noi";
            this.butInsertCarte.UseVisualStyleBackColor = true;
            this.butInsertCarte.Click += new System.EventHandler(this.butInsertCarte_Click);
            // 
            // butInsertClient
            // 
            this.butInsertClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butInsertClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butInsertClient.Location = new System.Drawing.Point(12, 592);
            this.butInsertClient.Name = "butInsertClient";
            this.butInsertClient.Size = new System.Drawing.Size(157, 44);
            this.butInsertClient.TabIndex = 5;
            this.butInsertClient.Text = "Client nou";
            this.butInsertClient.UseVisualStyleBackColor = true;
            this.butInsertClient.Click += new System.EventHandler(this.butInsertClient_Click);
            // 
            // butImprumutaCarte
            // 
            this.butImprumutaCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butImprumutaCarte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butImprumutaCarte.Location = new System.Drawing.Point(537, 592);
            this.butImprumutaCarte.Name = "butImprumutaCarte";
            this.butImprumutaCarte.Size = new System.Drawing.Size(288, 44);
            this.butImprumutaCarte.TabIndex = 6;
            this.butImprumutaCarte.Text = "Imprumuta cartea selectata";
            this.butImprumutaCarte.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(255, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Libere";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(332, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Imprumutate";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(175, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 24);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Toate";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(454, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(92, 24);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Intarziate";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // butEcranClienti
            // 
            this.butEcranClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEcranClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butEcranClienti.Location = new System.Drawing.Point(175, 592);
            this.butEcranClienti.Name = "butEcranClienti";
            this.butEcranClienti.Size = new System.Drawing.Size(150, 44);
            this.butEcranClienti.TabIndex = 11;
            this.butEcranClienti.Text = "Clienti";
            this.butEcranClienti.UseVisualStyleBackColor = true;
            this.butEcranClienti.Click += new System.EventHandler(this.butEcranClienti_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butRefresh.Location = new System.Drawing.Point(781, 54);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(44, 39);
            this.butRefresh.TabIndex = 12;
            this.butRefresh.Text = "R";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 648);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butEcranClienti);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.butImprumutaCarte);
            this.Controls.Add(this.butInsertClient);
            this.Controls.Add(this.butInsertCarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxInfoCarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cutieListaCarti);
            this.MinimumSize = new System.Drawing.Size(855, 695);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button butEcranClienti;
        private Button butRefresh;
    }
}

