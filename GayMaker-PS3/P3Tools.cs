

using System;
using System.Diagnostics;
using System.IO;

namespace 
    GayMaker_PS3
{
    class P3Tools
    {
        public static void RemoveEdataChk(string elf)
        {

            byte[] signature = new byte[] { 0x38, 0xA0, 0x00, 0x00, 0x38, 0xC0, 0x03, 0xE9, 0x38, 0xE0, 0x40, 0x00, 0xF8, 0x81, 0x00, 0x70 }; /*   
                                                                                                                                               *   li  r5, 0
                                                                                                                                               *   li  r6, 0x3e9
                                                                                                                                               *   li  r7, 0x4000
                                                                                                                                               *   std r4, 0x70(r1)
                                                                                                                                               */
            byte[] patch = new byte[] { 0x4E, 0x80, 0x00, 0x20 }; /* 
                                                                   * blr 
                                                                   */

            int offset = 0x24; // total bytes from li r5 to the start of the "psn_handle_content_error" function


            byte[] fileData = File.ReadAllBytes(elf);

            // search for signature within elf file
            for (int i = 0; i < fileData.Length - signature.Length; i++)
            {
                bool match = true;
                for (int k = 0; k < signature.Length; k++)
                {
                    if (fileData[i + k] != signature[k])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    i -= offset; // minus the offset to find the start of the function
                    Array.ConstrainedCopy(patch, 0, fileData, i, patch.Length); // copy patch to the file data
                    File.WriteAllBytes(elf, fileData); // save patched ELF to disk.
                    return;
                }
            }



        }
        public static void MakePackage(string conf, string folder, string outFolder, DataReceivedEventHandler handler=null)
        {
            using (Process makepackage = new Process())
            {
                makepackage.StartInfo.FileName = @"P3Tools\\make_package_npdrm.exe";
                makepackage.StartInfo.Arguments = "\"" + conf + "\" \"" + folder + "\"";
                makepackage.StartInfo.UseShellExecute = false;
                makepackage.StartInfo.RedirectStandardOutput = true;
                makepackage.StartInfo.RedirectStandardError = true;
                makepackage.StartInfo.CreateNoWindow = true;
                makepackage.StartInfo.WorkingDirectory = outFolder;
                if (handler != null) makepackage.OutputDataReceived += handler;
                if (handler != null) makepackage.ErrorDataReceived += handler;
                makepackage.Start();
                makepackage.WaitForExit();
            }
        }
        public static void UnmakeFself(string self, string elf, DataReceivedEventHandler handler = null)
        {
            using (Process unmakefself = new Process())
            {
                unmakefself.StartInfo.FileName = @"P3Tools\\unfself.exe";
                unmakefself.StartInfo.Arguments = "\"" + self + "\" \"" + elf + "\"";
                unmakefself.StartInfo.UseShellExecute = false;
                unmakefself.StartInfo.RedirectStandardOutput = true;
                unmakefself.StartInfo.RedirectStandardError = true;
                unmakefself.StartInfo.CreateNoWindow = true;
                if (handler != null) unmakefself.OutputDataReceived += handler;
                if (handler != null) unmakefself.ErrorDataReceived += handler;
                unmakefself.Start();
                unmakefself.WaitForExit();
            }
            File.Delete(self);
        }
        public static void MakeFself(string elf, string self, DataReceivedEventHandler handler = null)
        {
            using (Process makefself = new Process())
            {
                makefself.StartInfo.FileName = @"P3Tools\\make_fself_npdrm.exe";
                makefself.StartInfo.Arguments = "\""+elf + "\" \"" + self+"\"";
                makefself.StartInfo.UseShellExecute = false;
                makefself.StartInfo.RedirectStandardOutput = true;
                makefself.StartInfo.RedirectStandardError = true;
                makefself.StartInfo.CreateNoWindow = true;
                if (handler != null) makefself.OutputDataReceived += handler;
                if (handler != null) makefself.ErrorDataReceived += handler;
                makefself.Start();
                makefself.WaitForExit();
            }
            File.Delete(elf);
        }
    }
}
