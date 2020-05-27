using System;

namespace aula_de_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            celular iphone = new celular();
            iphone.modelo = "iphone19 max";
            iphone.cor = "branco";
            iphone.tamanho = 6.5f;
            Console.WriteLine("o celular esta ligado ?");
            iphone.ligado = Boolean.Parse(Console.ReadLine());
            iphone.ligado = true;
            iphone.desligado = false;
            

            if(iphone.ligado){
                Console.WriteLine( iphone.FazerLigacao());
                Console.WriteLine( iphone.EnviarMensagem());
                Console.WriteLine( iphone.desligar());
               
                
            }
            else{
                 Console.WriteLine( iphone.ligar());
                
            }





            

            





        }
    }
}
