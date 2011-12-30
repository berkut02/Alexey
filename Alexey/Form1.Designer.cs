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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.alexeyDataSet1 = new Alexey.alexeyDataSet1();
            this.vAlexeyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAlexeyTableAdapter = new Alexey.alexeyDataSet1TableAdapters.vAlexeyTableAdapter();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlexeyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.kolvoDataGridViewTextBoxColumn1,
            this.tsenaDataGridViewTextBoxColumn1,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vAlexeyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(362, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(449, 242);
            this.dataGridView2.TabIndex = 1;
            // 
            // alexeyDataSet1
            // 
            this.alexeyDataSet1.DataSetName = "alexeyDataSet1";
            this.alexeyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAlexeyBindingSource
            // 
            this.vAlexeyBindingSource.DataMember = "vAlexey";
            this.vAlexeyBindingSource.DataSource = this.alexeyDataSet1;
            // 
            // vAlexeyTableAdapter
            // 
            this.vAlexeyTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // kolvoDataGridViewTextBoxColumn1
            // 
            this.kolvoDataGridViewTextBoxColumn1.DataPropertyName = "kolvo";
            this.kolvoDataGridViewTextBoxColumn1.HeaderText = "kolvo";
            this.kolvoDataGridViewTextBoxColumn1.Name = "kolvoDataGridViewTextBoxColumn1";
            // 
            // tsenaDataGridViewTextBoxColumn1
            // 
            this.tsenaDataGridViewTextBoxColumn1.DataPropertyName = "tsena";
            this.tsenaDataGridViewTextBoxColumn1.HeaderText = "tsena";
            this.tsenaDataGridViewTextBoxColumn1.Name = "tsenaDataGridViewTextBoxColumn1";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 266);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexeyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlexeyBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private alexeyDataSet1 alexeyDataSet1;
        private System.Windows.Forms.BindingSource vAlexeyBindingSource;
        private alexeyDataSet1TableAdapters.vAlexeyTableAdapter vAlexeyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
    }
}

