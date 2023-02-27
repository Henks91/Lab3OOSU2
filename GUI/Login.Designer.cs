namespace GUI
{
    partial class Login
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
            this.button1Login = new System.Windows.Forms.Button();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.textBox1Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Login
            // 
            this.button1Login.Location = new System.Drawing.Point(384, 371);
            this.button1Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(86, 31);
            this.button1Login.TabIndex = 0;
            this.button1Login.Text = "Sign in";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(371, 315);
            this.textBox2Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(114, 27);
            this.textBox2Password.TabIndex = 1;
            // 
            // textBox1Id
            // 
            this.textBox1Id.Location = new System.Drawing.Point(371, 245);
            this.textBox1Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1Id.Name = "textBox1Id";
            this.textBox1Id.Size = new System.Drawing.Size(114, 27);
            this.textBox1Id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anställningsnr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord:";
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.Location = new System.Drawing.Point(384, 409);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(86, 29);
            this.buttonAvsluta.TabIndex = 5;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = true;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonAvsluta_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 613);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Id);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.button1Login);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.TextBox textBox1Id;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAvsluta;
    }
}