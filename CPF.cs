namespace HerancaPOO
{
    public class CPF : Pessoa
    
    {
        public string cpf = "19191919191";
        public string rg;
        public bool validarCPF(){
            if(cpf != ""){
                return true;
                }
            else{
            return false;
            }
        }
    }
}    