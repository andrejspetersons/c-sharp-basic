using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string title { get; private set; }
        public bool isCheckedOut { get; private set; }
        private List<double> _ratings { get; set; } = new List<double>();
        public double averageRating => _ratings.Count > 0 ? Math.Round(_ratings.Average(),2) : 0;  

        public Video(string title)
        {
            this.title = title;
        }

        public void CheckOut()
        {
            isCheckedOut = true;
        }

        public void Return()
        {
            isCheckedOut = false;
        }

        public void ReceiveRate(double rating)
        {
            _ratings.Add(rating);   
        }

        public override string ToString()
        {
            return $"Title: {title},Rating: {averageRating}"; 
        }
    }
}
