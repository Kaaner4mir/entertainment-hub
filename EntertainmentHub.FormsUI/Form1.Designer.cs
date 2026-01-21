namespace EntertainmentHub.FormsUI
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.dgw_productions = new System.Windows.Forms.DataGridView();
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.button_restore = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_crossmark = new System.Windows.Forms.Button();
            this.groupBox_filterByName = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox_filterByCategory = new System.Windows.Forms.GroupBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_productions)).BeginInit();
            this.panel_titlebar.SuspendLayout();
            this.groupBox_filterByName.SuspendLayout();
            this.groupBox_filterByCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_productions
            // 
            this.dgw_productions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_productions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_productions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_productions.Location = new System.Drawing.Point(20, 170);
            this.dgw_productions.Name = "dgw_productions";
            this.dgw_productions.ReadOnly = true;
            this.dgw_productions.Size = new System.Drawing.Size(760, 263);
            this.dgw_productions.TabIndex = 0;
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.BackColor = System.Drawing.Color.Black;
            this.panel_titlebar.Controls.Add(this.button_restore);
            this.panel_titlebar.Controls.Add(this.button_minimize);
            this.panel_titlebar.Controls.Add(this.button_crossmark);
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titlebar.Location = new System.Drawing.Point(0, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(800, 30);
            this.panel_titlebar.TabIndex = 1;
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
            // 
            // button_restore
            // 
            this.button_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_restore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_restore.BackgroundImage")));
            this.button_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_restore.FlatAppearance.BorderSize = 0;
            this.button_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restore.Location = new System.Drawing.Point(740, 0);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(30, 30);
            this.button_restore.TabIndex = 2;
            this.button_restore.UseVisualStyleBackColor = true;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Location = new System.Drawing.Point(710, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(30, 30);
            this.button_minimize.TabIndex = 1;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_crossmark
            // 
            this.button_crossmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_crossmark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_crossmark.BackgroundImage")));
            this.button_crossmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_crossmark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_crossmark.FlatAppearance.BorderSize = 0;
            this.button_crossmark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_crossmark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_crossmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_crossmark.Location = new System.Drawing.Point(770, 0);
            this.button_crossmark.Name = "button_crossmark";
            this.button_crossmark.Size = new System.Drawing.Size(30, 30);
            this.button_crossmark.TabIndex = 0;
            this.button_crossmark.UseVisualStyleBackColor = true;
            this.button_crossmark.Click += new System.EventHandler(this.button_crossmark_Click);
            // 
            // groupBox_filterByName
            // 
            this.groupBox_filterByName.Controls.Add(this.textBox_name);
            this.groupBox_filterByName.Controls.Add(this.label_name);
            this.groupBox_filterByName.Location = new System.Drawing.Point(20, 50);
            this.groupBox_filterByName.Name = "groupBox_filterByName";
            this.groupBox_filterByName.Size = new System.Drawing.Size(364, 100);
            this.groupBox_filterByName.TabIndex = 2;
            this.groupBox_filterByName.TabStop = false;
            this.groupBox_filterByName.Text = "Filter by production name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(83, 38);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(267, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.Location = new System.Drawing.Point(16, 38);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // groupBox_filterByCategory
            // 
            this.groupBox_filterByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_filterByCategory.Controls.Add(this.textBox_category);
            this.groupBox_filterByCategory.Controls.Add(this.label_category);
            this.groupBox_filterByCategory.Location = new System.Drawing.Point(416, 50);
            this.groupBox_filterByCategory.Name = "groupBox_filterByCategory";
            this.groupBox_filterByCategory.Size = new System.Drawing.Size(364, 100);
            this.groupBox_filterByCategory.TabIndex = 3;
            this.groupBox_filterByCategory.TabStop = false;
            this.groupBox_filterByCategory.Text = "Filter by production category";
            // 
            // textBox_category
            // 
            this.textBox_category.Location = new System.Drawing.Point(114, 38);
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(240, 20);
            this.textBox_category.TabIndex = 2;
            this.textBox_category.TextChanged += new System.EventHandler(this.textBox_category_TextChanged);
            // 
            // label_category
            // 
            this.label_category.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_category.Location = new System.Drawing.Point(19, 38);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(77, 18);
            this.label_category.TabIndex = 1;
            this.label_category.Text = "Category";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.groupBox_filterByCategory);
            this.Controls.Add(this.groupBox_filterByName);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.dgw_productions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_productions)).EndInit();
            this.panel_titlebar.ResumeLayout(false);
            this.groupBox_filterByName.ResumeLayout(false);
            this.groupBox_filterByName.PerformLayout();
            this.groupBox_filterByCategory.ResumeLayout(false);
            this.groupBox_filterByCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_productions;
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Button button_crossmark;
        private System.Windows.Forms.Button button_restore;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.GroupBox groupBox_filterByName;
        private System.Windows.Forms.GroupBox groupBox_filterByCategory;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Label label_category;
    }
}

