namespace ProductPurchaseOrder
{
    partial class ProductDetail
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
            this.groupboxOrder = new System.Windows.Forms.GroupBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOke = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupboxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxOrder
            // 
            this.groupboxOrder.Controls.Add(this.numQuantity);
            this.groupboxOrder.Controls.Add(this.txtAmount);
            this.groupboxOrder.Controls.Add(this.txtPrice);
            this.groupboxOrder.Controls.Add(this.cbxProduct);
            this.groupboxOrder.Controls.Add(this.label4);
            this.groupboxOrder.Controls.Add(this.label3);
            this.groupboxOrder.Controls.Add(this.label2);
            this.groupboxOrder.Controls.Add(this.label1);
            this.groupboxOrder.Location = new System.Drawing.Point(28, 29);
            this.groupboxOrder.Name = "groupboxOrder";
            this.groupboxOrder.Size = new System.Drawing.Size(362, 290);
            this.groupboxOrder.TabIndex = 0;
            this.groupboxOrder.TabStop = false;
            this.groupboxOrder.Text = "Product Detail";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(137, 168);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(202, 28);
            this.numQuantity.TabIndex = 8;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(137, 224);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(202, 28);
            this.txtAmount.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(202, 28);
            this.txtPrice.TabIndex = 5;
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(137, 55);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(202, 29);
            this.cbxProduct.TabIndex = 4;
            this.cbxProduct.SelectedIndexChanged += new System.EventHandler(this.cbxProduct_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // btnOke
            // 
            this.btnOke.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOke.Location = new System.Drawing.Point(149, 355);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(106, 40);
            this.btnOke.TabIndex = 1;
            this.btnOke.Text = "&OK";
            this.btnOke.UseVisualStyleBackColor = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(284, 355);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(106, 40);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "&Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 430);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOke);
            this.Controls.Add(this.groupboxOrder);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductDetail";
            this.Text = "Product Detail";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            this.groupboxOrder.ResumeLayout(false);
            this.groupboxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Button btnOke;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.NumericUpDown numQuantity;
    }
}