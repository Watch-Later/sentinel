namespace Sentinel.Images
{
    using Sentinel.Support.Mvvm;

    public class ImageTypeRecord : ViewModelBase
    {
        private string name;

        private ImageQuality quality;

        private string image;

        public ImageTypeRecord(string name, ImageQuality quality, string image)
        {
            this.name = name;
            this.quality = quality;
            this.image = image;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public ImageQuality Quality
        {
            get
            {
                return quality;
            }

            set
            {
                if (quality != value)
                {
                    quality = value;
                    OnPropertyChanged("Quality");
                }
            }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged("Image");
                }
            }
        }
    }
}