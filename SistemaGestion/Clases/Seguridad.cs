using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.Clases
{
    class Seguridad
    {
        public static bool ValidarSerial(SistemaConfiguracion oSistemaConfiguracion)
        {
            string strRuta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string strAVR = "";
            if (File.Exists(strRuta + "\\avrapc.wat"))
            {
                using (TextReader txtReader = new StreamReader(strRuta + "\\avrapc.wat"))
                {
                    strAVR=txtReader.ReadLine();
                }
            }
            if (strAVR == oSistemaConfiguracion.Equipo)
            {
                if (Utilidades.Encriptar(oSistemaConfiguracion.Equipo) != oSistemaConfiguracion.Serial)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //Se encripta y se valida con lo que se trae en la BD
            return true;
        }
        public static void SaveAVR(string strAVR)
        {
            try
            {
                FileStream fsStream = null;
                string strRuta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                if (!File.Exists(strRuta + "\\avrapc.wat"))
                {
                    using (fsStream = File.Create(strRuta + "\\avrapc.wat"))
                    {
                        byte[] bytInfo = new UTF8Encoding(true).GetBytes(strAVR);
                        fsStream.Write(bytInfo, 0, bytInfo.Length);
                    }
                    //using (StreamWriter sw = new StreamWriter(strRuta + "\\avrapc.wat"))
                    //{
                    //    sw.Write(strAVR);
                    //}
                }
            }
            catch(Exception ou)
            {
            }
        }
        
        private static string ObtenerHash(string s)
        {
            //Initialize a new MD5 Crypto Service Provider in order to generate a hash
            MD5 sec = new MD5CryptoServiceProvider();
            //Grab the bytes of the variable 's'
            byte[] bt = Encoding.ASCII.GetBytes(s);
            //Grab the Hexadecimal value of the MD5 hash
            return ObtenerHexString(sec.ComputeHash(bt));
        }

        private static string ObtenerHexString(IList<byte> bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Count; i++)
            {
                byte b = bt[i];
                int n = b;
                int n1 = n & 15;
                int n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                else
                    s += n2.ToString(CultureInfo.InvariantCulture);
                if (n1 > 9)
                    s += ((char)(n1 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                else
                    s += n1.ToString(CultureInfo.InvariantCulture);
                if ((i + 1) != bt.Count && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }
        private static string strFingerPrint = string.Empty;
        public static string UniqueId()
        {
            //You don't need to generate the HWID again if it has already been generated. This is better for performance
            //Also, your HWID generally doesn't change when your computer is turned on but it can happen.
            //It's up to you if you want to keep generating a HWID or not if the function is called.
            if (string.IsNullOrEmpty(strFingerPrint))
            {
                strFingerPrint = ObtenerHash("CPU >> " + CpuId() + "\nBIOS >> " + BiosId() + "\nBASE >> " + BaseId() + "\nDISK >> " + DiskId() + "\nVIDEO >> " + VideoId() + "\nMAC >> " + MacId());
            }
            return strFingerPrint;
        }
        //Return a hardware identifier
        private static string Identificador(string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementBaseObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() != "True") continue;
                //Only get the first one
                if (result != "") continue;
                try
                {
                    result = mo[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
            return result;
        }
        //Return a hardware identifier
        private static string Identificador(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementBaseObject mo in moc)
            {
                //Only get the first one
                if (result != "") continue;
                try
                {
                    result = mo[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
            return result;
        }
        private static string CpuId()
        {
            //Uses first CPU identifier available in order of preference
            //Don't get all identifiers, as it is very time consuming
            string retVal = Identificador("Win32_Processor", "UniqueId");
            if (retVal != "") return retVal;
            retVal = Identificador("Win32_Processor", "ProcessorId");
            if (retVal != "") return retVal;
            retVal = Identificador("Win32_Processor", "Name");
            if (retVal == "") //If no Name, use Manufacturer
            {
                retVal = Identificador("Win32_Processor", "Manufacturer");
            }
            //Add clock speed for extra security
            retVal += Identificador("Win32_Processor", "MaxClockSpeed");
            return retVal;
        }
        //BIOS Identifier
        private static string BiosId()
        {
            return Identificador("Win32_BIOS", "Manufacturer") + Identificador("Win32_BIOS", "SMBIOSBIOSVersion") + Identificador("Win32_BIOS", "IdentificationCode") + Identificador("Win32_BIOS", "SerialNumber") + Identificador("Win32_BIOS", "ReleaseDate") + Identificador("Win32_BIOS", "Version");
        }
        //Main physical hard drive ID
        private static string DiskId()
        {
            return Identificador("Win32_DiskDrive", "Model") + Identificador("Win32_DiskDrive", "Manufacturer") + Identificador("Win32_DiskDrive", "Signature") + Identificador("Win32_DiskDrive", "TotalHeads");
        }
        //Motherboard ID
        private static string BaseId()
        {
            return Identificador("Win32_BaseBoard", "Model") + Identificador("Win32_BaseBoard", "Manufacturer") + Identificador("Win32_BaseBoard", "Name") + Identificador("Win32_BaseBoard", "SerialNumber");
        }
        //Primary video controller ID
        private static string VideoId()
        {
            return Identificador("Win32_VideoController", "DriverVersion") + Identificador("Win32_VideoController", "Name");
        }
        //First enabled network card ID
        private static string MacId()
        {
            return Identificador("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
        }
    }
}
