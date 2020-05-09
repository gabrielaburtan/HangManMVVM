using HangMan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using HangMan.ViewModels;

namespace HangMan.Services
{
    class Validators
    {
        public static bool CanExecuteNextImage(BitmapImage image, Images images)
        {
            return images.ImagesList.IndexOf(image) < images.ImagesList.Count - 1;
        }
        public static bool CanExecutePrevImage(BitmapImage image, Images images)
        {
            if (images.ImagesList.IndexOf(image) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
