namespace Proje
{
    partial class MysqlVeriTabani
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
            this.tblOSDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusSeyahatDBDataSet3 = new Proje.OtobusSeyahatDBDataSet3();
            this.tbl_OSDBTableAdapter = new Proje.OtobusSeyahatDBDataSet3TableAdapters.tbl_OSDBTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblOSDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusSeyahatDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOSDBBindingSource
            // 
            this.tblOSDBBindingSource.DataMember = "tbl_OSDB";
            this.tblOSDBBindingSource.DataSource = this.otobusSeyahatDBDataSet3;
            // 
            // otobusSeyahatDBDataSet3
            // 
            this.otobusSeyahatDBDataSet3.DataSetName = "OtobusSeyahatDBDataSet3";
            this.otobusSeyahatDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OSDBTableAdapter
            // 
            this.tbl_OSDBTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(82, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 199);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 235);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MysqlVeriTabani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "MysqlVeriTabani";
            this.Text = "MysqlVeriTabani";
            this.Load += new System.EventHandler(this.MysqlVeriTabani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOSDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusSeyahatDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OtobusSeyahatDBDataSet3 otobusSeyahatDBDataSet3;
        private System.Windows.Forms.BindingSource tblOSDBBindingSource;
        private OtobusSeyahatDBDataSet3TableAdapters.tbl_OSDBTableAdapter tbl_OSDBTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}