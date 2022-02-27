using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary.Models
{
    public class WorkPlace
    {
        List<Image> imageList;
        static WorkPlace place;

        private WorkPlace()
        {
            imageList = new List<Image>();
        }

        public static WorkPlace CreateWprkPlace()
        {
            if (place == null) place = new WorkPlace();
            return place;
        }

        public void AddImage(Image image)
        {
            imageList.Add(image);
        }

        public void RemoveImage(Image image)
        {
            imageList.Remove(image);
        }
    }
}
