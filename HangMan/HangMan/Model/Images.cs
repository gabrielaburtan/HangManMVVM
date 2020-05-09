using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HangMan.Model
{
    class Images
    {
        public ObservableCollection<BitmapImage> ImagesList { get; set; }

        public Images()
        {
            ImagesList = new ObservableCollection<BitmapImage>();
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar1.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar2.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar3.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar4.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar5.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar6.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar7.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar8.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar9.png", UriKind.Relative)));
            ImagesList.Add(new BitmapImage(new Uri($"/Images/Avatars/avatar10.png", UriKind.Relative)));
        }
    }
}
