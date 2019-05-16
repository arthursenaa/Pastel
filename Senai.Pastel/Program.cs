using System;
using Senai.Pastel.Utils;
using Senai.Pastel.ViewController;
using Senai.Pastel.ViewModel;

namespace Senai.Pastel {
    class Program {
        public static object UsuarioViewControler { get; private set; }

        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            do {
                //Menu Deslogado
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastrar usuário
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        //Efetuar Login
                        UsuarioViewModel usuarioRetornado = UsuarioViewController.EfetuarLogin ();

                        if (usuarioRetornado != null) {
                            System.Console.WriteLine ($"Bem vindo {usuarioRetornado}");
                        } else {
                            Console.WriteLine("Usuário ou Senha Inválido , Tente Novamente!");
                            continue;
                        }
                        
                        break;
                    case 3:
                        //Listar usuário Cadastrados
                        UsuarioViewController.ListarUsuario ();
                        break;
                    case 9:
                        //Sair
                        break;
                    default:
                        System.Console.WriteLine ("Opção Inválido");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}