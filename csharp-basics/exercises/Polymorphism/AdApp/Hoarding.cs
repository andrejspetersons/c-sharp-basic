namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        private bool isPrime;


        public Hoarding(int fee,int days,int rate,bool prime) : base(fee)
        {
            _numDays = days;
            _rate = rate;
            isPrime = prime;
        }

        public override int Cost() 
        {
            return isPrime?base.Cost()+((_numDays*_rate*150)/100):base.Cost()+(_numDays*_rate);
        }

        public override string ToString() 
        { 
            var result = base.ToString() +$"\nNumber of days: {_numDays}\nCost per day: {_rate}";
            return result;
        }
    }
}