using System.Diagnostics;
using System.IO;

namespace mklinkUI
{
    internal class DirUtils
    {
        public static void MoveDirectory(string src, string dst)
        {
            if (Directory.Exists(src))
            {
                if (Directory.GetDirectoryRoot(src) == Directory.GetDirectoryRoot(dst))
                {
                    Directory.Delete(dst);
                    Directory.Move(src, dst);
                }
                else
                {
                    CopyDirectory(new DirectoryInfo(src), new DirectoryInfo(dst));
                    Directory.Delete(src, true);
                }

                Directory.CreateDirectory(src);
            }
        }

        private static void CopyDirectory(DirectoryInfo src, DirectoryInfo dst)
        {
            if (!dst.Exists)
            {
                dst.Create();
            }

            FileInfo[] srcFiles = src.GetFiles();
            foreach (FileInfo srcFile in srcFiles)
            {
                srcFile.CopyTo(Path.Combine(dst.FullName, srcFile.Name));
            }

            DirectoryInfo[] srcDirs = src.GetDirectories();
            foreach (DirectoryInfo srcDir in srcDirs)
            {
                CopyDirectory(srcDir, new DirectoryInfo(Path.Combine(dst.FullName, srcDir.Name)));
            }
        }

        public static void MakeSymlink(string from, string to)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
                                {
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    FileName = "cmd.exe",
                                    Arguments = "/C mklink /D \"" + @from + "\" \"" + to + "\""
                                };

            process.StartInfo = startInfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.OutputDataReceived += (sender, args) => MessageBox.Show(args.Data);
            process.Start();
            //process.BeginOutputReadLine();
            process.WaitForExit();
            //process.CancelOutputRead();
        }

        public static void DeleteDir(string dir)
        {
            Directory.Delete(dir);
        }

        public static string MakeNewPath(string src, string dst)
        {
            return dst + "/" + Path.GetFileName(src);
        }

        public static bool Exists(string dir)
        {
            return Directory.Exists(dir);
        }

        public static void MakeDir(string dir)
        {
            Directory.CreateDirectory(dir);
        }
    }
}