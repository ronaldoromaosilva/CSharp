using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    /// <summary>
    /// 
    /// </summary>
    class Comentarios
    {
        /// <summary>
        /// Apertando Ctlr + Espaço aparece como abaixo para 
        /// referencia em outro lugar
        /// <see cref=""/>
        /// </summary>
        /// <param name="a"></param>
        /// 
        ///Esse método finaliza/executar o pedido
        ///
        /// 
        ///Um vez que o metodo ja tem esse nome, não precisa do comentario acima
        ///

        public static void Executar()
        {
            // Cuidado com os comentarios desnecessarios
            Console.WriteLine("Código claro é sempre melhor");

            /*
             
             * Esse é um comentário
             * de multiplas linhas...
             
             * Os * são opcionais (só apagar)
             * 
             * 
             */
         

            Console.WriteLine("O C# tem o XML comments");

            //Ctrl + kc comenta as linhas selecionas
            //Ctrl + ku descomenta as linhas
            Console.WriteLine("1");
            Console.WriteLine("1");




        }
    }

}


