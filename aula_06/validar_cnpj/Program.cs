using System;

namespace validar_cnpj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CPF:");
            string cnpj = Console.ReadLine();
            Console.WriteLine(validarCNPJ(cnpj));
        }

        static bool validarCNPJ(string cnpjUsuario){
            bool resultado = false;
            int[] v1 = {5,4,3,2,9,8,7,6,5,4,3,2};
            string cnpjCalculo = "";
            int calculo = 0 ;
            string digito_v1 = "";
            string digito_v2 = "";
            int resto = 0;
            
             //o replace elimina o trim da variável
            cnpjUsuario = cnpjUsuario.Replace(" ","");
            cnpjUsuario = cnpjUsuario.Replace(".","");
            cnpjUsuario = cnpjUsuario.Replace("/","");
            cnpjUsuario = cnpjUsuario.Replace("-","");



           //atribuindo 12 valores do total (14) do cnpj à variável cnpjCalculo
            cnpjCalculo = cnpjUsuario.Substring(0,12);

            for(int i = 0; i <= 11 ; i++){
                calculo += int.Parse(cnpjUsuario[i].ToString()) * v1[i];

            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(calculo < 2){
                digito_v1 = "0";
            }else{
                digito_v1 = calculo.ToString();
            }

            if(digito_v1 == cnpjUsuario[12].ToString()){
                resultado = true;
            }


            
            int[] v2 = {6,5,4,3,2,9,8,7,6,5,4,3,2};
            resto = 0;
            //atribuindo o último dígito válido do cnpj _ agora ele possui 13 dígitos_
            cnpjCalculo = cnpjCalculo + calculo;
                        


            for(int i = 0; i <= 12 ; i++){
                calculo += int.Parse(cnpjUsuario[i].ToString()) * v2[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(calculo < 2){
                digito_v2 = "0";
            }else{
                digito_v2 = calculo.ToString();
            }

            if(digito_v2 == cnpjUsuario[13].ToString()){
                resultado = true;
            }
            return resultado;
        }
    }
}
