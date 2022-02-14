using System.Management;

namespace PortsScanner {
    public static class UsbBrowser {

        public static List<ManagementBaseObject> GetUsbDevices() {
            IList<string> usbDeviceAddresses = LookUpUsbDeviceAddresses();

            List<ManagementBaseObject> usbDevices = new();

            foreach(string usbDeviceAddress in usbDeviceAddresses) {
                // Query MI for the PNP device info
                ManagementObjectCollection curMoc = QueryMi("Select * from Win32_PnPEntity where PNPDeviceID = " + usbDeviceAddress);
                foreach(ManagementBaseObject device in curMoc) {
                    usbDevices.Add(device);
                }
            }

            return usbDevices;
        }

        private static IList<string> LookUpUsbDeviceAddresses() {
            // Request data from the Windows Management Infrastructure;
            // this query gets the addressing information for connected USB devices
            ManagementObjectCollection usbDeviceAddressInfo = QueryMi(@"Select * from Win32_USBControllerDevice");
            List<string> usbDeviceAddresses = new();

            foreach(var device in usbDeviceAddressInfo) {
                try {
                    string curPnpAddress = (string)device.GetPropertyValue("Dependent");
                    // Split the address portion of the data, including escaped backslashes and quotes
                    curPnpAddress = curPnpAddress.Split(new string[] { "DeviceID=" }, 2, StringSplitOptions.None)[1];

                    usbDeviceAddresses.Add(curPnpAddress);
                }catch { }
            }

            return usbDeviceAddresses;
        }

        private static ManagementObjectCollection QueryMi(string query) {
            ManagementObjectSearcher managementObjectSearcher = new(query);
            ManagementObjectCollection result = managementObjectSearcher.Get();

            managementObjectSearcher.Dispose();
            return result;
        }

    }

}