using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa
{
    class principal
    {
        //Cosole.WriteLine("Hello,World!");
        static void Main(string[] args)
        {
            //método construtor
            // TIPO_DO_DADO | NOME DA INSTÂNCIA (OBJETO | OPERADOR NEW | MÉTODO CONSTRUTOR
            Pessoa pessoa1 = new Pessoa();

            //invocar o método provarExistencia

            pessoa1.provarExistencia();

            //inserir dados no objeto
            pessoa1.nome = "Marcelo";
            pessoa1.email = "m@g";
            pessoa1.login = "marcelo";
            pessoa1.senha = "123";

            //recuperar os dados do objeto
            Console.WriteLine(pessoa1.nome);
            Console.WriteLine(pessoa1.email);
            Console.WriteLine(pessoa1.login);
            Console.WriteLine(pessoa1.senha);
            //Cosole.WriteLine("Hello,World!");

            //método construtor
            // TIPO_DO_DADO | NOME DA INSTÂNCIA (OBJETO | OPERADOR NEW | MÉTODO CONSTRUTOR
            Pessoa pessoa2 = new Pessoa();

            //invocar o método provarExistencia

            pessoa1.provarExistencia();

            //inserir dados no objeto
            pessoa1.nome = "Marcelo";
            pessoa1.email = "m@g";
            pessoa1.login = "marcelo";
            pessoa1.senha = "123";

            //recuperar os dados do objeto
            Console.WriteLine(pessoa1.nome);
            Console.WriteLine(pessoa1.email);
            Console.WriteLine(pessoa1.login);
            Console.WriteLine(pessoa1.senha);
        }
    }
}
