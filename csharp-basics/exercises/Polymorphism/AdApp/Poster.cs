using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    internal class Poster:Advert
    {
        private int _width;
        private int _height;
        private int _dimension;
        private int _numberOfCopies;
        private int _rate;

        public Poster(int fee,int width,int height,int copies,int rate):base(fee)
        {
            _width = width;
            _height = height;
            _dimension = width * height;
            _rate = rate;
            _numberOfCopies = copies;
        }

        public override int Cost()
        {
            return base.Cost()+(_dimension*_numberOfCopies*_rate);
        }

        public override string ToString()
        {
            
            var result = base.ToString()+ $"\nDimension: {_width * _height}\nNumber of copies: {_numberOfCopies}\n Rate per copy: {_rate}";
            return result;
        }
    }
}
