using System.Diagnostics.CodeAnalysis;
using System.Management;

namespace GihanSoft.WMI
{
    [SuppressMessage("Performance",
        "CA1819:Properties should not return arrays", Justification = "<Pending>")]
    public class Win32_NetworkAdapterConfiguration
    {
        private readonly ManagementObject mngObj;

        public Win32_NetworkAdapterConfiguration(ManagementObject mngObj)
        {
            this.mngObj = mngObj;
        }

        /// <summary>
        /// Short textual description of the current object.
        /// </summary>
        public string Caption => (string)mngObj[nameof(Caption)];
        /// <summary>
        /// Textual description of the current object.
        /// </summary>
        public string Description => (string)mngObj[nameof(Description)];
        public string SettingID => (string)mngObj[nameof(SettingID)];
        public bool? ArpAlwaysSourceRoute => (bool?)mngObj[nameof(ArpAlwaysSourceRoute)];
        public bool? ArpUseEtherSNAP => (bool?)mngObj[nameof(ArpUseEtherSNAP)];
        public string DatabasePath => (string)mngObj[nameof(DatabasePath)];
        public bool? DeadGWDetectEnabled => (bool?)mngObj[nameof(DeadGWDetectEnabled)];
        public string[] DefaultIPGateway => (string[])mngObj[nameof(DefaultIPGateway)];
        public byte? DefaultTOS => (byte?)mngObj[nameof(DefaultTOS)];
        public byte? DefaultTTL => (byte?)mngObj[nameof(DefaultTTL)];
        public bool DHCPEnabled => (bool)mngObj[nameof(DHCPEnabled)];
        public string DHCPLeaseExpires => (string)mngObj[nameof(DHCPLeaseExpires)];
        public string DHCPLeaseObtained => (string)mngObj[nameof(DHCPLeaseObtained)];
        public string DHCPServer => (string)mngObj[nameof(DHCPServer)];
        public string DNSDomain => (string)mngObj[nameof(DNSDomain)];
        public string[] DNSDomainSuffixSearchOrder => (string[])mngObj[nameof(DNSDomainSuffixSearchOrder)];
        public bool? DNSEnabledForWINSResolution => (bool?)mngObj[nameof(DNSEnabledForWINSResolution)];
        public string DNSHostName => (string)mngObj[nameof(DNSHostName)];
        public string[] DNSServerSearchOrder => (string[])mngObj[nameof(DNSServerSearchOrder)];
        public bool? DomainDNSRegistrationEnabled => (bool?)mngObj[nameof(DomainDNSRegistrationEnabled)];
        public uint? ForwardBufferMemory => (uint?)mngObj[nameof(ForwardBufferMemory)];
        public bool? FullDNSRegistrationEnabled => (bool?)mngObj[nameof(FullDNSRegistrationEnabled)];
        public ushort[] GatewayCostMetric => (ushort[])mngObj[nameof(GatewayCostMetric)];
        public byte? IGMPLevel => (byte?)mngObj[nameof(IGMPLevel)];
        public uint Index => (uint)mngObj[nameof(Index)];
        public uint InterfaceIndex => (uint)mngObj[nameof(InterfaceIndex)];
        public string[] IPAddress => (string[])mngObj[nameof(IPAddress)];
        public uint? IPConnectionMetric => (uint?)mngObj[nameof(IPConnectionMetric)];
        public bool IPEnabled => (bool)mngObj[nameof(IPEnabled)];
        public bool? IPFilterSecurityEnabled => (bool?)mngObj[nameof(IPFilterSecurityEnabled)];
        public bool? IPPortSecurityEnabled => (bool?)mngObj[nameof(IPPortSecurityEnabled)];
        public string[] IPSecPermitIPProtocols => (string[])mngObj[nameof(IPSecPermitIPProtocols)];
        public string[] IPSecPermitTCPPorts => (string[])mngObj[nameof(IPSecPermitTCPPorts)];
        public string[] IPSecPermitUDPPorts => (string[])mngObj[nameof(IPSecPermitUDPPorts)];
        public string[] IPSubnet => (string[])mngObj[nameof(IPSubnet)];
        public bool? IPUseZeroBroadcast => (bool?)mngObj[nameof(IPUseZeroBroadcast)];
        public string IPXAddress => (string)mngObj[nameof(IPXAddress)];
        public bool? IPXEnabled => (bool?)mngObj[nameof(IPXEnabled)];
        public uint[] IPXFrameType => (uint[])mngObj[nameof(IPXFrameType)];
        public uint? IPXMediaType => (uint?)mngObj[nameof(IPXMediaType)];
        public string[] IPXNetworkNumber => (string[])mngObj[nameof(IPXNetworkNumber)];
        public string IPXVirtualNetNumber => (string)mngObj[nameof(IPXVirtualNetNumber)];
        public uint? KeepAliveInterval => (uint?)mngObj[nameof(KeepAliveInterval)];
        public uint? KeepAliveTime => (uint?)mngObj[nameof(KeepAliveTime)];
        public string MACAddress => (string)mngObj[nameof(MACAddress)];
        public uint? MTU => (uint?)mngObj[nameof(MTU)];
        public uint? NumForwardPackets => (uint?)mngObj[nameof(NumForwardPackets)];
        public bool? PMTUBHDetectEnabled => (bool?)mngObj[nameof(PMTUBHDetectEnabled)];
        public bool? PMTUDiscoveryEnabled => (bool?)mngObj[nameof(PMTUDiscoveryEnabled)];
        public string ServiceName => (string)mngObj[nameof(ServiceName)];
        public uint? TcpipNetbiosOptions => (uint?)mngObj[nameof(TcpipNetbiosOptions)];
        public uint? TcpMaxConnectRetransmissions => (uint?)mngObj[nameof(TcpMaxConnectRetransmissions)];
        public uint? TcpMaxDataRetransmissions => (uint?)mngObj[nameof(TcpMaxDataRetransmissions)];
        public uint? TcpNumConnections => (uint?)mngObj[nameof(TcpNumConnections)];
        public bool? TcpUseRFC1122UrgentPointer => (bool?)mngObj[nameof(TcpUseRFC1122UrgentPointer)];
        public ushort? TcpWindowSize => (ushort?)mngObj[nameof(TcpWindowSize)];
        public bool? WINSEnableLMHostsLookup => (bool?)mngObj[nameof(WINSEnableLMHostsLookup)];
        public string WINSHostLookupFile => (string)mngObj[nameof(WINSHostLookupFile)];
        public string WINSPrimaryServer => (string)mngObj[nameof(WINSPrimaryServer)];
        public string WINSScopeID => (string)mngObj[nameof(WINSScopeID)];
        public string WINSSecondaryServer => (string)mngObj[nameof(WINSSecondaryServer)];

        public uint DisableIPSec()
        {
            return (uint)mngObj.InvokeMethod(nameof(DisableIPSec), null);
        }
        public uint EnableDHCP()
        {
            return (uint)mngObj.InvokeMethod(nameof(EnableDHCP), null);
        }
        /*
        public uint EnableDNS(
  [in, optional] string DNSHostName,
  [in, optional] string DNSDomain,
  [in, optional] string DNSServerSearchOrder[],
  [in, optional] string DNSDomainSuffixSearchOrder[]
)
        {
            var args = mngObj.GetMethodParameters(nameof(EnableDNS));
            if(DNSHostName)
            args[]
        }
        /*
        uint EnableIPFilterSec(
  [in] bool IPFilterSecurityEnabled
);
        uint EnableIPSec(
  [in] string IPSecPermitTCPPorts[],
  [in] string IPSecPermitUDPPorts[],
  [in] string IPSecPermitIPProtocols[]
);
        uint EnableStatic(
  [in] string IPAddress[],
  [in] string SubnetMask[]
);
        uint EnableWINS(
  [in]           bool DNSEnabledForWINSResolution,
  [in]           bool WINSEnableLMHostsLookup,
  [in, optional] string  WINSHostLookupFile,
  [in, optional] string  WINSScopeID
);
        uint ReleaseDHCPLease();
        uint ReleaseDHCPLease();
        uint RenewDHCPLease();
        uint RenewDHCPLeaseAll();
        uint SetArpAlwaysSourceRoute(
  [in] bool ArpAlwaysSourceRoute
);
        uint SetArpUseEtherSNAP(
  [in] bool ArpUseEtherSNAP
);
        uint SetDatabasePath(
  [in] string DatabasePath
);
        uint SetDeadGWDetect(
  [in] bool DeadGWDetectEnabled
);
        uint SetDefaultTOS(
  [in] byte DefaultTOS
);
        uint SetDefaultTTL(
  [in] byte DefaultTTL
);
        uint SetDNSDomain(
  [in] string DNSDomain
);
        */
        public uint SetDNSServerSearchOrder(
            string[] DNSServerSearchOrder)
        {
            var args = mngObj.GetMethodParameters(nameof(SetDNSServerSearchOrder));
            args[nameof(DNSServerSearchOrder)] = DNSServerSearchOrder;

            var retVal = mngObj.InvokeMethod(nameof(SetDNSServerSearchOrder), args, null);
            return 0;
        }
        /*
        uint SetDNSSuffixSearchOrder(
  [in] string DNSDomainSuffixSearchOrder[]
);
        */
        //public uint SetDynamicDNSRegistration(
        //    bool FullDNSRegistrationEnabled,
        //    bool? DomainDNSRegistrationEnabled = null)
        //{
        //    var args = mngObj.GetMethodParameters(nameof(SetDynamicDNSRegistration));
        //    args[nameof(FullDNSRegistrationEnabled)] = FullDNSRegistrationEnabled;
        //    if (DomainDNSRegistrationEnabled.HasValue)
        //        args[nameof(DomainDNSRegistrationEnabled)] = DomainDNSRegistrationEnabled;

        //    var retVal = mngObj.InvokeMethod(nameof(SetDynamicDNSRegistration), args, null);
        //    return 0;
        //}
        /*
        uint SetForwardBufferMemory(
  [in] uint ForwardBufferMemory
);
        uint SetGateways(
  [in]           string DefaultIPGateway[],
  [in, optional] ushort GatewayCostMetric[]
);
        uint SetIGMPLevel(
  [in] byte IGMPLevel
);
        uint SetIPConnectionMetric(
  [in] uint IPConnectionMetric
);
        uint SetIPUseZeroBroadcast(
  [in] bool IPUseZeroBroadcast
);
        uint SetIPXFrameTypeNetworkPairs(
  [in] string IPXNetworkNumber[],
  [in] uint IPXFrameType[]
);
        uint SetIPXVirtualNetworkNumber(
  [in] string IPXVirtualNetNumber
);
        uint SetKeepAliveInterval(
  [in] uint KeepAliveInterval
);
        uint SetKeepAliveTime(
  [in] uint KeepAliveTime
);
        uint SetMTU(
  [in] uint MTU
);
        uint SetNumForwardPackets(
  [in] uint NumForwardPackets
);
        uint SetPMTUBHDetect(
  [in] bool PMTUBHDetectEnabled
);
        uint SetPMTUDiscovery(
  [in] bool PMTUDiscoveryEnabled
);
        uint SetTcpipNetbios(
  [in] uint TcpipNetbiosOptions
);
        uint SetTcpMaxConnectRetransmissions(
  [in] uint TcpMaxConnectRetransmissions
);
        uint SetTcpMaxDataRetransmissions(
  [in] uint TcpMaxDataRetransmissions
);
        uint SetTcpNumConnections(
  [in] uint TcpNumConnections
);
        uint SetTcpUseRFC1122UrgentPointer(
  [in] bool TcpUseRFC1122UrgentPointer
);
        uint SetTcpWindowSize(
  [in] ushort TcpWindowSize
);
        uint SetWINSServer(
  [in] string WINSPrimaryServer,
  [in] string WINSSecondaryServer
);
        */
    }
}