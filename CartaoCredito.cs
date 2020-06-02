namespace Aula8Abstraçao
{
    public class CartaoCredito : cartao
    {
        public float limite { get; set; }

        public float AumentarLimite(float limiteAtual, float acrescimo){
            return limiteAtual + acrescimo;
        }

            public string BloquearCartaoDeCredito(){
                return "Cartao de credito bloqueado";
            }


    }
}