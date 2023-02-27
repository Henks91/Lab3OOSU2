
namespace GUI
{
    partial class Meny
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
            this.buttonSkapaBokningMeny = new System.Windows.Forms.Button();
            this.buttonHämtaUtBokning = new System.Windows.Forms.Button();
            this.buttonÅterlämningAvBokning = new System.Windows.Forms.Button();
            this.buttonLoggaUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSkapaBokningMeny
            // 
            this.buttonSkapaBokningMeny.Location = new System.Drawing.Point(12, 12);
            this.buttonSkapaBokningMeny.Name = "buttonSkapaBokningMeny";
            this.buttonSkapaBokningMeny.Size = new System.Drawing.Size(241, 67);
            this.buttonSkapaBokningMeny.TabIndex = 0;
            this.buttonSkapaBokningMeny.Text = "Skapa Bokning";
            this.buttonSkapaBokningMeny.UseVisualStyleBackColor = true;
            this.buttonSkapaBokningMeny.Click += new System.EventHandler(this.buttonSkapaBokningMeny_Click);
            // 
            // buttonHämtaUtBokning
            // 
            this.buttonHämtaUtBokning.Location = new System.Drawing.Point(270, 12);
            this.buttonHämtaUtBokning.Name = "buttonHämtaUtBokning";
            this.buttonHämtaUtBokning.Size = new System.Drawing.Size(241, 67);
            this.buttonHämtaUtBokning.TabIndex = 1;
            this.buttonHämtaUtBokning.Text = "Hämta ut bokning";
            this.buttonHämtaUtBokning.UseVisualStyleBackColor = true;
            this.buttonHämtaUtBokning.Click += new System.EventHandler(this.buttonHämtaUtBokning_Click);
            // 
            // buttonÅterlämningAvBokning
            // 
            this.buttonÅterlämningAvBokning.Location = new System.Drawing.Point(12, 85);
            this.buttonÅterlämningAvBokning.Name = "buttonÅterlämningAvBokning";
            this.buttonÅterlämningAvBokning.Size = new System.Drawing.Size(241, 67);
            this.buttonÅterlämningAvBokning.TabIndex = 2;
            this.buttonÅterlämningAvBokning.Text = "Återlämning";
            this.buttonÅterlämningAvBokning.UseVisualStyleBackColor = true;
            this.buttonÅterlämningAvBokning.Click += new System.EventHandler(this.buttonÅterlämningAvBokning_Click);
            // 
            // buttonLoggaUt
            // 
            this.buttonLoggaUt.Location = new System.Drawing.Point(270, 85);
            this.buttonLoggaUt.Name = "buttonLoggaUt";
            this.buttonLoggaUt.Size = new System.Drawing.Size(241, 67);
            this.buttonLoggaUt.TabIndex = 3;
            this.buttonLoggaUt.Text = "Logga Ut";
            this.buttonLoggaUt.UseVisualStyleBackColor = true;
            this.buttonLoggaUt.Click += new System.EventHandler(this.buttonLoggaUt_Click);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 168);
            this.Controls.Add(this.buttonLoggaUt);
            this.Controls.Add(this.buttonÅterlämningAvBokning);
            this.Controls.Add(this.buttonHämtaUtBokning);
            this.Controls.Add(this.buttonSkapaBokningMeny);
            this.Name = "Meny";
            this.Text = "Meny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSkapaBokningMeny;
        private System.Windows.Forms.Button buttonHämtaUtBokning;
        private System.Windows.Forms.Button buttonÅterlämningAvBokning;
        private System.Windows.Forms.Button buttonLoggaUt;
    }
}