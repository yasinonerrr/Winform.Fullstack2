namespace Winform.Fullstack2.Forms
{
    partial class ProductsForm
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
            listProducts = new ListBox();
            txtProductName = new RichTextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            lblTest = new Label();
            label1 = new Label();
            lblUser = new Label();
            txtStock = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listProducts
            // 
            listProducts.FormattingEnabled = true;
            listProducts.ItemHeight = 22;
            listProducts.Location = new Point(57, 58);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(414, 686);
            listProducts.TabIndex = 0;
            listProducts.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(477, 58);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(609, 167);
            txtProductName.TabIndex = 1;
            txtProductName.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(477, 309);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(609, 61);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(477, 376);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(609, 61);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(758, 722);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(70, 22);
            lblTest.TabIndex = 3;
            lblTest.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 638);
            label1.Name = "label1";
            label1.Size = new Size(240, 22);
            label1.TabIndex = 3;
            label1.Text = "Giriş Yapan Kullanıcı :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(761, 638);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 4;
            lblUser.Text = "label2";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(477, 252);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(609, 30);
            txtStock.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(477, 443);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(609, 61);
            btnClear.TabIndex = 2;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 882);
            Controls.Add(txtStock);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(lblTest);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(listProducts);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listProducts;
        private RichTextBox txtProductName;
        private Button btnAdd;
        private Button btnEdit;
        private Label lblTest;
        private Label label1;
        private Label lblUser;
        private TextBox txtStock;
        private Button btnClear;
    }
}