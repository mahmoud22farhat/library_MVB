namespace LibraryMVB.views.forms
{
    partial class frm_BooksSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BooksSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.DGVsearch = new System.Windows.Forms.DataGridView();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.rbtn_all = new System.Windows.Forms.RadioButton();
            this.rbtnonebook = new System.Windows.Forms.RadioButton();
            this.cbx_Books = new System.Windows.Forms.ComboBox();
            this.cbx_Cat = new System.Windows.Forms.ComboBox();
            this.Rbtn_CAT = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "البحث عن الكتب";
            // 
            // DGVsearch
            // 
            this.DGVsearch.AllowUserToAddRows = false;
            this.DGVsearch.AllowUserToDeleteRows = false;
            this.DGVsearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVsearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVsearch.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVsearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVsearch.Location = new System.Drawing.Point(12, 94);
            this.DGVsearch.Name = "DGVsearch";
            this.DGVsearch.ReadOnly = true;
            this.DGVsearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
            this.DGVsearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVsearch.Size = new System.Drawing.Size(980, 396);
            this.DGVsearch.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(844, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(148, 41);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rbtn_all
            // 
            this.rbtn_all.AutoSize = true;
            this.rbtn_all.Checked = true;
            this.rbtn_all.Location = new System.Drawing.Point(12, 59);
            this.rbtn_all.Name = "rbtn_all";
            this.rbtn_all.Size = new System.Drawing.Size(82, 29);
            this.rbtn_all.TabIndex = 3;
            this.rbtn_all.TabStop = true;
            this.rbtn_all.Text = "كل الكتب";
            this.rbtn_all.UseVisualStyleBackColor = true;
            // 
            // rbtnonebook
            // 
            this.rbtnonebook.AutoSize = true;
            this.rbtnonebook.Location = new System.Drawing.Point(100, 59);
            this.rbtnonebook.Name = "rbtnonebook";
            this.rbtnonebook.Size = new System.Drawing.Size(88, 29);
            this.rbtnonebook.TabIndex = 4;
            this.rbtnonebook.Text = "كتاب محدد";
            this.rbtnonebook.UseVisualStyleBackColor = true;
            // 
            // cbx_Books
            // 
            this.cbx_Books.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Books.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Books.FormattingEnabled = true;
            this.cbx_Books.Location = new System.Drawing.Point(194, 58);
            this.cbx_Books.Name = "cbx_Books";
            this.cbx_Books.Size = new System.Drawing.Size(168, 33);
            this.cbx_Books.TabIndex = 26;
            // 
            // cbx_Cat
            // 
            this.cbx_Cat.FormattingEnabled = true;
            this.cbx_Cat.Location = new System.Drawing.Point(509, 58);
            this.cbx_Cat.Name = "cbx_Cat";
            this.cbx_Cat.Size = new System.Drawing.Size(168, 33);
            this.cbx_Cat.TabIndex = 27;
            // 
            // Rbtn_CAT
            // 
            this.Rbtn_CAT.AutoSize = true;
            this.Rbtn_CAT.Location = new System.Drawing.Point(391, 62);
            this.Rbtn_CAT.Name = "Rbtn_CAT";
            this.Rbtn_CAT.Size = new System.Drawing.Size(108, 29);
            this.Rbtn_CAT.TabIndex = 28;
            this.Rbtn_CAT.Text = "التصنيف العام";
            this.Rbtn_CAT.UseVisualStyleBackColor = true;
            // 
            // frm_BooksSearch
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 502);
            this.Controls.Add(this.Rbtn_CAT);
            this.Controls.Add(this.cbx_Cat);
            this.Controls.Add(this.cbx_Books);
            this.Controls.Add(this.rbtnonebook);
            this.Controls.Add(this.rbtn_all);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.DGVsearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frm_BooksSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة البحث عن الكتب";
            this.Load += new System.EventHandler(this.frm_BooksSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVsearch;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.RadioButton rbtn_all;
        private System.Windows.Forms.RadioButton rbtnonebook;
        private System.Windows.Forms.ComboBox cbx_Books;
        private System.Windows.Forms.ComboBox cbx_Cat;
        private System.Windows.Forms.RadioButton Rbtn_CAT;
    }
}