namespace HerancaPOO
{
    public class CNPJ: Pessoa
    {
        public string cnpj;
        public bool validarCNPJ(){
            if(cnpj != ""){
            return true;
            }
            else{
            return false;
            }
        }
    
    }
}