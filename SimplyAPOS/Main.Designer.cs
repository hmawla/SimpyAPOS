namespace SimplyAPOS
{
    partial class Main
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
            this.tbc_main = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_sell = new System.Windows.Forms.TabPage();
            this.tab_buy = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.lbl_cat = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Cat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOSDBDataSet = new SimplyAPOS.SPOSDBDataSet();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new SimplyAPOS.SPOSDBDataSetTableAdapters.ItemsTableAdapter();
            this.categoryTableAdapter = new SimplyAPOS.SPOSDBDataSetTableAdapters.CategoryTableAdapter();
            this.tbc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_main
            // 
            this.tbc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_main.Controls.Add(this.tab_sell);
            this.tbc_main.Controls.Add(this.tab_buy);
            this.tbc_main.Depth = 0;
            this.tbc_main.Location = new System.Drawing.Point(12, 102);
            this.tbc_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbc_main.Name = "tbc_main";
            this.tbc_main.SelectedIndex = 0;
            this.tbc_main.Size = new System.Drawing.Size(577, 375);
            this.tbc_main.TabIndex = 0;
            // 
            // tab_sell
            // 
            this.tab_sell.Location = new System.Drawing.Point(4, 22);
            this.tab_sell.Name = "tab_sell";
            this.tab_sell.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sell.Size = new System.Drawing.Size(569, 349);
            this.tab_sell.TabIndex = 0;
            this.tab_sell.Text = "SELL";
            this.tab_sell.UseVisualStyleBackColor = true;
            this.tab_sell.Click += new System.EventHandler(this.Tab_sell_Click);
            // 
            // tab_buy
            // 
            this.tab_buy.AutoScroll = true;
            this.tab_buy.Location = new System.Drawing.Point(4, 22);
            this.tab_buy.Name = "tab_buy";
            this.tab_buy.Padding = new System.Windows.Forms.Padding(3);
            this.tab_buy.Size = new System.Drawing.Size(569, 349);
            this.tab_buy.TabIndex = 1;
            this.tab_buy.Text = "BUY";
            this.tab_buy.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tbc_main;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(772, 32);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // lbl_cat
            // 
            this.lbl_cat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.BackColor = System.Drawing.Color.White;
            this.lbl_cat.Depth = 0;
            this.lbl_cat.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_cat.Location = new System.Drawing.Point(595, 140);
            this.lbl_cat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(73, 19);
            this.lbl_cat.TabIndex = 0;
            this.lbl_cat.Text = "Category:";
            // 
            // CBox_Cat
            // 
            this.CBox_Cat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CBox_Cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBox_Cat.FormattingEnabled = true;
            this.CBox_Cat.Location = new System.Drawing.Point(598, 161);
            this.CBox_Cat.Name = "CBox_Cat";
            this.CBox_Cat.Size = new System.Drawing.Size(161, 21);
            this.CBox_Cat.TabIndex = 1;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.DBBindingSource;
            // 
            // DBBindingSource
            // 
            this.DBBindingSource.DataSource = this.sPOSDBDataSet;
            this.DBBindingSource.Position = 0;
            // 
            // sPOSDBDataSet
            // 
            this.sPOSDBDataSet.DataSetName = "SPOSDBDataSet";
            this.sPOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(598, 322);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(161, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "0";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(595, 300);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(35, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Qty:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(595, 348);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Total ($):";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(598, 370);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(161, 23);
            this.materialSingleLineTextField2.TabIndex = 4;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "0";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(641, 399);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(118, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "INVOICE INFO >";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(688, 441);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(71, 36);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Submit";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.DBBindingSource;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.CBox_Cat);
            this.Controls.Add(this.lbl_cat);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tbc_main);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Closed += new System.EventHandler(this.Main_Closed);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.Resize += new System.EventHandler(this.Main_Resized);
            this.tbc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbc_main;
        private System.Windows.Forms.TabPage tab_sell;
        private System.Windows.Forms.TabPage tab_buy;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel lbl_cat;
        private System.Windows.Forms.ComboBox CBox_Cat;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.BindingSource DBBindingSource;
        private SPOSDBDataSet sPOSDBDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SPOSDBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private SPOSDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}

