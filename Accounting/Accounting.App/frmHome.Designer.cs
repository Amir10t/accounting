﻿namespace Accounting.App
{
    partial class frmHome
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMobile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrders.Location = new System.Drawing.Point(0, 43);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(627, 510);
            this.dgvOrders.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(627, 43);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetting.Image = global::Accounting.App.Properties.Resources.icons8_setting_64;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(24, 40);
            this.btnSetting.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 40);
            this.toolStripLabel1.Text = "جستجو :‌ ";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 43);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.btnMobile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(627, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Accounting.App.Properties.Resources.icons8_delete_64;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(6, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 88);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Accounting.App.Properties.Resources.icons8_edit_property_64;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(6, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 88);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Image = global::Accounting.App.Properties.Resources.icons8_create_order_64;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.Location = new System.Drawing.Point(6, 106);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(137, 88);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "سفارش";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnMobile
            // 
            this.btnMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobile.Image = global::Accounting.App.Properties.Resources.icons8_medical_mobile_app_64;
            this.btnMobile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMobile.Location = new System.Drawing.Point(6, 12);
            this.btnMobile.Name = "btnMobile";
            this.btnMobile.Size = new System.Drawing.Size(137, 88);
            this.btnMobile.TabIndex = 0;
            this.btnMobile.Text = "موبایل";
            this.btnMobile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMobile.UseVisualStyleBackColor = true;
            this.btnMobile.Click += new System.EventHandler(this.btnMobile_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه ی اصلی";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMobile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOrder;
    }
}