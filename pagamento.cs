using System;

namespace Aula8Abstraçao
{
    public class pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }


        public string Pagar(){
            return "pagamento efetuado";
        }
        public string CancelarPagamento(){
            return "pagamento cancelado";
        }
    }
}