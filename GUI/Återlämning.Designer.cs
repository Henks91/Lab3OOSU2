
namespace GUI
{
    partial class Återlämning
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
            this.buttonBakåtFrånÅterlämning = new System.Windows.Forms.Button();
            this.bokningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonÅterlämnaBokning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Böcker = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bokningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBakåtFrånÅterlämning
            // 
            this.buttonBakåtFrånÅterlämning.Location = new System.Drawing.Point(6, 420);
            this.buttonBakåtFrånÅterlämning.Name = "buttonBakåtFrånÅterlämning";
            this.buttonBakåtFrånÅterlämning.Size = new System.Drawing.Size(127, 29);
            this.buttonBakåtFrånÅterlämning.TabIndex = 15;
            this.buttonBakåtFrånÅterlämning.Text = "Bakåt";
            this.buttonBakåtFrånÅterlämning.UseVisualStyleBackColor = true;
            this.buttonBakåtFrånÅterlämning.Click += new System.EventHandler(this.buttonBakåtFrånÅterlämning_Click);
            // 
            // bokningBindingSource
            // 
            this.bokningBindingSource.DataSource = typeof(Business.Classes.Bokning);
            // 
            // buttonÅterlämnaBokning
            // 
            this.buttonÅterlämnaBokning.Location = new System.Drawing.Point(6, 65);
            this.buttonÅterlämnaBokning.Name = "buttonÅterlämnaBokning";
            this.buttonÅterlämnaBokning.Size = new System.Drawing.Size(296, 29);
            this.buttonÅterlämnaBokning.TabIndex = 10;
            this.buttonÅterlämnaBokning.Text = "Återlämna bokning";
            this.buttonÅterlämnaBokning.UseVisualStyleBackColor = true;
            this.buttonÅterlämnaBokning.Click += new System.EventHandler(this.buttonÅterlämnaBokning_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ange bokningsnummer / medlemsnummer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 27);
            this.textBox1.TabIndex = 8;
            // 
            // fakturaBindingSource
            // 
            this.fakturaBindingSource.DataSource = typeof(Business.Classes.Faktura);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Faktura:";
            // 
            // bokBindingSource
            // 
            this.bokBindingSource.DataSource = typeof(Business.Classes.Bok);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titelDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bokBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 137);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(546, 160);
            this.dataGridView3.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            this.titelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            this.titelDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // Böcker
            // 
            this.Böcker.AutoSize = true;
            this.Böcker.Location = new System.Drawing.Point(6, 113);
            this.Böcker.Name = "Böcker";
            this.Böcker.Size = new System.Drawing.Size(183, 20);
            this.Böcker.TabIndex = 20;
            this.Böcker.Text = "Böcker som återlämnades:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(546, 64);
            this.listBox1.TabIndex = 22;
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format);
            // 
            // Återlämning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 461);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Böcker);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBakåtFrånÅterlämning);
            this.Controls.Add(this.buttonÅterlämnaBokning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(598, 508);
            this.MinimumSize = new System.Drawing.Size(598, 508);
            this.Name = "Återlämning";
            this.Text = "Återlämning";
            ((System.ComponentModel.ISupportInitialize)(this.bokningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBakåtFrånÅterlämning;
        private System.Windows.Forms.Button buttonÅterlämnaBokning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bokningBindingSource;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
        private System.Windows.Forms.BindingSource bokBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Böcker;
        private System.Windows.Forms.ListBox listBox1;
    }
}