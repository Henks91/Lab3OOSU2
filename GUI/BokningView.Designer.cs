namespace GUI
{
    partial class BokningView
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
            this.buttonVisaTillgängligaBöcker = new System.Windows.Forms.Button();
            this.buttonFlyttaBöckerTillVal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bokningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonFlyttaBöckerFrånVal = new System.Windows.Forms.Button();
            this.buttonBokaValdaBöcker = new System.Windows.Forms.Button();
            this.buttonBakåtFrånBokning = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVisaTillgängligaBöcker
            // 
            this.buttonVisaTillgängligaBöcker.Location = new System.Drawing.Point(11, 143);
            this.buttonVisaTillgängligaBöcker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVisaTillgängligaBöcker.Name = "buttonVisaTillgängligaBöcker";
            this.buttonVisaTillgängligaBöcker.Size = new System.Drawing.Size(250, 31);
            this.buttonVisaTillgängligaBöcker.TabIndex = 0;
            this.buttonVisaTillgängligaBöcker.Text = "Se tillgängliga böcker";
            this.buttonVisaTillgängligaBöcker.UseVisualStyleBackColor = true;
            this.buttonVisaTillgängligaBöcker.Click += new System.EventHandler(this.buttonVisaTillgängligaBöcker_Click);
            // 
            // buttonFlyttaBöckerTillVal
            // 
            this.buttonFlyttaBöckerTillVal.Location = new System.Drawing.Point(514, 13);
            this.buttonFlyttaBöckerTillVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFlyttaBöckerTillVal.Name = "buttonFlyttaBöckerTillVal";
            this.buttonFlyttaBöckerTillVal.Size = new System.Drawing.Size(86, 31);
            this.buttonFlyttaBöckerTillVal.TabIndex = 1;
            this.buttonFlyttaBöckerTillVal.Text = ">";
            this.buttonFlyttaBöckerTillVal.UseVisualStyleBackColor = true;
            this.buttonFlyttaBöckerTillVal.Click += new System.EventHandler(this.buttonFlyttaBöckerTillVal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.bokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(272, 302);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(311, 118);
            this.dataGridView1.TabIndex = 4;
            // 
            // bokBindingSource
            // 
            this.bokBindingSource.DataSource = typeof(Business.Classes.Bok);
            // 
            // bokningBindingSource
            // 
            this.bokningBindingSource.DataSource = typeof(Business.Classes.Bokning);
            // 
            // bokBindingSource1
            // 
            this.bokBindingSource1.DataSource = typeof(Business.Classes.Bok);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ange datum för start av bokning:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ange medlemsnummer:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(272, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 184);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(606, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 184);
            this.listBox2.TabIndex = 10;
            // 
            // buttonFlyttaBöckerFrånVal
            // 
            this.buttonFlyttaBöckerFrånVal.Location = new System.Drawing.Point(514, 52);
            this.buttonFlyttaBöckerFrånVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFlyttaBöckerFrånVal.Name = "buttonFlyttaBöckerFrånVal";
            this.buttonFlyttaBöckerFrånVal.Size = new System.Drawing.Size(86, 31);
            this.buttonFlyttaBöckerFrånVal.TabIndex = 11;
            this.buttonFlyttaBöckerFrånVal.Text = "<";
            this.buttonFlyttaBöckerFrånVal.UseVisualStyleBackColor = true;
            this.buttonFlyttaBöckerFrånVal.Click += new System.EventHandler(this.buttonFlyttaBöckerFrånVal_Click);
            // 
            // buttonBokaValdaBöcker
            // 
            this.buttonBokaValdaBöcker.Location = new System.Drawing.Point(514, 166);
            this.buttonBokaValdaBöcker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBokaValdaBöcker.Name = "buttonBokaValdaBöcker";
            this.buttonBokaValdaBöcker.Size = new System.Drawing.Size(86, 31);
            this.buttonBokaValdaBöcker.TabIndex = 12;
            this.buttonBokaValdaBöcker.Text = "Boka";
            this.buttonBokaValdaBöcker.UseVisualStyleBackColor = true;
            this.buttonBokaValdaBöcker.Click += new System.EventHandler(this.buttonBokaValdaBöcker_Click);
            // 
            // buttonBakåtFrånBokning
            // 
            this.buttonBakåtFrånBokning.Location = new System.Drawing.Point(11, 389);
            this.buttonBakåtFrånBokning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBakåtFrånBokning.Name = "buttonBakåtFrånBokning";
            this.buttonBakåtFrånBokning.Size = new System.Drawing.Size(86, 31);
            this.buttonBakåtFrånBokning.TabIndex = 13;
            this.buttonBakåtFrånBokning.Text = "Bakåt";
            this.buttonBakåtFrånBokning.UseVisualStyleBackColor = true;
            this.buttonBakåtFrånBokning.Click += new System.EventHandler(this.buttonBakåtFrånBokning_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(272, 231);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(570, 64);
            this.listBox3.TabIndex = 14;
            this.listBox3.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox3_Format);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bokning:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Titel";
            this.dataGridViewTextBoxColumn1.HeaderText = "Titel";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // BokningView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.buttonBakåtFrånBokning);
            this.Controls.Add(this.buttonBokaValdaBöcker);
            this.Controls.Add(this.buttonFlyttaBöckerFrånVal);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFlyttaBöckerTillVal);
            this.Controls.Add(this.buttonVisaTillgängligaBöcker);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(868, 479);
            this.MinimumSize = new System.Drawing.Size(868, 479);
            this.Name = "BokningView";
            this.Text = "BokningView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVisaTillgängligaBöcker;
        private System.Windows.Forms.Button buttonFlyttaBöckerTillVal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bokBindingSource;
        private System.Windows.Forms.BindingSource bokBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonFlyttaBöckerFrånVal;
        private System.Windows.Forms.Button buttonBokaValdaBöcker;
        private System.Windows.Forms.Button buttonBakåtFrånBokning;
        private System.Windows.Forms.BindingSource bokningBindingSource;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}