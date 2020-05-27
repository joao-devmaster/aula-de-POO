namespace aula_de_POO
{
    public class celular
    {
        public string cor;
        public string modelo;
        public bool ligado;

        public bool desligado;
        public float tamanho;

        public string ligar(){
            ligado = true;
            
        
            return "celular ligando";
        }

        public string desligar(){
            desligado = false;
            return "desligar celular";
        }
        

        

        public string EnviarMensagem(){
            return "enviar mensagem";
        }

        public string FazerLigacao(){
            return "fazer ligacao";
        }

        

       





        

       
        }

    }
