using System.Management;

namespace GihanSoft.WMI
{
    public class Win32_NetworkAdapter : CIM_NetworkAdapter
    {
        public Win32_NetworkAdapter(ManagementObject mngObj)
            :base(mngObj)
        {
        }

        /// <summary>
        /// Network medium in use.
        /// </summary>
        public string AdapterType => (string)mngObj[nameof(AdapterType)];
        /// <summary>
        /// Network medium in use.
        /// Returns the same information as the AdapterType property, except that the information is in the form of an integer.
        /// </summary>
        public ushort? AdapterTypeID => (ushort?)mngObj[nameof(AdapterTypeID)];
        /// <summary>
        /// Globally unique identifier for the connection.
        /// </summary>
        public string GUID => (string)mngObj[nameof(GUID)];
        /// <summary>
        /// Index number of the network adapter, stored in the system registry.
        /// </summary>
        public uint Index => (uint)mngObj[nameof(Index)];
        /// <summary>
        /// If True, the network adapter is installed in the system.
        /// </summary>
        public bool Installed => (bool)mngObj[nameof(Installed)];
        /// <summary>
        /// Index value that uniquely identifies the local network interface.
        /// The value in this property is the same as the value in the InterfaceIndex property in the instance of Win32_IP4RouteTable that represents the network interface in the route table.
        /// </summary>
        public uint InterfaceIndex => (uint)mngObj[nameof(InterfaceIndex)];
        /// <summary>
        /// Media access control address for this network adapter.
        /// A MAC address is a unique 48-bit number assigned to the network adapter by the manufacturer.
        /// It uniquely identifies this network adapter and is used for mapping TCP/IP network communications.
        /// </summary>
        public string MACAddress => (string)mngObj[nameof(MACAddress)];
        /// <summary>
        /// Name of the network adapter's manufacturer.
        /// </summary>
        public string Manufacturer => (string)mngObj[nameof(Manufacturer)];
        /// <summary>
        /// Maximum number of directly addressable ports supported by this network adapter.
        /// A value of 0 (zero) should be used if the number is unknown.
        /// </summary>
        public uint MaxNumberControlled => (uint)mngObj[nameof(MaxNumberControlled)];
        /// <summary>
        /// Name of the network connection as it appears in the Network Connections Control Panel program.
        /// </summary>
        public string NetConnectionID => (string)mngObj[nameof(NetConnectionID)];
        /// <summary>
        /// State of the network adapter connection to the network.
        /// </summary>
        public ushort? NetConnectionStatus => (ushort?)mngObj[nameof(NetConnectionStatus)];
        /// <summary>
        /// Indicates whether the adapter is enabled or not.
        /// If True, the adapter is enabled.
        /// You can enable or disable the NIC by using the Enable and Disable methods.
        /// </summary>
        public bool? NetEnabled => (bool?)mngObj[nameof(NetEnabled)];
        /// <summary>
        /// Indicates whether the adapter is a physical or a logical adapter.
        /// If True, the adapter is physical.
        /// </summary>
        public bool PhysicalAdapter => (bool)mngObj[nameof(PhysicalAdapter)];
        /// <summary>
        /// Product name of the network adapter.
        /// </summary>
        public string ProductName => (string)mngObj[nameof(ProductName)];
        /// <summary>
        /// Service name of the network adapter.
        /// This name is usually shorter than the full product name.
        /// </summary>
        public string ServiceName => (string)mngObj[nameof(ServiceName)];
        /// <summary>
        /// Date and time the network adapter was last reset.
        /// </summary>
        public string TimeOfLastReset => (string)mngObj[nameof(TimeOfLastReset)];

        public uint Disable()
        {
            return (uint)mngObj.InvokeMethod(nameof(Disable), null);
        }
        public uint Enable()
        {
            return (uint)mngObj.InvokeMethod(nameof(Enable), null);
        }
    }
}