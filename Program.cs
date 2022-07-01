using System;
using System.IO;

namespace PlexoOpenBetaTest
{
    class Program
    {
        static void Main()
        {
            string baseIP = "26.236.116.66"; // TODO: Make this use the VPS IP once I get a VPS

            using (StreamWriter writer = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", true))
            {
                writer.WriteLine("\r\n# Plexo hosts file configuration\r\n");

                writer.WriteLine($"# Main website\r\n{baseIP}  plexxo.xyz\r\n{baseIP}  http://plexxo.xyz\r\n{baseIP}  www.plexxo.xyz\r\n{baseIP}  http://www.plexxo.xyz\r\n{baseIP}  assetgame.plexxo.xyz\r\n{baseIP}  http://assetgame.plexxo.xyz\r\n");
                writer.WriteLine($"# Setup sub\r\n{baseIP}  setup.plexxo.xyz\r\n{baseIP}  http://setup.plexxo.xyz\r\n");
                writer.WriteLine($"# API sub\r\n{baseIP}  api.plexxo.xyz\r\n{baseIP}  http://api.plexxo.xyz\r\n");
                writer.WriteLine($"# ClientSettings sub\r\n{baseIP}  clientsettings.api.plexxo.xyz\r\n{baseIP}  http://clientsettings.api.plexxo.xyz\r\n");
                writer.WriteLine($"# VersionCompatibility sub\r\n{baseIP}  versioncompatibility.api.plexxo.xyz\r\n{baseIP}  http://versioncompatibility.api.plexxo.xyz\r\n");
                writer.WriteLine($"# EphemeralCounters sub\r\n{baseIP}  ephemeralcounters.api.plexxo.xyz\r\n{baseIP}  http://ephemeralcounters.api.plexxo.xyz\r\n");

                writer.WriteLine("# End Plexo hosts file configuration\r\n");

                writer.Close();
                writer.Dispose();
            }

            Environment.Exit(0);
        }
    }
}
