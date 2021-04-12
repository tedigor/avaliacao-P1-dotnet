namespace projeto_P1.model
{
    public class Action
    {
        private string code {get; set;}
        private int amount {get; set;}

        public Action(string code, int amount)
        {
            this.code = code;
            this.amount = amount;
        }

        public string GetCode() 
        {
            return code;  
        }

        public int GetAmount() 
        {
            return amount;  
        }

        public void IncrementAmount(int increment) 
        {
            amount = amount + increment;
        }
    }    
}

