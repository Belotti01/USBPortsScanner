using System.Management;

namespace PortsScanner {
    public partial class MainForm : Form {
        protected List<ManagementBaseObject> devices;

        public MainForm() {
            InitializeComponent();
            SuspendLayout();
            devices = UsbBrowser.GetUsbDevices();

            foreach(ManagementBaseObject device in devices) {
                pnlContainer.Controls.Add(new PortEntry(device) {
                    Width = pnlContainer.Width - 40,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                });
            }

            ResumeLayout();
        }
    }
}
