using System;
using System.Windows.Forms;

namespace auto_da_fé
{
    public partial class Form1 : Form
    {
        private bool _lockWallpaper = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void LockWallpaper_CheckedChanged(object sender, EventArgs e)
        {
            _lockWallpaper = LockWallpaper.Checked;
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            WallpaperManager.SetWallpaper(Level.Easy, _lockWallpaper);
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            WallpaperManager.SetWallpaper(Level.Medium, _lockWallpaper);
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            WallpaperManager.SetWallpaper(Level.Hard, _lockWallpaper);
        }

        private void UnseenableButton_Click(object sender, EventArgs e)
        {
            WallpaperManager.SetWallpaper(Level.Unseenable, _lockWallpaper);
        }
    }
}
