namespace EZNotepad_redesign
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.edit = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Slider_Font = new MaterialSkin.Controls.MaterialSlider();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.Cb_Darkmode = new MaterialSkin.Controls.MaterialCheckbox();
            this.Charcount = new MaterialSkin.Controls.MaterialLabel();
            this.UpdatePerformCounter = new System.Windows.Forms.Timer(this.components);
            this.Bn_Open = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.Bn_Save = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.BN_New = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit.Depth = 0;
            this.edit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.edit.Location = new System.Drawing.Point(2, 113);
            this.edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit.Name = "edit";
            this.edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edit.Size = new System.Drawing.Size(1121, 450);
            this.edit.TabIndex = 0;
            this.edit.Text = "";
            this.edit.DragDrop += new System.Windows.Forms.DragEventHandler(this.edit_dragdrop);
            this.edit.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.edit_LinkClicked);
            // 
            // Slider_Font
            // 
            this.Slider_Font.Depth = 0;
            this.Slider_Font.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Slider_Font.Location = new System.Drawing.Point(6, 67);
            this.Slider_Font.MouseState = MaterialSkin.MouseState.HOVER;
            this.Slider_Font.Name = "Slider_Font";
            this.Slider_Font.RangeMax = 150;
            this.Slider_Font.RangeMin = 1;
            this.Slider_Font.Size = new System.Drawing.Size(259, 40);
            this.Slider_Font.TabIndex = 2;
            this.Slider_Font.Text = "Font size";
            this.Slider_Font.Value = 11;
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 50;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // Cb_Darkmode
            // 
            this.Cb_Darkmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_Darkmode.Depth = 0;
            this.Cb_Darkmode.Location = new System.Drawing.Point(1009, 570);
            this.Cb_Darkmode.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Darkmode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Cb_Darkmode.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cb_Darkmode.Name = "Cb_Darkmode";
            this.Cb_Darkmode.ReadOnly = false;
            this.Cb_Darkmode.Ripple = true;
            this.Cb_Darkmode.Size = new System.Drawing.Size(113, 37);
            this.Cb_Darkmode.TabIndex = 5;
            this.Cb_Darkmode.Text = "Darkmode";
            this.Cb_Darkmode.UseVisualStyleBackColor = true;
            this.Cb_Darkmode.CheckedChanged += new System.EventHandler(this.Cb_Darkmode_CheckedChanged);
            // 
            // Charcount
            // 
            this.Charcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Charcount.AutoSize = true;
            this.Charcount.Depth = 0;
            this.Charcount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Charcount.Location = new System.Drawing.Point(6, 579);
            this.Charcount.MouseState = MaterialSkin.MouseState.HOVER;
            this.Charcount.Name = "Charcount";
            this.Charcount.Size = new System.Drawing.Size(210, 19);
            this.Charcount.TabIndex = 6;
            this.Charcount.Text = "Current document char count:";
            // 
            // Bn_Open
            // 
            this.Bn_Open.Depth = 0;
            this.Bn_Open.Icon = global::EZNotepad_redesign.Properties.Resources.Icon_Open;
            this.Bn_Open.Location = new System.Drawing.Point(286, 67);
            this.Bn_Open.Mini = true;
            this.Bn_Open.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bn_Open.Name = "Bn_Open";
            this.Bn_Open.Size = new System.Drawing.Size(40, 47);
            this.Bn_Open.TabIndex = 8;
            this.Bn_Open.Text = "materialFloatingActionButton1";
            this.Bn_Open.UseVisualStyleBackColor = true;
            this.Bn_Open.Click += new System.EventHandler(this.Bn_Open_Click);
            // 
            // Bn_Save
            // 
            this.Bn_Save.Depth = 0;
            this.Bn_Save.Icon = global::EZNotepad_redesign.Properties.Resources.Icon_Save2;
            this.Bn_Save.Location = new System.Drawing.Point(332, 67);
            this.Bn_Save.Mini = true;
            this.Bn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bn_Save.Name = "Bn_Save";
            this.Bn_Save.Size = new System.Drawing.Size(40, 47);
            this.Bn_Save.TabIndex = 9;
            this.Bn_Save.Text = "materialFloatingActionButton2";
            this.Bn_Save.UseVisualStyleBackColor = true;
            this.Bn_Save.Click += new System.EventHandler(this.Bn_Save_Click);
            // 
            // BN_New
            // 
            this.BN_New.Depth = 0;
            this.BN_New.Icon = ((System.Drawing.Image)(resources.GetObject("BN_New.Icon")));
            this.BN_New.Location = new System.Drawing.Point(378, 67);
            this.BN_New.Mini = true;
            this.BN_New.MouseState = MaterialSkin.MouseState.HOVER;
            this.BN_New.Name = "BN_New";
            this.BN_New.Size = new System.Drawing.Size(40, 47);
            this.BN_New.TabIndex = 10;
            this.BN_New.Text = "materialFloatingActionButton3";
            this.BN_New.UseVisualStyleBackColor = true;
            this.BN_New.Click += new System.EventHandler(this.BN_New_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 610);
            this.Controls.Add(this.BN_New);
            this.Controls.Add(this.Bn_Save);
            this.Controls.Add(this.Bn_Open);
            this.Controls.Add(this.Charcount);
            this.Controls.Add(this.Cb_Darkmode);
            this.Controls.Add(this.Slider_Font);
            this.Controls.Add(this.edit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EZNotepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox edit;
        private MaterialSkin.Controls.MaterialSlider Slider_Font;
        private System.Windows.Forms.Timer Update;
        private MaterialSkin.Controls.MaterialCheckbox Cb_Darkmode;
        private MaterialSkin.Controls.MaterialLabel Charcount;
        private System.Windows.Forms.Timer UpdatePerformCounter;
        private MaterialSkin.Controls.MaterialFloatingActionButton Bn_Open;
        private MaterialSkin.Controls.MaterialFloatingActionButton Bn_Save;
        private MaterialSkin.Controls.MaterialFloatingActionButton BN_New;
    }
}

