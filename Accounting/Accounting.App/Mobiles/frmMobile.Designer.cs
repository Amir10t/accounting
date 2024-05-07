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
            this.dgbMobiles = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddMobile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditMobile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteMobile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMobiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbMobiles
            // 
            this.dgbMobiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMobiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgbMobiles.Location = new System.Drawing.Point(0, 83);
            this.dgbMobiles.Name = "dgbMobiles";
            this.dgbMobiles.RowTemplate.Height = 24;
            this.dgbMobiles.Size = new System.Drawing.Size(682, 370);
            this.dgbMobiles.TabIndex = 2;
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
            // btnAddMobile
            // 
            this.btnAddMobile.Image = global::Accounting.App.Properties.Resources.icons8_add_64;
            this.btnAddMobile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddMobile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMobile.Name = "btnAddMobile";
            this.btnAddMobile.Size = new System.Drawing.Size(68, 88);
            this.btnAddMobile.Text = "افزودن";
            this.btnAddMobile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 91);
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 91);
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
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 88);
            this.toolStripLabel1.Text = "جستجو :‌ ";
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 91);
            // 
            // frmMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgbMobiles);
            this.Name = "frmMobile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کنترل موبایل ها";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMobiles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbMobiles;
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
    }
}