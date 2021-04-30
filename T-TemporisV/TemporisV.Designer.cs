
namespace T_TemporisV
{
    partial class T_TemporisV
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_TemporisV));
            this.search_B = new MaterialSkin.Controls.MaterialButton();
            this.dropCards_LV = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.craftCards_LV = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.export_B = new MaterialSkin.Controls.MaterialButton();
            this.startLevel_CB = new MaterialSkin.Controls.MaterialComboBox();
            this.finishLevel_CB = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // search_B
            // 
            this.search_B.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_B.Depth = 0;
            this.search_B.DrawShadows = true;
            this.search_B.HighEmphasis = true;
            this.search_B.Icon = null;
            this.search_B.Location = new System.Drawing.Point(353, 232);
            this.search_B.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.search_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_B.Name = "search_B";
            this.search_B.Size = new System.Drawing.Size(95, 36);
            this.search_B.TabIndex = 0;
            this.search_B.Text = "Cherche !";
            this.search_B.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.search_B.UseAccentColor = false;
            this.search_B.UseVisualStyleBackColor = true;
            this.search_B.Click += new System.EventHandler(this.search_B_Click);
            // 
            // dropCards_LV
            // 
            this.dropCards_LV.AutoSizeTable = false;
            this.dropCards_LV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dropCards_LV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dropCards_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.dropCards_LV.Depth = 0;
            this.dropCards_LV.FullRowSelect = true;
            this.dropCards_LV.HideSelection = false;
            this.dropCards_LV.Location = new System.Drawing.Point(28, 120);
            this.dropCards_LV.MinimumSize = new System.Drawing.Size(200, 100);
            this.dropCards_LV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dropCards_LV.MouseState = MaterialSkin.MouseState.OUT;
            this.dropCards_LV.Name = "dropCards_LV";
            this.dropCards_LV.OwnerDraw = true;
            this.dropCards_LV.Size = new System.Drawing.Size(270, 270);
            this.dropCards_LV.TabIndex = 1;
            this.dropCards_LV.UseCompatibleStateImageBehavior = false;
            this.dropCards_LV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "                     Carte(s) à drop";
            this.columnHeader1.Width = 270;
            // 
            // craftCards_LV
            // 
            this.craftCards_LV.AutoSizeTable = false;
            this.craftCards_LV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.craftCards_LV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.craftCards_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.craftCards_LV.Depth = 0;
            this.craftCards_LV.FullRowSelect = true;
            this.craftCards_LV.HideSelection = false;
            this.craftCards_LV.Location = new System.Drawing.Point(500, 120);
            this.craftCards_LV.MinimumSize = new System.Drawing.Size(200, 100);
            this.craftCards_LV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.craftCards_LV.MouseState = MaterialSkin.MouseState.OUT;
            this.craftCards_LV.MultiSelect = false;
            this.craftCards_LV.Name = "craftCards_LV";
            this.craftCards_LV.OwnerDraw = true;
            this.craftCards_LV.Size = new System.Drawing.Size(270, 270);
            this.craftCards_LV.TabIndex = 4;
            this.craftCards_LV.UseCompatibleStateImageBehavior = false;
            this.craftCards_LV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "                      Carte(s) à crafter";
            this.columnHeader2.Width = 270;
            // 
            // export_B
            // 
            this.export_B.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.export_B.Depth = 0;
            this.export_B.DrawShadows = true;
            this.export_B.Enabled = false;
            this.export_B.HighEmphasis = true;
            this.export_B.Icon = null;
            this.export_B.Location = new System.Drawing.Point(549, 75);
            this.export_B.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.export_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.export_B.Name = "export_B";
            this.export_B.Size = new System.Drawing.Size(179, 36);
            this.export_B.TabIndex = 3;
            this.export_B.Text = "Exporter recette(s)";
            this.export_B.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.export_B.UseAccentColor = true;
            this.export_B.UseVisualStyleBackColor = true;
            this.export_B.Click += new System.EventHandler(this.export_B_Click);
            // 
            // startLevel_CB
            // 
            this.startLevel_CB.AutoResize = false;
            this.startLevel_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startLevel_CB.Depth = 0;
            this.startLevel_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.startLevel_CB.DropDownHeight = 118;
            this.startLevel_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startLevel_CB.DropDownWidth = 121;
            this.startLevel_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.startLevel_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startLevel_CB.FormattingEnabled = true;
            this.startLevel_CB.IntegralHeight = false;
            this.startLevel_CB.ItemHeight = 29;
            this.startLevel_CB.Location = new System.Drawing.Point(340, 188);
            this.startLevel_CB.MaxDropDownItems = 4;
            this.startLevel_CB.MouseState = MaterialSkin.MouseState.OUT;
            this.startLevel_CB.Name = "startLevel_CB";
            this.startLevel_CB.Size = new System.Drawing.Size(121, 35);
            this.startLevel_CB.StartIndex = 0;
            this.startLevel_CB.TabIndex = 7;
            this.startLevel_CB.UseTallSize = false;
            // 
            // finishLevel_CB
            // 
            this.finishLevel_CB.AutoResize = false;
            this.finishLevel_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.finishLevel_CB.Depth = 0;
            this.finishLevel_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.finishLevel_CB.DropDownHeight = 118;
            this.finishLevel_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishLevel_CB.DropDownWidth = 121;
            this.finishLevel_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.finishLevel_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.finishLevel_CB.FormattingEnabled = true;
            this.finishLevel_CB.IntegralHeight = false;
            this.finishLevel_CB.ItemHeight = 29;
            this.finishLevel_CB.Location = new System.Drawing.Point(340, 277);
            this.finishLevel_CB.MaxDropDownItems = 4;
            this.finishLevel_CB.MouseState = MaterialSkin.MouseState.OUT;
            this.finishLevel_CB.Name = "finishLevel_CB";
            this.finishLevel_CB.Size = new System.Drawing.Size(121, 35);
            this.finishLevel_CB.StartIndex = 0;
            this.finishLevel_CB.TabIndex = 8;
            this.finishLevel_CB.UseTallSize = false;
            // 
            // T_TemporisV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.finishLevel_CB);
            this.Controls.Add(this.startLevel_CB);
            this.Controls.Add(this.export_B);
            this.Controls.Add(this.craftCards_LV);
            this.Controls.Add(this.dropCards_LV);
            this.Controls.Add(this.search_B);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "T_TemporisV";
            this.Text = "T-TemporisV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ColumnHeader columnHeader2;

        #endregion

        private MaterialSkin.Controls.MaterialButton search_B;
        private MaterialSkin.Controls.MaterialListView dropCards_LV;
        private MaterialSkin.Controls.MaterialListView craftCards_LV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialButton export_B;
        private MaterialSkin.Controls.MaterialComboBox startLevel_CB;
        private MaterialSkin.Controls.MaterialComboBox finishLevel_CB;
    }
}

