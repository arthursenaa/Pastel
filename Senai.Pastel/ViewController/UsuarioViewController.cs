using System;
using System.Collections.Generic;
using Senai.Pastel.Repositorio;
using Senai.Pastel.Utils;
using Senai.Pastel.ViewModel;

namespace Senai.Pastel.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha;

            do
            {
                System.Console.Write("Digite o nome do usuário : ");
                nome = Console.ReadLine();

               if (string.IsNullOrEmpty(nome))
                {
                    System.Console.WriteLine("Nome inválido");
                }    
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Digite o seu E-Mail");
                email = Console.ReadLine();
                
                if(!ValidacoesUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }
            } while (!ValidacoesUtil.ValidadorDeEmail(email));
            
            do
            {
                System.Console.Write("Digite a Senha : ");
                senha = Console.ReadLine();

                System.Console.WriteLine("Confirme a senha");
                confirmaSenha = Console.ReadLine();
                
                if (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha))
                {
                    System.Console.WriteLine("Senha inválida");                 
                }

            } while (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha));
        
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            

            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Usuário Cadastrado com sucesso");
            Console.ResetColor();
        }//Fim cadastro Usuario

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();
        
            foreach (var item in listaDeUsuarios)
            {
                System.Console.WriteLine($"ID {item.Id} \nNome: {item.Nome} \nE-Mail: {item.Email}\nSenha: {item.Senha}\nData de Criação {item.DataCriacao}\n-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-");
            }
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do
            {
                System.Console.WriteLine("Digite o email");
                email = Console.ReadLine();
                
                if(!ValidacoesUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("Email Inválido");
                }
            } while (!ValidacoesUtil.ValidadorDeEmail(email));

            System.Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario(email,senha);

            if (usuarioRetornado != null)
            {
                return usuarioRetornado;
            }else{
                System.Console.WriteLine($"Usuário ou Senha inválida");
                return usuarioRetornado;
            }
            
        }//Fim Efetuar Login
    }
}