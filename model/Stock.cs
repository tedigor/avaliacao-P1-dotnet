namespace projeto_P1.model
{
    public class Stock
    {
        private string code; 
        public string Code
        {
            get 
            {
                return this.code;
            }
            set
            {
                this.code = value;
            }
        }
        private int amount;

        public int Amount
        {
            get
            {
                return this.amount;
            }
            set 
            {
                this.amount = value;
            }
        }
        public Stock(string code, int amount)
        {
            this.code = code;
            this.amount = amount;
        }

        public void IncrementAmount(int increment) 
        {
            this.amount = amount + increment;
        }
    }    
}

