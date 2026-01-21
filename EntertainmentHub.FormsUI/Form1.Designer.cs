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
            this.button_crossmark = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_productions)).BeginInit();
            this.panel_titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_productions
            // 
            this.dgw_productions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_productions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_productions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_productions.Location = new System.Drawing.Point(20, 50);
            this.dgw_productions.Name = "dgw_productions";
            this.dgw_productions.ReadOnly = true;
            this.dgw_productions.Size = new System.Drawing.Size(960, 457);
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
            this.panel_titlebar.Size = new System.Drawing.Size(1000, 30);
            this.panel_titlebar.TabIndex = 1;
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
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
            this.button_crossmark.Location = new System.Drawing.Point(970, 0);
            this.button_crossmark.Name = "button_crossmark";
            this.button_crossmark.Size = new System.Drawing.Size(30, 30);
            this.button_crossmark.TabIndex = 0;
            this.button_crossmark.UseVisualStyleBackColor = true;
            this.button_crossmark.Click += new System.EventHandler(this.button_crossmark_Click);
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
            this.button_minimize.Location = new System.Drawing.Point(910, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(30, 30);
            this.button_minimize.TabIndex = 1;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
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
            this.button_restore.Location = new System.Drawing.Point(940, 0);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(30, 30);
            this.button_restore.TabIndex = 2;
            this.button_restore.UseVisualStyleBackColor = true;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.dgw_productions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_productions)).EndInit();
            this.panel_titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_productions;
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Button button_crossmark;
        private System.Windows.Forms.Button button_restore;
        private System.Windows.Forms.Button button_minimize;
    }
}

