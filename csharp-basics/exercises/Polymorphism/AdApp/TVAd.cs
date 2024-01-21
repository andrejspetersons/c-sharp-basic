namespace AdApp
{
    public class TVAd: Advert
    {
        private int _rate;
        private int _seconds;
        private bool isPeak;
        public TVAd(int fee,int rate,int seconds,bool peakTime) : base(fee)
        {
            
            _rate = rate;
            _seconds = seconds;
            isPeak = peakTime;
        }
        
        public  override int Cost() 
        {
            return isPeak?base.Cost()+(_rate*_seconds*2): base.Cost() + (_rate * _seconds);
        }

        public override string ToString() 
        {
            base.ToString();
            var result = $"\nRate per second: {_rate}\nAir seconds: {_seconds}";
            return result;
        }
    }
}