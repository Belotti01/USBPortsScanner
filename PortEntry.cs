using System.Management;

namespace PortsScanner {
    public partial class PortEntry : UserControl {
        public PortEntry() {
            InitializeComponent();
        }

        public PortEntry(ManagementBaseObject device) : this() {
            lblTitle.Text = device.GetPropertyValue("Caption").ToString();
            lblStatus.Text = device.GetPropertyValue("Status").ToString();

            lblStatus.ForeColor = lblStatus.Text == "OK" 
                ? Color.Green 
                : Color.Red;

            foreach(var property in device.Properties) {
                if(property.Value is not null && !string.IsNullOrEmpty(property.Value.ToString())) {
                    if(property.IsArray) {
                        string propertyName = property.Name;
                        foreach(var detail in (object[])property.Value) {
                            if(detail is not null) {
                                AddLine(propertyName, detail);
                                propertyName = string.Empty;
                            }
                        }
                    } else {
                        AddLine(property.Name, property.Value);
                    }
                }
            }
        }

        private void AddLine(object name, object value) {
            if(!string.IsNullOrEmpty(name.ToString())) name += ":";
            string line = $"{name}:\t\t {value}";
            lstData.Items.Add(line);
        }
    }
}
