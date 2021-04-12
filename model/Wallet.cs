using System;
using System.Collections.Generic;
using projeto_P1.exceptions;

namespace projeto_P1.model
{
    public class Wallet
    {
        private List<Action> actions;

        public Wallet()
        {
            this.actions = new List<Action>();
        }

        public void AddAction(string code, int amount) {
            Action action = GetActionByCode(code); 
            if ( action != null)
            {
                action.IncrementAmount(amount);
            } else 
            {
                this.actions.Add(new Action(code, amount));
            }
        }

        private Action GetActionByCode(string code) 
        {
            try
            {
                return this.actions.Find(a => a.GetCode().Equals(code));    
            }
            catch (System.Exception)
            {  
                throw new SearchActionException($"A ação {code} não está cadastrada na carteira!");
            }
        }

        public void ShowActionDetails(string code) 
        {
            try
            {
                Action action = GetActionByCode(code); 
                Console.WriteLine($"Código da Ação: {action.GetCode()} Quantidade: {action.GetAmount()}");
            }
            catch (System.Exception)
            {
                throw new SearchActionException($"A ação {code} não está cadastrada na carteira!");
            }
        }

        public void ShowAllActionsDetails() 
        {
            foreach (var action in actions)
            {
                Console.WriteLine($"Código da Ação: {action.GetCode()} Quantidade: {action.GetAmount()}");
            }
        }


    }
}