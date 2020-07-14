using System.Collections.Generic;
using System.Management;

namespace GihanSoft.WMI
{
    public class Win32_NetworkAdapterSetting
    {
        private readonly ManagementObject mngObj;

        private Win32_NetworkAdapterSetting(ManagementObject mngObj)
        {
            this.mngObj = mngObj;
        }

        public Win32_NetworkAdapterConfiguration Setting =>
            new Win32_NetworkAdapterConfiguration(
                new ManagementObject((string)mngObj[nameof(Setting)]));
        public Win32_NetworkAdapter Element =>
            new Win32_NetworkAdapter(
                new ManagementObject((string)mngObj[nameof(Element)]));

        public static IEnumerable<Win32_NetworkAdapterSetting> GetAll()
        {
            var instances =
                new ManagementClass(nameof(Win32_NetworkAdapterSetting)).GetInstances();
            foreach (ManagementObject instance in instances)
            {
                yield return new Win32_NetworkAdapterSetting(instance);
            }
        }
    }
}
