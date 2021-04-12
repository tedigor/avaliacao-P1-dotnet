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
            Console.WriteLine("##### Bem vindo à União Investimentos #####");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar ação");
            Console.WriteLine("2 - Pesquisar ação");
            Console.WriteLine("3 - Visualizar carteira de ações");
            Console.WriteLine("0 - Sair");
        }

        
        private static void DoAction(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                        RegisterAction();
                    }
                    break;
                case 2:
                    {
                        ShowAction();
                    }
                    break;
                case 3:
                    {
                        ShowAllActions();
                    }
                    break;
            }
        }
        
        private static void RegisterAction() 
        {
            Console.Write("Digite o código da ação: ");
            string actionCode = Console.ReadLine().ToUpper();
            Console.Write("Digite a quantidade de ações que deseja comprar: ");
            int actionAmount = int.Parse(Console.ReadLine());

            wallet.AddAction(actionCode, actionAmount);

            Console.WriteLine("Ação cadastrada com sucesso!");
        }

        private static void ShowAction() 
        {
            try
            {
              Console.Write("Digite o código da ação: ");
              string actionCode = Console.ReadLine().ToUpper();  
              wallet.ShowActionDetails(actionCode);
            }
            catch (SearchActionException err)
            {
                Console.WriteLine(err.Message);
            } 
            catch
            {
                Console.WriteLine("Ocorreu um erro ao cadastrar a ação!");
            }
        }

        private static void ShowAllActions() 
        {
            wallet.ShowAllActionsDetails();
        }


    }
}
