namespace Alexey
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alexeyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alexeyDataSet = new Alexey.alexeyDataSet();
            this.alexeyTableAdapter = new Alexey.alexeyDataSetTableAdapters.alexeyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.tsenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alexeyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "kolvo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "kolvo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            // 
            // tsenaDataGridViewTextBoxColumn
            // 
            this.tsenaDataGridViewTextBoxColumn.DataPropertyName = "tsena";
            this.tsenaDataGridViewTextBoxColumn.HeaderText = "tsena";
            this.tsenaDataGridViewTextBoxColumn.Name = "tsenaDataGridViewTextBoxColumn";
            // 
            // alexeyBindingSource
            // 
            this.alexeyBindingSource.DataMember = "alexey";
            this.alexeyBindingSource.DataSource = this.alexeyDataSet;
            this.alexeyBindingSource.CurrentChanged += new System.EventHandler(this.alexeyBindingSource_CurrentChanged);
            // 
            // alexeyDataSet
            // 
            this.alexeyDataSet.DataSetName = "alexeyDataSet";
            this.alexeyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alexeyTableAdapter
            // 
            this.alexeyTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 266);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private alexeyDataSet alexeyDataSet;
        private System.Windows.Forms.BindingSource alexeyBindingSource;
        private alexeyDataSetTableAdapters.alexeyTableAdapter alexeyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsenaDataGridViewTextBoxColumn;
    }
}

