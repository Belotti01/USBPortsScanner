using System.Diagnostics.CodeAnalysis;
using System.Management;

namespace PortsScanner {
    public partial class MainForm : Form {
        protected List<ManagementBaseObject> devices;

        public MainForm() {
            InitializeComponent();
            Scan();
        }

        [MemberNotNull(nameof(devices))]
        protected void Scan() {
            btn_refresh.Enabled = false;
            SuspendLayout();
            devices = UsbBrowser.GetUsbDevices();

            foreach(ManagementBaseObject device in devices) {
                pnlContainer.Controls.Add(new PortEntry(device) {
                    Width = pnlContainer.Width - 40,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                });
            }

            ResumeLayout();
            btn_refresh.Enabled = true;
        }

		private void RefreshButtonClick(object sender, EventArgs e) {
            pnlContainer.Controls.Clear();
            Scan();
		}
	}
}
