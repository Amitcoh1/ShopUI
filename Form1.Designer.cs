namespace ShopUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsListLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.ItemsCartBox = new System.Windows.Forms.ListBox();
            this.AddToCartButtun = new System.Windows.Forms.Button();
            this.PurchaseButtun = new System.Windows.Forms.Button();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.VendorBox = new System.Windows.Forms.ListBox();
            this.StorePaymentLabel = new System.Windows.Forms.Label();
            this.profitLabal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 25;
            this.ItemsListBox.Location = new System.Drawing.Point(62, 124);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(319, 179);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsListLabel
            // 
            this.ItemsListLabel.AutoSize = true;
            this.ItemsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ItemsListLabel.Location = new System.Drawing.Point(57, 92);
            this.ItemsListLabel.Name = "ItemsListLabel";
            this.ItemsListLabel.Size = new System.Drawing.Size(124, 29);
            this.ItemsListLabel.TabIndex = 3;
            this.ItemsListLabel.Text = "Items LIst";
            this.ItemsListLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Guttman Yad", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HeaderLabel.Location = new System.Drawing.Point(256, 24);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(724, 55);
            this.HeaderLabel.TabIndex = 4;
            this.HeaderLabel.Text = "SHOPPING APPLICATION DEMO";
            this.HeaderLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ShoppingCartLabel.Location = new System.Drawing.Point(537, 92);
            this.ShoppingCartLabel.Name = "ShoppingCartLabel";
            this.ShoppingCartLabel.Size = new System.Drawing.Size(180, 29);
            this.ShoppingCartLabel.TabIndex = 6;
            this.ShoppingCartLabel.Text = "Shopping Cart";
            this.ShoppingCartLabel.Click += new System.EventHandler(this.ShoppingCartLabel_Click);
            // 
            // ItemsCartBox
            // 
            this.ItemsCartBox.FormattingEnabled = true;
            this.ItemsCartBox.ItemHeight = 25;
            this.ItemsCartBox.Location = new System.Drawing.Point(542, 124);
            this.ItemsCartBox.Name = "ItemsCartBox";
            this.ItemsCartBox.Size = new System.Drawing.Size(319, 179);
            this.ItemsCartBox.TabIndex = 5;
            this.ItemsCartBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddToCartButtun
            // 
            this.AddToCartButtun.Location = new System.Drawing.Point(387, 180);
            this.AddToCartButtun.Name = "AddToCartButtun";
            this.AddToCartButtun.Size = new System.Drawing.Size(149, 39);
            this.AddToCartButtun.TabIndex = 7;
            this.AddToCartButtun.Text = "Add to cart =>";
            this.AddToCartButtun.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.AddToCartButtun.UseVisualStyleBackColor = true;
            this.AddToCartButtun.Click += new System.EventHandler(this.AddToCartButtun_Click);
            // 
            // PurchaseButtun
            // 
            this.PurchaseButtun.Location = new System.Drawing.Point(713, 309);
            this.PurchaseButtun.Name = "PurchaseButtun";
            this.PurchaseButtun.Size = new System.Drawing.Size(148, 38);
            this.PurchaseButtun.TabIndex = 8;
            this.PurchaseButtun.Text = "Purchase";
            this.PurchaseButtun.UseVisualStyleBackColor = true;
            this.PurchaseButtun.Click += new System.EventHandler(this.PurchaseButtun_Click);
            // 
            // VendorLabel
            // 
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.VendorLabel.Location = new System.Drawing.Point(919, 92);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(110, 29);
            this.VendorLabel.TabIndex = 10;
            this.VendorLabel.Text = "Vendors";
            this.VendorLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // VendorBox
            // 
            this.VendorBox.FormattingEnabled = true;
            this.VendorBox.ItemHeight = 25;
            this.VendorBox.Location = new System.Drawing.Point(920, 124);
            this.VendorBox.Name = "VendorBox";
            this.VendorBox.Size = new System.Drawing.Size(151, 179);
            this.VendorBox.TabIndex = 9;
            this.VendorBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // StorePaymentLabel
            // 
            this.StorePaymentLabel.AutoSize = true;
            this.StorePaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StorePaymentLabel.Location = new System.Drawing.Point(921, 306);
            this.StorePaymentLabel.Name = "StorePaymentLabel";
            this.StorePaymentLabel.Size = new System.Drawing.Size(96, 17);
            this.StorePaymentLabel.TabIndex = 11;
            this.StorePaymentLabel.Text = "Store Profit:";
            this.StorePaymentLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // profitLabal
            // 
            this.profitLabal.AutoSize = true;
            this.profitLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.profitLabal.Location = new System.Drawing.Point(1022, 306);
            this.profitLabal.Name = "profitLabal";
            this.profitLabal.Size = new System.Drawing.Size(49, 17);
            this.profitLabal.TabIndex = 12;
            this.profitLabal.Text = "$0.00";
            this.profitLabal.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 517);
            this.Controls.Add(this.profitLabal);
            this.Controls.Add(this.StorePaymentLabel);
            this.Controls.Add(this.VendorLabel);
            this.Controls.Add(this.VendorBox);
            this.Controls.Add(this.PurchaseButtun);
            this.Controls.Add(this.AddToCartButtun);
            this.Controls.Add(this.ShoppingCartLabel);
            this.Controls.Add(this.ItemsCartBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ItemsListLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Shop UI Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsListLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ShoppingCartLabel;
        private System.Windows.Forms.ListBox ItemsCartBox;
        private System.Windows.Forms.Button AddToCartButtun;
        private System.Windows.Forms.Button PurchaseButtun;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.ListBox VendorBox;
        private System.Windows.Forms.Label StorePaymentLabel;
        private System.Windows.Forms.Label profitLabal;
    }
}

