using Microsoft.Win32;
using OpenMcdf;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace panyi
{
    class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool WritePrivateProfileString(
            [MarshalAs(UnmanagedType.LPWStr)] string lpAppName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpString,
            [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        internal static extern uint GetPrivateProfileString(
            [MarshalAs(UnmanagedType.LPWStr)] string lpAppName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpDefault,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpReturnedString,
            [MarshalAs(UnmanagedType.U4)] uint nSize,
            [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool updating = false;
            int index;
            string lang;
            string installDir;
            string bakfile;
            string file;
            string config = Path.GetFullPath("panyi.ini");

            Console.WriteLine(
@",-------------------------------------------------.
| panyi 1.1                                       |
| Copyright 2018 zeffy <https://github.com/zeffy> |
| Simple Understanding Public License v1 (SUPL)   |
 `+---------------------------------------------+-'
  | OpenMcdf 2.1                                |
  | Copyright (c) 2010-2018, Federico Blaseotto |
  | Mozilla Public License 2.0 (MPL-2.0)        |
  `---------------------------------------------'
");
            if ( !File.Exists(config) ) {
                Console.Write("panyi.ini is missing! Download the latest copy? [y/n] ");
                string input = Console.ReadLine().Trim().ToLowerInvariant();

                if ( !string.IsNullOrEmpty(input)
                    && new[] { "yes", "y" }.Contains(input) ) {
                    updating = true;
                } else {
                    Console.Write("\nCancelled by user! Press any key to exit... ");
                    Console.ReadKey(true);
                    return;
                }
            } else {
                updating = Array.IndexOf(args, "-update") != -1;
            }

            if ( updating ) {
                using ( var wc = new WebClient() ) {
                    string part = config + ".part";

                    Console.Write("Downloading latest panyi.ini... ");
                    try {
                        wc.DownloadFile(
  "https://raw.githubusercontent.com/zeffy/panyi/master/panyi/panyi.ini",
  part);
                        Console.WriteLine("Finished!\n");
                    } catch ( WebException ) {
                        Console.WriteLine("Failed!\n\n" +
                            "You can download it manually from https://git.io/fAdWN");

                        Console.Write("\nPress any key to exit... ");
                        Console.ReadKey(true);
                        return;
                    }
                    if ( File.Exists(config) ) {
                        bakfile = config + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss.bak");
                        File.Copy(config, bakfile);

                        Console.WriteLine("Copied old panyi.ini to \"{0}\"", bakfile);
                    }
                    File.Move(part, config);
                    Console.Write("\nDone! Press any key to exit... ");
                    Console.ReadKey(true);
                    return;
                }
            }

            if ( (index = Array.IndexOf(args, "-lang")) != -1 ) {
                if ( ++index >= args.Length )
                    return;

                lang = args[index];
            } else {
                lang = "en";
            }

            if ( (index = Array.IndexOf(args, "-file")) != -1 ) {
                if ( ++index >= args.Length )
                    return;

                file = args[index];
            } else {
                installDir = Registry.GetValue(
                    @"HKEY_CURRENT_USER\Software\Baidu\BaiduYunGuanjia",
                    "installDir",
                    null) as string;
                if ( string.IsNullOrEmpty(installDir) )
                    return;

                file = installDir + "\\resource.db";
            }

            using ( var fs = new FileStream(file,
                FileMode.Open,
                FileAccess.ReadWrite,
                FileShare.Read) )
            using ( var cf = new CompoundFile(fs,
                CFSUpdateMode.Update,
                CFSConfiguration.SectorRecycle | CFSConfiguration.EraseFreeSectors) ) {

                CFStream cfs = cf.RootStorage.GetStream("StringTable.xml");
                XDocument xd = XDocument.Parse(Encoding.UTF8.GetString(cfs.GetData()));
                string id;

                if ( Array.IndexOf(args, "-x") != -1 ) {
                    Console.WriteLine("Extracting cn string table to panyi.ini...");
                    foreach ( var element in xd.Root.Elements("String") ) {
                        if ( !NativeMethods.WritePrivateProfileString("cn",
                            (string)element.Attribute("id"),
                            (string)element.Attribute("value"),
                            config) )
                            Console.WriteLine("Failed to write string!");
                    }
                } else {
                    bakfile = file + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss.bak");
                    File.Copy(file, bakfile);
                    Console.WriteLine("Copied old resource.db to \"{0}\"", bakfile);

                    Console.WriteLine("Translating string table to {0}...", lang);
                    var sb = new StringBuilder(0x200);
                    foreach ( var element in xd.Root.Elements("String") ) {
                        id = (string)element.Attribute("id");
                        if ( NativeMethods.GetPrivateProfileString(lang, id, "", sb, (uint)sb.MaxCapacity, config) > 0 )
                            element.Attribute("value").SetValue(sb.ToString());
                    }
                    cfs.SetData(Encoding.UTF8.GetBytes(xd.ToString()));
                    cf.Commit(true);
                }
            }
            Console.Write("\nDone! Press any key to exit... ");
            Console.ReadKey(true);
            return;
        }
    }
}
