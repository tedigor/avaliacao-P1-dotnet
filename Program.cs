using System;
using projeto_P1.exceptions;
using projeto_P1.model;

namespace projeto_P1
{
    class Program
    {
        private static Wallet wallet;
        static void Main(string[] args)
        {
            wallet = new Wallet();
            int option = 0;
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                if (option == 0) break;

                DoAction(option);
                Console.ReadLine();
                
            } while (true);
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo à Trabson Invest! escolha uma opção: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Comprar uma ação");
            Console.WriteLine("2 - Pesquisar por uma ação");
            Console.WriteLine("3 - Visualizar sua carteira de ações");
            Console.WriteLine("0 - Sair");
        }

        
        private static void DoAction(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                        RegisterStock();
                    }
                    break;
                case 2:
                    {
                        ShowStock();
                    }
                    break;
                case 3:
                    {
                        ShowAllStocks();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Opção não existente, tente novamente!");
                    }
                    break;
            }
        }
        
        private static void RegisterStock() 
        {
            Console.Write("Digite o código da ação: ");
            string stockCode = Console.ReadLine().ToUpper();
            Console.Write("Digite a quantidade de ações que deseja comprar: ");
            int stockAmount = int.Parse(Console.ReadLine());

            wallet.AddStock(stockCode, stockAmount);

            Console.WriteLine("Ação cadastrada com sucesso!");
        }

        private static void ShowStock() 
        {
            try
            {
              Console.Write("Digite o código da ação: ");
              string stockCode = Console.ReadLine().ToUpper();  
              wallet.ShowStockDetails(stockCode);
            }
            catch (SearchStockException err)
            {
                Console.WriteLine(err.Message);
            } 
            catch
            {
                Console.WriteLine("Ocorreu um erro ao pesquisar a ação, Tente novamente");
            }
        }

        private static void ShowAllStocks() 
        {
            wallet.ShowAllStocksDetails();
        }
    }
}
