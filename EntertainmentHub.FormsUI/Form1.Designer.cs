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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.dgw_productions = new System.Windows.Forms.DataGridView();
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_crossmark = new System.Windows.Forms.Button();
            this.groupBox_filterByName = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox_filterByCategory = new System.Windows.Forms.GroupBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.groupBox_control_production = new System.Windows.Forms.GroupBox();
            this.label_current_time = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_operations_year = new System.Windows.Forms.TextBox();
            this.label_product_publicationYear = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_operations_inTheaters = new System.Windows.Forms.TextBox();
            this.label_product_inTheaters = new System.Windows.Forms.Label();
            this.textBox_operations_runtime = new System.Windows.Forms.TextBox();
            this.label_product_runtime = new System.Windows.Forms.Label();
            this.textBox_operations_category = new System.Windows.Forms.TextBox();
            this.label_product_category = new System.Windows.Forms.Label();
            this.textBox_operations_name = new System.Windows.Forms.TextBox();
            this.label_product_name = new System.Windows.Forms.Label();
            this.textBox_operations_id = new System.Windows.Forms.TextBox();
            this.label_product_id = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_productions)).BeginInit();
            this.panel_titlebar.SuspendLayout();
            this.groupBox_filterByName.SuspendLayout();
            this.groupBox_filterByCategory.SuspendLayout();
            this.groupBox_control_production.SuspendLayout();
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
            this.dgw_productions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_productions_CellClick);
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.panel_titlebar.Controls.Add(this.button_minimize);
            this.panel_titlebar.Controls.Add(this.button_crossmark);
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titlebar.Location = new System.Drawing.Point(0, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(800, 30);
            this.panel_titlebar.TabIndex = 1;
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
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
            this.button_minimize.Location = new System.Drawing.Point(740, 0);
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
            // groupBox_control_production
            // 
            this.groupBox_control_production.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_control_production.Controls.Add(this.label_current_time);
            this.groupBox_control_production.Controls.Add(this.button_clear);
            this.groupBox_control_production.Controls.Add(this.button_delete);
            this.groupBox_control_production.Controls.Add(this.textBox_operations_year);
            this.groupBox_control_production.Controls.Add(this.label_product_publicationYear);
            this.groupBox_control_production.Controls.Add(this.button_update);
            this.groupBox_control_production.Controls.Add(this.button_add);
            this.groupBox_control_production.Controls.Add(this.textBox_operations_inTheaters);
            this.groupBox_control_production.Controls.Add(this.label_product_inTheaters);
            this.groupBox_control_production.Controls.Add(this.textBox_operations_runtime);
            this.groupBox_control_production.Controls.Add(this.label_product_runtime);
            this.groupBox_control_production.Controls.Add(this.textBox_operations_category);
            this.groupBox_control_production.Controls.Add(this.label_product_category);
            this.groupBox_control_production.Controls.Add(this.textBox_operations_name);
            this.groupBox_control_production.Controls.Add(this.label_product_name);
            this.groupBox_control_production.Controls.Add(this.textBox_operations_id);
            this.groupBox_control_production.Controls.Add(this.label_product_id);
            this.groupBox_control_production.Location = new System.Drawing.Point(20, 453);
            this.groupBox_control_production.Name = "groupBox_control_production";
            this.groupBox_control_production.Size = new System.Drawing.Size(760, 273);
            this.groupBox_control_production.TabIndex = 3;
            this.groupBox_control_production.TabStop = false;
            this.groupBox_control_production.Text = "Operations";
            // 
            // label_current_time
            // 
            this.label_current_time.AutoSize = true;
            this.label_current_time.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_current_time.Location = new System.Drawing.Point(444, 194);
            this.label_current_time.Name = "label_current_time";
            this.label_current_time.Size = new System.Drawing.Size(0, 29);
            this.label_current_time.TabIndex = 12;
            this.label_current_time.Click += new System.EventHandler(this.label_current_time_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear.BackgroundImage")));
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Location = new System.Drawing.Point(310, 191);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(40, 40);
            this.button_clear.TabIndex = 3;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_delete.BackgroundImage")));
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Location = new System.Drawing.Point(220, 191);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(40, 40);
            this.button_delete.TabIndex = 2;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_operations_year
            // 
            this.textBox_operations_year.Location = new System.Drawing.Point(507, 109);
            this.textBox_operations_year.Name = "textBox_operations_year";
            this.textBox_operations_year.Size = new System.Drawing.Size(230, 20);
            this.textBox_operations_year.TabIndex = 11;
            // 
            // label_product_publicationYear
            // 
            this.label_product_publicationYear.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_product_publicationYear.AutoSize = true;
            this.label_product_publicationYear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_publicationYear.Location = new System.Drawing.Point(461, 110);
            this.label_product_publicationYear.Name = "label_product_publicationYear";
            this.label_product_publicationYear.Size = new System.Drawing.Size(40, 18);
            this.label_product_publicationYear.TabIndex = 10;
            this.label_product_publicationYear.Text = "Year";
            // 
            // button_update
            // 
            this.button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update.BackgroundImage")));
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(125, 191);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(40, 40);
            this.button_update.TabIndex = 1;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_add.BackgroundImage")));
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(43, 191);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(40, 40);
            this.button_add.TabIndex = 0;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_operations_inTheaters
            // 
            this.textBox_operations_inTheaters.Location = new System.Drawing.Point(507, 71);
            this.textBox_operations_inTheaters.Name = "textBox_operations_inTheaters";
            this.textBox_operations_inTheaters.Size = new System.Drawing.Size(230, 20);
            this.textBox_operations_inTheaters.TabIndex = 9;
            // 
            // label_product_inTheaters
            // 
            this.label_product_inTheaters.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_product_inTheaters.AutoSize = true;
            this.label_product_inTheaters.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_inTheaters.Location = new System.Drawing.Point(409, 72);
            this.label_product_inTheaters.Name = "label_product_inTheaters";
            this.label_product_inTheaters.Size = new System.Drawing.Size(92, 18);
            this.label_product_inTheaters.TabIndex = 8;
            this.label_product_inTheaters.Text = "In Theaters";
            // 
            // textBox_operations_runtime
            // 
            this.textBox_operations_runtime.Location = new System.Drawing.Point(507, 33);
            this.textBox_operations_runtime.Name = "textBox_operations_runtime";
            this.textBox_operations_runtime.Size = new System.Drawing.Size(230, 20);
            this.textBox_operations_runtime.TabIndex = 7;
            // 
            // label_product_runtime
            // 
            this.label_product_runtime.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_product_runtime.AutoSize = true;
            this.label_product_runtime.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_runtime.Location = new System.Drawing.Point(432, 34);
            this.label_product_runtime.Name = "label_product_runtime";
            this.label_product_runtime.Size = new System.Drawing.Size(69, 18);
            this.label_product_runtime.TabIndex = 6;
            this.label_product_runtime.Text = "Runtime";
            // 
            // textBox_operations_category
            // 
            this.textBox_operations_category.Location = new System.Drawing.Point(121, 109);
            this.textBox_operations_category.Name = "textBox_operations_category";
            this.textBox_operations_category.Size = new System.Drawing.Size(230, 20);
            this.textBox_operations_category.TabIndex = 5;
            // 
            // label_product_category
            // 
            this.label_product_category.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_product_category.AutoSize = true;
            this.label_product_category.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_category.Location = new System.Drawing.Point(27, 110);
            this.label_product_category.Name = "label_product_category";
            this.label_product_category.Size = new System.Drawing.Size(77, 18);
            this.label_product_category.TabIndex = 4;
            this.label_product_category.Text = "Category";
            // 
            // textBox_operations_name
            // 
            this.textBox_operations_name.Location = new System.Drawing.Point(121, 71);
            this.textBox_operations_name.Name = "textBox_operations_name";
            this.textBox_operations_name.Size = new System.Drawing.Size(230, 20);
            this.textBox_operations_name.TabIndex = 3;
            // 
            // label_product_name
            // 
            this.label_product_name.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_product_name.AutoSize = true;
            this.label_product_name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_name.Location = new System.Drawing.Point(52, 72);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(52, 18);
            this.label_product_name.TabIndex = 2;
            this.label_product_name.Text = "Name";
            // 
            // textBox_operations_id
            // 
            this.textBox_operations_id.Location = new System.Drawing.Point(121, 33);
            this.textBox_operations_id.Name = "textBox_operations_id";
            this.textBox_operations_id.ReadOnly = true;
            this.textBox_operations_id.Size = new System.Drawing.Size(230, 20);
            this.textBox_operations_id.TabIndex = 1;
            // 
            // label_product_id
            // 
            this.label_product_id.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label_product_id.AutoSize = true;
            this.label_product_id.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_product_id.Location = new System.Drawing.Point(80, 34);
            this.label_product_id.Name = "label_product_id";
            this.label_product_id.Size = new System.Drawing.Size(24, 18);
            this.label_product_id.TabIndex = 0;
            this.label_product_id.Text = "ID";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 743);
            this.Controls.Add(this.groupBox_control_production);
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
            this.groupBox_control_production.ResumeLayout(false);
            this.groupBox_control_production.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_productions;
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Button button_crossmark;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.GroupBox groupBox_filterByName;
        private System.Windows.Forms.GroupBox groupBox_filterByCategory;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.GroupBox groupBox_control_production;
        private System.Windows.Forms.TextBox textBox_operations_id;
        private System.Windows.Forms.Label label_product_id;
        private System.Windows.Forms.TextBox textBox_operations_inTheaters;
        private System.Windows.Forms.Label label_product_inTheaters;
        private System.Windows.Forms.TextBox textBox_operations_runtime;
        private System.Windows.Forms.Label label_product_runtime;
        private System.Windows.Forms.TextBox textBox_operations_category;
        private System.Windows.Forms.Label label_product_category;
        private System.Windows.Forms.TextBox textBox_operations_name;
        private System.Windows.Forms.Label label_product_name;
        private System.Windows.Forms.TextBox textBox_operations_year;
        private System.Windows.Forms.Label label_product_publicationYear;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_current_time;
        private System.Windows.Forms.Timer timer;
    }
}

