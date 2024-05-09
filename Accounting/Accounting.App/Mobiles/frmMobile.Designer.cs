namespace Accounting.App.Mobiles
{
    partial class frmMobile
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
            this.dgvMobiles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddMobile = new System.Windows.Forms.ToolStripButton();
            this.btnEditMobile = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMobile = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMobiles
            // 
            this.dgvMobiles.AllowUserToAddRows = false;
            this.dgvMobiles.AllowUserToDeleteRows = false;
            this.dgvMobiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMobiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMobiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMobiles.Location = new System.Drawing.Point(0, 94);
            this.dgvMobiles.Name = "dgvMobiles";
            this.dgvMobiles.ReadOnly = true;
            this.dgvMobiles.RowTemplate.Height = 24;
            this.dgvMobiles.Size = new System.Drawing.Size(682, 359);
            this.dgvMobiles.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MobileID";
            this.Column1.HeaderText = "موبایل ای دی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Model";
            this.Column2.FillWeight = 46.94836F;
            this.Column2.HeaderText = "مدل موبایل";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Brand";
            this.Column3.FillWeight = 102.9197F;
            this.Column3.HeaderText = "برند موبایل";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Amount";
            this.Column4.FillWeight = 150.1319F;
            this.Column4.HeaderText = "قیمت موبایل";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMobile,
            this.toolStripSeparator1,
            this.btnEditMobile,
            this.toolStripSeparator2,
            this.btnDeleteMobile,
            this.toolStripSeparator3,
            this.btnRefresh,
            this.txtSearch,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(682, 91);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 91);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 91);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(88, 91);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 88);
            this.toolStripLabel1.Text = "جستجو :‌ ";
            // 
            // btnAddMobile
            // 
            this.btnAddMobile.Image = global::Accounting.App.Properties.Resources.icons8_add_64;
            this.btnAddMobile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddMobile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMobile.Name = "btnAddMobile";
            this.btnAddMobile.Size = new System.Drawing.Size(68, 88);
            this.btnAddMobile.Text = "افزودن";
            this.btnAddMobile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMobile.Click += new System.EventHandler(this.btnAddMobile_Click);
            // 
            // btnEditMobile
            // 
            this.btnEditMobile.Image = global::Accounting.App.Properties.Resources.icons8_edit_property_64;
            this.btnEditMobile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditMobile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditMobile.Name = "btnEditMobile";
            this.btnEditMobile.Size = new System.Drawing.Size(68, 88);
            this.btnEditMobile.Text = "ویرایش";
            this.btnEditMobile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditMobile.Click += new System.EventHandler(this.btnEditMobile_Click);
            // 
            // btnDeleteMobile
            // 
            this.btnDeleteMobile.Image = global::Accounting.App.Properties.Resources.icons8_delete_64;
            this.btnDeleteMobile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteMobile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMobile.Name = "btnDeleteMobile";
            this.btnDeleteMobile.Size = new System.Drawing.Size(68, 88);
            this.btnDeleteMobile.Text = "حذف";
            this.btnDeleteMobile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteMobile.Click += new System.EventHandler(this.btnDeleteMobile_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Accounting.App.Properties.Resources.icons8_refresh_64;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(76, 88);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMobiles);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMobile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کنترل موبایل ها";
            this.Load += new System.EventHandler(this.frmMobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobiles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMobiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddMobile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditMobile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDeleteMobile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}