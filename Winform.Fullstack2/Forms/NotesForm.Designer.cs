namespace Winform.Fullstack2.Forms
{
    partial class NotesForm
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
            lblUser = new Label();
            label1 = new Label();
            lblTest = new Label();
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtDescription = new RichTextBox();
            listNote = new ListBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(716, 592);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 14;
            lblUser.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 592);
            label1.Name = "label1";
            label1.Size = new Size(240, 22);
            label1.TabIndex = 12;
            label1.Text = "Giriş Yapan Kullanıcı :";
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(713, 676);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(70, 22);
            lblTest.TabIndex = 13;
            lblTest.Text = "label1";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(432, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(609, 61);
            btnClear.TabIndex = 8;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(432, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(609, 61);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(432, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(609, 61);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(432, 12);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(609, 167);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 22;
            listNote.Location = new Point(12, 12);
            listNote.Name = "listNote";
            listNote.Size = new Size(414, 686);
            listNote.TabIndex = 6;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 739);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(lblTest);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(listNote);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NotesForm";
            Text = "NotesForm";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUser;
        private Label label1;
        private Label lblTest;
        private Button btnClear;
        private Button btnEdit;
        private Button btnAdd;
        private RichTextBox txtDescription;
        private ListBox listNote;
    }
}