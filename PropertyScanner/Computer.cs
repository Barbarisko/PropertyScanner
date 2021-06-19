using System;
using System.Management;

namespace PropertyScanner
{
    //processor name
    //Console.WriteLine("Name         :" + MO["Name"]);

    //memory storage
    //uint64 FreePhysicalMemory;

    //network

    //computer role
    //user number
    //configuration
    public class Computer
    {
        public OperatingSystem OSVersion { get; set; }
        public bool OS64bit {get; set;}
        public string MachineName { get; set; }
        public uint FreeMemoryStorage { get; set; }

        public uint CPUNumber { get; set; }
        public string ProcessorName { get; set; }
        public string CurrentNetwork { get; set; }
        public string ComputerRole { get; set; }
        public uint UserId { get; set; }



        public void checkEnvironment()
        {
            Console.WriteLine("Windows version: {0}",
                            Environment.OSVersion);
            Console.WriteLine("64 Bit operating system? : {0}",
               Environment.Is64BitOperatingSystem ? "Yes" : "No");
            Console.WriteLine("PC Name : {0}",
               Environment.MachineName);
            Console.WriteLine("domain Name : {0}",
               Environment.UserDomainName);

            Console.WriteLine("Number of CPUS : {0}",
               Environment.ProcessorCount);
            Console.WriteLine("Windows folder : {0}",
               Environment.SystemDirectory);
            Console.WriteLine("Logical Drives Available : {0}",
                  String.Join(", ", Environment.GetLogicalDrives())
               .TrimEnd(',', ' ')
               .Replace("\\", String.Empty));
        }

        public static void checkCPU()
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject MO in MOS.Get())
            {
                Console.WriteLine("Processor Details");
                Console.WriteLine("===============================================================");
                Console.WriteLine("AddressWidth :" + MO["AddressWidth"]);
                Console.WriteLine("Architecture :" + MO["Architecture"]);
                Console.WriteLine("Availability :" + MO["Availability"]);
                Console.WriteLine("Caption      :" + MO["Caption"]);
                Console.WriteLine("ConfigManagerErrorCode       :" + MO["ConfigManagerErrorCode"]);
                Console.WriteLine("ConfigManagerUserConfig      :" + MO["ConfigManagerUserConfig"]);
                Console.WriteLine("CpuStatus    :" + MO["CpuStatus"]);
                Console.WriteLine("CreationClassName            :" + MO["CreationClassName"]);
                Console.WriteLine("CurrentClockSpeed            :" + MO["CurrentClockSpeed"]);
                Console.WriteLine("CurrentVoltage               :" + MO["CurrentVoltage"]);
                Console.WriteLine("DataWidth    :" + MO["DataWidth"]);
                Console.WriteLine("Description  :" + MO["Description"]);
                Console.WriteLine("DeviceID     :" + MO["DeviceID"]);
                Console.WriteLine("ErrorCleared :" + MO["ErrorCleared"]);
                Console.WriteLine("InstallDate  :" + MO["InstallDate"]);
                Console.WriteLine("LoadPercentage               :" + MO["LoadPercentage"]);
                Console.WriteLine("Name         :" + MO["Name"]);
                Console.WriteLine("NumberOfCores                :" + MO["NumberOfCores"]);
                Console.WriteLine("NumberOfLogicalProcessors    :" + MO["NumberOfLogicalProcessors"]);
                Console.WriteLine("ProcessorID  :" + MO["ProcessorID"]);
                Console.WriteLine("ProcessorType                :" + MO["ProcessorType"]);
                Console.WriteLine("OtherFamilyDescription       :" + MO["OtherFamilyDescription"]);
                Console.WriteLine("PNPDeviceID  :" + MO["PNPDeviceID"]);
                Console.WriteLine("PowerManagementSupported     :" + MO["PowerManagementSupported"]);
                Console.WriteLine("Revision     :" + MO["Revision"]);
                Console.WriteLine("Role         :" + MO["Role"]);
                Console.WriteLine("SocketDesignation            :" + MO["SocketDesignation"]);
                Console.WriteLine("Status       :" + MO["Status"]);
                Console.WriteLine("StatusInfo   :" + MO["StatusInfo"]);
                Console.WriteLine("Stepping     :" + MO["Stepping"]);
                Console.WriteLine("SystemCreationClassName      :" + MO["SystemCreationClassName"]);
                Console.WriteLine("SystemName   :" + MO["SystemName"]);
                Console.WriteLine("UniqueId     :" + MO["UniqueId"]);
                Console.WriteLine("UpgradeMethod                :" + MO["UpgradeMethod"]);
                Console.WriteLine("Version      :" + MO["Version"]);
                Console.WriteLine("VoltageCaps  :" + MO["VoltageCaps"]);
            }
        }
        public static void checkOS()
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject MO in MOS.Get())
            {
                Console.WriteLine("FreePhysicalMemory  :" + MO["FreePhysicalMemory"]);

            }
        }
        public static void checkSystemAccount()
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT * FROM Win32_SystemNetworkConnections");
            foreach (ManagementObject MO in MOS.Get())
            {
                Console.WriteLine("PartComponent  :" + MO["PartComponent"]);

            }
        }
    }
}
