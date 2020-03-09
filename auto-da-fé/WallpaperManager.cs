using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Security.AccessControl;

namespace auto_da_fé
{
    static class WallpaperManager
    {
        public static void SetWallpaper(Level level, bool wallpaperLock)
        {
            var images = GetImages(level);
            if (images.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(images.Count);
                var selectedWallpaper = images[index];

                selectedWallpaper = CoppyImage(selectedWallpaper);

                if (wallpaperLock)
                {
                    SetWallpaperGroupPolicy(selectedWallpaper);
                }
                else
                {
                    SetWallpaperRegistry(selectedWallpaper);
                }
                RefreshWallpaper(selectedWallpaper);
            }
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private static void RefreshWallpaper(string path)
        {
            SystemParametersInfo(20, 0, path, 0x01 | 0x02);
        }

        private static void SetWallpaperRegistry(string path)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "WallPaper", path);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "TileWallpaper", "0");
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "WallpaperStyle", "6");
        }
        private static void SetWallpaperGroupPolicy(string path)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "Wallpaper", path);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "WallpaperStyle", "3");
        }
        private static List<string> GetImages(Level level)
        {
            List<string> imageList = new List<string>();
            List<string> supportedFormats = new List<string> { "JPG", "JPEG", "BMP", "DIB", "PNG", "JFIF", "JPE", "GIF", "TIF", "TIFF", "WDP" };
            foreach (var format in supportedFormats)
            {
                imageList.AddRange(Directory.GetFiles(Directory.GetCurrentDirectory()+ @"\Wallpapers\"+ level.ToString() +@"\", @"*."+format));
            }
            return imageList;
        }

        private static string CoppyImage(string sourcePath)
        {
            
            string destinationpath = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["WallpaperCoppyPath"]);
            string newWallpaperFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
            string fullDestinationPath = destinationpath + newWallpaperFileName;

            if (!Directory.Exists(destinationpath))
            {
                Directory.CreateDirectory(destinationpath);
            }
            
            File.Copy(sourcePath, fullDestinationPath, true);

            //Something to play with later
            //FileSecurity fileSecurity = new FileSecurity();
            //fileSecurity.SetAccessRule(new FileSystemAccessRule("Administrator", FileSystemRights.Read, AccessControlType.Allow));
            //File.SetAccessControl(fullDestinationPath, fileSecurity);

            //DirectorySecurity directoryRule = new DirectorySecurity();
            //directoryRule.SetAccessRule(new FileSystemAccessRule("Administrator", FileSystemRights.Read, AccessControlType.Allow));
            //Directory.SetAccessControl(destinationpath, directoryRule);

            return fullDestinationPath;
        }
    }
}
