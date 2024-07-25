namespace Accounting.App
{
    partial class frmAddOrEditOrder
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
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rbAutoAmount = new System.Windows.Forms.RadioButton();
            this.rbOwnAmount = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(10, 12);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(229, 24);
            this.cbProducts.TabIndex = 0;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(10, 57);
            this.nudAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(129, 23);
            this.nudAmount.TabIndex = 1;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(10, 85);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(129, 23);
            this.txtAmount.TabIndex = 2;
            // 
            // rbAutoAmount
            // 
            this.rbAutoAmount.AutoSize = true;
            this.rbAutoAmount.Location = new System.Drawing.Point(145, 87);
            this.rbAutoAmount.Name = "rbAutoAmount";
            this.rbAutoAmount.Size = new System.Drawing.Size(138, 21);
            this.rbAutoAmount.TabIndex = 3;
            this.rbAutoAmount.TabStop = true;
            this.rbAutoAmount.Text = "قیمت دهی خودکار";
            this.rbAutoAmount.UseVisualStyleBackColor = true;
            this.rbAutoAmount.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rbOwnAmount
            // 
            this.rbOwnAmount.AutoSize = true;
            this.rbOwnAmount.Location = new System.Drawing.Point(180, 59);
            this.rbOwnAmount.Name = "rbOwnAmount";
            this.rbOwnAmount.Size = new System.Drawing.Size(103, 21);
            this.rbOwnAmount.TabIndex = 4;
            this.rbOwnAmount.TabStop = true;
            this.rbOwnAmount.Text = "قیمت دلخواه";
            this.rbOwnAmount.UseVisualStyleBackColor = true;
            this.rbOwnAmount.CheckedChanged += new System.EventHandler(this.rbOwnAmount_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 161);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(273, 128);
            this.txtDescription.TabIndex = 5;
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(10, 295);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(273, 46);
            this.btnSumbit.TabIndex = 6;
            this.btnSumbit.Text = "افزودن";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "توضیحات : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "کالا : ";
            // 
            // frmAddOrEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.rbOwnAmount);
            this.Controls.Add(this.rbAutoAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.cbProducts);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(313, 400);
            this.MinimumSize = new System.Drawing.Size(313, 400);
            this.Name = "frmAddOrEditOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن سفارش";
            this.Load += new System.EventHandler(this.frmAddOrEditOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton rbAutoAmount;
        private System.Windows.Forms.RadioButton rbOwnAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProducts;
    }
}