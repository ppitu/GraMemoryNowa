﻿
namespace Gra_Memoy___DN
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCzasGry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.panelKarty = new System.Windows.Forms.Panel();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas";
            // 
            // lblCzasGry
            // 
            this.lblCzasGry.AutoSize = true;
            this.lblCzasGry.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasGry.Location = new System.Drawing.Point(23, 32);
            this.lblCzasGry.Name = "lblCzasGry";
            this.lblCzasGry.Size = new System.Drawing.Size(34, 23);
            this.lblCzasGry.TabIndex = 1;
            this.lblCzasGry.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(227, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Punkty:";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty.Location = new System.Drawing.Point(254, 32);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(22, 23);
            this.lblPunkty.TabIndex = 2;
            this.lblPunkty.Text = "0";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartInfo.Location = new System.Drawing.Point(420, 9);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(185, 23);
            this.lblStartInfo.TabIndex = 4;
            this.lblStartInfo.Text = "Początek gry za 5.";
            // 
            // panelKarty
            // 
            this.panelKarty.Location = new System.Drawing.Point(16, 69);
            this.panelKarty.Name = "panelKarty";
            this.panelKarty.Size = new System.Drawing.Size(570, 143);
            this.panelKarty.TabIndex = 5;
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            this.timerZakrywacz.Tick += new System.EventHandler(this.timerZakrywacz_Tick);
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            this.timerCzasGry.Tick += new System.EventHandler(this.timerCzasGry_Tick);
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            this.timerCzasPodgladu.Tick += new System.EventHandler(this.timerCzasPodgladu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(617, 224);
            this.Controls.Add(this.panelKarty);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.lblCzasGry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Gra memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCzasGry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Panel panelKarty;
        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
    }
}

