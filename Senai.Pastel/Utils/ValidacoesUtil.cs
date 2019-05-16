using System;

namespace Senai.Pastel.Utils
{
    public class ValidacoesUtil
    {
        /// <summary>Valida o email do Usuário, Verifica se o mesmo possui @ e .</summary>
        /// <param name="email">description</param>
        /// <returns>Retorna True caso o email seja válido caso contrário retorna false</returns>
        public static bool ValidadorDeEmail(string email){
            if (email.Contains("@") && email.Contains("."))
            {
                return true;   
            }
            return false;
        }

        public static bool ValidadorDeSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha) && senha.Length > 6)
            {
                return true;
            }
            return false;
        }

        internal static bool ValidadorDeEmail()
        {
            throw new NotImplementedException();
        }
    }
}