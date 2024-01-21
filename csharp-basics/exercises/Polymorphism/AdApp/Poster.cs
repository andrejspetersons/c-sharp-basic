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
        private int width;
        private int height;
        private int dimension;
        private int numberOfCopies;
        private int _rate;

        public Poster(int fee,int width,int height,int copies,int rate):base(fee)
        {
            this.width = width;
            this.height = height;
            dimension = width * height;
            _rate = rate;
            numberOfCopies = copies;
        }

        public override int Cost()
        {
            return base.Cost()+(dimension*numberOfCopies*_rate);
        }

        public override string ToString()
        {
            
            var result = base.ToString()+ $"\nDimension: {width * height}\nNumber of copies: {numberOfCopies}\n Rate per copy: {_rate}";
            return result;
        }
    }
}
