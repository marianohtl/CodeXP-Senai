using System;
using ex_02.Controller;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
           CelularControllers celular = new CelularControllers();

        //    celular.CadastrarCelular();

           celular.ligar();
           celular.fazerLigacao();
           celular.desligar();
           celular.fazerLigacao();


           celular.ligar();
           celular.enviarMensagem();
           celular.desligar();
           celular.enviarMensagem();

        //    celular.enviarMensagem();
        //    celular.ligar();
        //    celular.enviarMensagem();

        }
    }
}
