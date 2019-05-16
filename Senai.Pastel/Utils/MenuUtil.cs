using System;
namespace Senai.Pastel.Utils {
    public class MenuUtil {
        public static void MenuDeslogado () {
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("-----------------Pastelaria-----------------");
            Console.WriteLine ("-------------      Conta      --------------");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           (1) Cadastrar Usuário            ");
            Console.WriteLine ("           (2) Efetuar Login                ");
            Console.WriteLine ("           (3) Listar                       ");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           (0) Sair                         ");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           Escolha uma opção                ");
        }

        public static void MenuLogado () {
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("--------------Pastelaria Tk-----------------");
            Console.WriteLine ("-----------      Cardápio      -------------");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           (1) Cadastrar Produto            ");
            Console.WriteLine ("           (2) Listar                       ");
            Console.WriteLine ("           (3) Valor Total                  ");
            Console.WriteLine ("           (4) Alterar                      ");
            Console.WriteLine ("           (4) Remover                      ");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           (0) Sair                         ");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           Escolha uma opção                ");
        }
    }
}