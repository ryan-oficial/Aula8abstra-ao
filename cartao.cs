namespace Aula8Abstraçao
{
    public class cartao : pagamento
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
        private string token = "afiah8es4e1s46h48s4d891h4aet489rf4i1498f184q9t465g";


        public bool ValidarToken(){
            if(token != null){
            return true;

            } return false;
        }
            


    }
}