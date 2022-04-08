namespace PortsScanner {
    partial class PortEntry {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.lstData = new System.Windows.Forms.ListBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.container = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
			this.container.Panel1.SuspendLayout();
			this.container.Panel2.SuspendLayout();
			this.container.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstData
			// 
			this.lstData.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lstData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lstData.FormattingEnabled = true;
			this.lstData.ItemHeight = 21;
			this.lstData.Location = new System.Drawing.Point(0, 0);
			this.lstData.Name = "lstData";
			this.lstData.Size = new System.Drawing.Size(1287, 228);
			this.lstData.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(65, 25);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "label1";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.lblStatus.Location = new System.Drawing.Point(1215, 0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(72, 23);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "STATUS";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// container
			// 
			this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.container.Cursor = System.Windows.Forms.Cursors.HSplit;
			this.container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.container.IsSplitterFixed = true;
			this.container.Location = new System.Drawing.Point(0, 0);
			this.container.Name = "container";
			this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// container.Panel1
			// 
			this.container.Panel1.Controls.Add(this.lblTitle);
			this.container.Panel1.Controls.Add(this.lblStatus);
			this.container.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// container.Panel2
			// 
			this.container.Panel2.Controls.Add(this.lstData);
			this.container.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.container.Panel2MinSize = 0;
			this.container.Size = new System.Drawing.Size(1287, 295);
			this.container.SplitterDistance = 62;
			this.container.SplitterWidth = 5;
			this.container.TabIndex = 3;
			// 
			// PortEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Controls.Add(this.container);
			this.Name = "PortEntry";
			this.Size = new System.Drawing.Size(1290, 298);
			this.container.Panel1.ResumeLayout(false);
			this.container.Panel1.PerformLayout();
			this.container.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
			this.container.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstData;
        private Label lblTitle;
        private Label lblStatus;
		private SplitContainer container;
	}
}
