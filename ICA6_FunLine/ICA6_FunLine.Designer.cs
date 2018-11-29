namespace ICA6_FunLine
{
    partial class ICA6_FunLine
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
            this.B_Populate = new System.Windows.Forms.Button();
            this.B_LenAsc = new System.Windows.Forms.Button();
            this.B_LenDesc = new System.Windows.Forms.Button();
            this.B_Width = new System.Windows.Forms.Button();
            this.B_WidthHeight = new System.Windows.Forms.Button();
            this.B_RemStub = new System.Windows.Forms.Button();
            this.B_RemLong = new System.Windows.Forms.Button();
            this.TrB_Length = new System.Windows.Forms.TrackBar();
            this.LB_Length = new System.Windows.Forms.Label();
            this.LB_MinMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrB_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Populate
            // 
            this.B_Populate.Location = new System.Drawing.Point(13, 13);
            this.B_Populate.Name = "B_Populate";
            this.B_Populate.Size = new System.Drawing.Size(186, 23);
            this.B_Populate.TabIndex = 0;
            this.B_Populate.Text = "Populate";
            this.B_Populate.UseVisualStyleBackColor = true;
            this.B_Populate.Click += new System.EventHandler(this.B_Populate_Click);
            // 
            // B_LenAsc
            // 
            this.B_LenAsc.Enabled = false;
            this.B_LenAsc.Location = new System.Drawing.Point(212, 13);
            this.B_LenAsc.Name = "B_LenAsc";
            this.B_LenAsc.Size = new System.Drawing.Size(186, 23);
            this.B_LenAsc.TabIndex = 1;
            this.B_LenAsc.Text = "Sort by Length Ascending";
            this.B_LenAsc.UseVisualStyleBackColor = true;
            this.B_LenAsc.Click += new System.EventHandler(this.B_LenAsc_Click);
            // 
            // B_LenDesc
            // 
            this.B_LenDesc.Enabled = false;
            this.B_LenDesc.Location = new System.Drawing.Point(212, 42);
            this.B_LenDesc.Name = "B_LenDesc";
            this.B_LenDesc.Size = new System.Drawing.Size(186, 23);
            this.B_LenDesc.TabIndex = 2;
            this.B_LenDesc.Text = "Sort by Length Descending";
            this.B_LenDesc.UseVisualStyleBackColor = true;
            this.B_LenDesc.Click += new System.EventHandler(this.B_LenDesc_Click);
            // 
            // B_Width
            // 
            this.B_Width.Enabled = false;
            this.B_Width.Location = new System.Drawing.Point(212, 71);
            this.B_Width.Name = "B_Width";
            this.B_Width.Size = new System.Drawing.Size(186, 23);
            this.B_Width.TabIndex = 3;
            this.B_Width.Text = "Sort by Width";
            this.B_Width.UseVisualStyleBackColor = true;
            this.B_Width.Click += new System.EventHandler(this.B_Width_Click);
            // 
            // B_WidthHeight
            // 
            this.B_WidthHeight.Enabled = false;
            this.B_WidthHeight.Location = new System.Drawing.Point(212, 100);
            this.B_WidthHeight.Name = "B_WidthHeight";
            this.B_WidthHeight.Size = new System.Drawing.Size(186, 23);
            this.B_WidthHeight.TabIndex = 4;
            this.B_WidthHeight.Text = "Sort by Width and Height";
            this.B_WidthHeight.UseVisualStyleBackColor = true;
            this.B_WidthHeight.Click += new System.EventHandler(this.B_WidthHeight_Click);
            // 
            // B_RemStub
            // 
            this.B_RemStub.Enabled = false;
            this.B_RemStub.Location = new System.Drawing.Point(404, 13);
            this.B_RemStub.Name = "B_RemStub";
            this.B_RemStub.Size = new System.Drawing.Size(186, 23);
            this.B_RemStub.TabIndex = 5;
            this.B_RemStub.Text = "Remove Stubby Lines";
            this.B_RemStub.UseVisualStyleBackColor = true;
            this.B_RemStub.Click += new System.EventHandler(this.B_RemStub_Click);
            // 
            // B_RemLong
            // 
            this.B_RemLong.Enabled = false;
            this.B_RemLong.Location = new System.Drawing.Point(404, 42);
            this.B_RemLong.Name = "B_RemLong";
            this.B_RemLong.Size = new System.Drawing.Size(186, 23);
            this.B_RemLong.TabIndex = 6;
            this.B_RemLong.Text = "Remove Long Lines";
            this.B_RemLong.UseVisualStyleBackColor = true;
            this.B_RemLong.Click += new System.EventHandler(this.B_RemLong_Click);
            // 
            // TrB_Length
            // 
            this.TrB_Length.Enabled = false;
            this.TrB_Length.Location = new System.Drawing.Point(13, 154);
            this.TrB_Length.Name = "TrB_Length";
            this.TrB_Length.Size = new System.Drawing.Size(577, 45);
            this.TrB_Length.TabIndex = 7;
            this.TrB_Length.Scroll += new System.EventHandler(this.TrB_Length_Scroll);
            // 
            // LB_Length
            // 
            this.LB_Length.AutoSize = true;
            this.LB_Length.Location = new System.Drawing.Point(12, 138);
            this.LB_Length.Name = "LB_Length";
            this.LB_Length.Size = new System.Drawing.Size(98, 13);
            this.LB_Length.TabIndex = 8;
            this.LB_Length.Text = "Highlight by Length";
            // 
            // LB_MinMax
            // 
            this.LB_MinMax.AutoSize = true;
            this.LB_MinMax.Location = new System.Drawing.Point(116, 138);
            this.LB_MinMax.Name = "LB_MinMax";
            this.LB_MinMax.Size = new System.Drawing.Size(13, 13);
            this.LB_MinMax.TabIndex = 9;
            this.LB_MinMax.Text = "0";
            // 
            // ICA6_FunLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 196);
            this.Controls.Add(this.LB_MinMax);
            this.Controls.Add(this.LB_Length);
            this.Controls.Add(this.TrB_Length);
            this.Controls.Add(this.B_RemLong);
            this.Controls.Add(this.B_RemStub);
            this.Controls.Add(this.B_WidthHeight);
            this.Controls.Add(this.B_Width);
            this.Controls.Add(this.B_LenDesc);
            this.Controls.Add(this.B_LenAsc);
            this.Controls.Add(this.B_Populate);
            this.Name = "ICA6_FunLine";
            this.Text = "ICA 6 - Generic Containers";
            ((System.ComponentModel.ISupportInitialize)(this.TrB_Length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Populate;
        private System.Windows.Forms.Button B_LenAsc;
        private System.Windows.Forms.Button B_LenDesc;
        private System.Windows.Forms.Button B_Width;
        private System.Windows.Forms.Button B_WidthHeight;
        private System.Windows.Forms.Button B_RemStub;
        private System.Windows.Forms.Button B_RemLong;
        private System.Windows.Forms.TrackBar TrB_Length;
        private System.Windows.Forms.Label LB_Length;
        private System.Windows.Forms.Label LB_MinMax;
    }
}

