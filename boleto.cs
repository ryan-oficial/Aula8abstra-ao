using System;

namespace Aula8Abstraçao
{
    public class boleto
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string  codDeBarras { get; set; }


        public string RegistrarBoleto(){
            return "Boleto registrado no sistema";
        }
    }
}