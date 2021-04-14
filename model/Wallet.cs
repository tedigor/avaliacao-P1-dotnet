using System;
using System.Collections.Generic;
using projeto_P1.exceptions;

namespace projeto_P1.model
{
    public class Wallet
    {
        private List<Stock> stocks;

        public Wallet()
        {
            this.stocks = new List<Stock>();
        }

        public void AddStock(string code, int amount) {
            Stock stock = GetStockByCode(code); 
            if ( stock != null)
            {
                stock.IncrementAmount(amount);
            } else 
            {
                this.stocks.Add(new Stock(code, amount));
            }
        }

        private Stock GetStockByCode(string code) 
        {
            try
            {
                return this.stocks.Find(a => a.Code.Equals(code));    
            }
            catch (System.Exception)
            {  
                throw new SearchStockException($"A ação {code} não está cadastrada na carteira!");
            }
        }

        public void ShowStockDetails(string code) 
        {
            try
            {
                Stock action = GetStockByCode(code); 
                Console.WriteLine($"Código da Ação: {action.Code} Quantidade: {action.Amount}");
            }
            catch (System.Exception)
            {
                throw new SearchStockException($"A ação {code} não está cadastrada na carteira!");
            }
        }

        public void ShowAllStocksDetails() 
        {   
            if (stocks.Count == 0)
            {
                Console.WriteLine("A carteira não possui ações, cadastre uma ação para visualizar!");
            }
            else
            {
                foreach (var action in stocks)
                {
                    Console.WriteLine($"Código da Ação: {action.Code} Quantidade: {action.Amount}");  
                }
            }
        }


    }
}