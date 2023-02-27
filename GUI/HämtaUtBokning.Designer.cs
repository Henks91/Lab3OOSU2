
namespace GUI
{
    partial class HämtaUtBokning
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVisaBokning = new System.Windows.Forms.Button();
            this.labelBokningsNr = new System.Windows.Forms.Label();
            this.labelMedlemsNr = new System.Windows.Forms.Label();
            this.buttonHämtaBokning = new System.Windows.Forms.Button();
            this.buttonBakåtFrånUtlämning = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ange bokningsnummer / medlemsnummer:";
            // 
            // buttonVisaBokning
            // 
            this.buttonVisaBokning.Location = new System.Drawing.Point(10, 49);
            this.buttonVisaBokning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVisaBokning.Name = "buttonVisaBokning";
            this.buttonVisaBokning.Size = new System.Drawing.Size(259, 22);
            this.buttonVisaBokning.TabIndex = 2;
            this.buttonVisaBokning.Text = "Visa bokning";
            this.buttonVisaBokning.UseVisualStyleBackColor = true;
            this.buttonVisaBokning.Click += new System.EventHandler(this.buttonVisaBokning_Click);
            // 
            // labelBokningsNr
            // 
            this.labelBokningsNr.AutoSize = true;
            this.labelBokningsNr.Location = new System.Drawing.Point(10, 75);
            this.labelBokningsNr.Name = "labelBokningsNr";
            this.labelBokningsNr.Size = new System.Drawing.Size(105, 15);
            this.labelBokningsNr.TabIndex = 4;
            this.labelBokningsNr.Text = "Bokningsnummer:";
            // 
            // labelMedlemsNr
            // 
            this.labelMedlemsNr.AutoSize = true;
            this.labelMedlemsNr.Location = new System.Drawing.Point(10, 90);
            this.labelMedlemsNr.Name = "labelMedlemsNr";
            this.labelMedlemsNr.Size = new System.Drawing.Size(105, 15);
            this.labelMedlemsNr.TabIndex = 5;
            this.labelMedlemsNr.Text = "Medlemsnummer:";
            // 
            // buttonHämtaBokning
            // 
            this.buttonHämtaBokning.Location = new System.Drawing.Point(378, 179);
            this.buttonHämtaBokning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHämtaBokning.Name = "buttonHämtaBokning";
            this.buttonHämtaBokning.Size = new System.Drawing.Size(156, 22);
            this.buttonHämtaBokning.TabIndex = 6;
            this.buttonHämtaBokning.Text = "Hämta bokning";
            this.buttonHämtaBokning.UseVisualStyleBackColor = true;
            this.buttonHämtaBokning.Click += new System.EventHandler(this.buttonHämtaBokning_Click);
            // 
            // buttonBakåtFrånUtlämning
            // 
            this.buttonBakåtFrånUtlämning.Location = new System.Drawing.Point(10, 179);
            this.buttonBakåtFrånUtlämning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBakåtFrånUtlämning.Name = "buttonBakåtFrånUtlämning";
            this.buttonBakåtFrånUtlämning.Size = new System.Drawing.Size(111, 22);
            this.buttonBakåtFrånUtlämning.TabIndex = 7;
            this.buttonBakåtFrånUtlämning.Text = "Bakåt";
            this.buttonBakåtFrånUtlämning.UseVisualStyleBackColor = true;
            this.buttonBakåtFrånUtlämning.Click += new System.EventHandler(this.buttonBakåtFrånUtlämning_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bokning:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titelDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(262, 141);
            this.dataGridView1.TabIndex = 9;
            // 
            // bokBindingSource
            // 
            this.bokBindingSource.DataSource = typeof(Business.Classes.Bok);
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // HämtaUtBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 214);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBakåtFrånUtlämning);
            this.Controls.Add(this.buttonHämtaBokning);
            this.Controls.Add(this.labelMedlemsNr);
            this.Controls.Add(this.labelBokningsNr);
            this.Controls.Add(this.buttonVisaBokning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(562, 253);
            this.MinimumSize = new System.Drawing.Size(562, 253);
            this.Name = "HämtaUtBokning";
            this.Text = "HämtaUtBokning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVisaBokning;
        private System.Windows.Forms.Label labelBokningsNr;
        private System.Windows.Forms.Label labelMedlemsNr;
        private System.Windows.Forms.Button buttonHämtaBokning;
        private System.Windows.Forms.Button buttonBakåtFrånUtlämning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bokBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
    }
}