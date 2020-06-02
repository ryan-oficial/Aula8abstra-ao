namespace Aula8Abstraçao
{
    public class CartaoDebito : cartao
    {
          public float saldo { get; set; }

          public string Transferir(float valor){
              return $"R$ {valor} transferido de sua conta";

          }

          public string PagarTitulo(){
              return "Titulo pago com cartão de debito";
          }



    }
}