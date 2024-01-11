using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory { get; set; } = new List<Video>();
        
        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void CheckOutVideo(string title)
        {
            var video = _inventory.FirstOrDefault(video => video.title == title);
            if (video == null) return;
            video.CheckOut();
        }

        public void ReturnVideo(string title)
        {
            var video = _inventory.FirstOrDefault(video => video.title == title&&video.isCheckedOut);
            if (video == null) return;
            video.Return();

        }

        public void ReceiveRating(string title, double rating)
        {
            var video = _inventory.FirstOrDefault(video => video.title == title);
            if (video == null) return;
            video.ReceiveRate(rating);
        }

        public List<Video> ListInventory()
        {
            return _inventory.ToList();
        }

    }
}
