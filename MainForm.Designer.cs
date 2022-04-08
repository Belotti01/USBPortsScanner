namespace PortsScanner {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContainer.AutoScroll = true;
			this.pnlContainer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(813, 563);
			this.pnlContainer.TabIndex = 0;
			// 
			// btn_refresh
			// 
			this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_refresh.AutoEllipsis = true;
			this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_refresh.Image = global::PortsScanner.Properties.Resources.refresh;
			this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_refresh.Location = new System.Drawing.Point(831, 12);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(70, 79);
			this.btn_refresh.TabIndex = 1;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_refresh.UseVisualStyleBackColor = true;
			this.btn_refresh.Click += new System.EventHandler(this.RefreshButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(913, 587);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.pnlContainer);
			this.MinimumSize = new System.Drawing.Size(250, 250);
			this.Name = "MainForm";
			this.Text = "Ports Scanner";
			this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel pnlContainer;
		private Button btn_refresh;
	}
}