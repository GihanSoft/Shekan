//using GihanSoft.WMI.Helpers;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Management;

namespace GihanSoft.WMI
{
    [SuppressMessage("Performance",
        "CA1819:Properties should not return arrays", Justification = "<Pending>")]
    public abstract class CIM_NetworkAdapter
    {
        protected readonly ManagementObject mngObj;

        protected CIM_NetworkAdapter(ManagementObject mngObj)
        {
            this.mngObj = mngObj;
        }

        /// <summary>
        /// If True, the network adapter can automatically determine the speed of the attached or network media.
        /// </summary>
        /// <remarks>
        /// This property has not been implemented yet. It returns a NULL value by default.
        /// </remarks>
        public bool? AutoSense => (bool?)mngObj[nameof(AutoSense)];
        /// <summary>
        /// Availability and status of the device.
        /// </summary>
        public ushort Availability => (ushort)mngObj[nameof(Availability)];
        /// <summary>
        /// Short description of the object—a one-line string.
        /// </summary>
        public string Caption => (string)mngObj[nameof(Caption)];
        /// <summary>
        /// Windows Configuration Manager error code.
        /// </summary>
        public uint? ConfigManagerErrorCode => (uint?)mngObj[nameof(ConfigManagerErrorCode)];
        /// <summary>
        /// If True, the device is using a user-defined configuration.
        /// </summary>
        public bool? ConfigManagerUserConfig => (bool?)mngObj[nameof(ConfigManagerUserConfig)];
        /// <summary>
        /// Name of the first concrete class to appear in the inheritance chain used in the creation of an instance.
        /// When used with the other key properties of the class, the property allows all instances of this class and its subclasses to be uniquely identified.
        /// </summary>
        public string CreationClassName => (string)mngObj[nameof(CreationClassName)];
        /// <summary>
        /// Description of the object.
        /// </summary>
        public string Description => (string)mngObj[nameof(Description)];
        /// <summary>
        /// Unique identifier of the network adapter from other devices on the system.
        /// </summary>
        public string DeviceID => (string)mngObj[nameof(DeviceID)];
        /// <summary>
        /// If True, the error reported in LastErrorCode is now cleared.
        /// </summary>
        public bool? ErrorCleared => (bool?)mngObj[nameof(ErrorCleared)];
        /// <summary>
        /// More information about the error recorded in LastErrorCode, and information about any corrective actions that may be taken.
        /// </summary>
        public string ErrorDescription => (string)mngObj[nameof(ErrorDescription)];
        /// <summary>
        /// Date and time the object was installed.
        /// This property does not need a value to indicate that the object is installed.
        /// </summary>
        /// <remarks>
        /// This property has not been implemented yet. It returns a NULL value by default.
        /// </remarks>
        public DateTime? InstallDate => (DateTime?)mngObj[nameof(InstallDate)];
        /// <summary>
        /// Last error code reported by the logical device.
        /// </summary>
        public uint? LastErrorCode => (uint?)mngObj[nameof(LastErrorCode)];
        /// <summary>
        /// Maximum speed, in bits per second, for the network adapter.
        /// </summary>
        public ulong? MaxSpeed => (ulong?)mngObj[nameof(MaxSpeed)];
        /// <summary>
        /// Label by which the object is known.
        /// When subclassed, the property can be overridden to be a key property.
        /// </summary>
        public string Name => (string)mngObj[nameof(Name)];
        /// <summary>
        /// Array of network addresses for an adapter.
        /// </summary>
        public string[] NetworkAddresses => (string[])mngObj[nameof(NetworkAddresses)];
        /// <summary>
        /// Network address hard-coded into an adapter.
        /// This hard-coded address may be changed by firmware upgrade or software configuration.
        /// If so, this field should be updated when the change is made.
        /// The property should be left blank if no hard-coded address exists for the network adapter.
        /// </summary>
        public string PermanentAddress => (string)mngObj[nameof(PermanentAddress)];
        /// <summary>
        /// Windows Plug and Play device identifier of the logical device.
        /// </summary>
        public string PNPDeviceID => (string)mngObj[nameof(PNPDeviceID)];
        /// <summary>
        /// Array of the specific power-related capabilities of a logical device.
        /// </summary>
        public ushort[] PowerManagementCapabilities => (ushort[])mngObj[nameof(PowerManagementCapabilities)];
        /// <summary>
        /// If True, the device can be power-managed (can be put into suspend mode, and so on).
        /// The property does not indicate that power management features are currently enabled, only that the logical device is capable of power management.
        /// </summary>
        public bool PowerManagementSupported => (bool)mngObj[nameof(PowerManagementSupported)];
        /// <summary>
        /// Estimate of the current bandwidth in bits per second.
        /// For endpoints which vary in bandwidth or for those where no accurate estimation can be made, this property should contain the nominal bandwidth.
        /// </summary>
        public ulong? Speed => (ulong?)mngObj[nameof(Speed)];
        /// <summary>
        /// Current status of the object.
        /// </summary>
        public string Status => (string)mngObj[nameof(Status)];
        /// <summary>
        /// State of the logical device.
        /// If this property does not apply to the logical device, the value 5 (Not Applicable) should be used.
        /// </summary>
        public ushort? StatusInfo => (ushort?)mngObj[nameof(StatusInfo)];
        /// <summary>
        /// Value of the scoping computer's CreationClassName property.
        /// </summary>
        public string SystemCreationClassName => (string)mngObj[nameof(SystemCreationClassName)];
        /// <summary>
        /// Name of the scoping system.
        /// </summary>
        public string SystemName => (string)mngObj[nameof(SystemName)];
    }
}