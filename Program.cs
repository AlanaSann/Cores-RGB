using System;

namespace Cores_RGB
{
    class Program
    {
        public static CorRGB CorRGB { get; private set; }

        static void Main(string[] args)
        {
            int opcao = -1;
            //corRgb variavel para se referir ao construtor
           CorRGB corRgb = new CorRGB(15,5,2);//cria objt pelo construtor
                                               //cria uma cor com 3  valores?
                                               // corRgb.mostra_recebe_cor_blue
           CorRGB corRgb1 = new CorRGB(15,5,2); //vii
                                                  //cor pra ser comparada
                                                  //mostra o resultado do metodo de comparação das cores
           Console.WriteLine("As cores são iguais? ");
            Console.WriteLine(corRgb.CompararCores(corRgb,corRgb1));
           // int soma = corRgb.Soma(8, 3); //exemplo
           // Console.WriteLine();
          
            
            while (opcao != 0)
            {
                Console.WriteLine("********************CORES RGB*************************");
                Console.WriteLine("\n(1)ALTERAR RED \n(2)ALTERAR BLUE \n(3)ALTERAR GREEN \n(4)LUMINOSIDADE \n(5)RETORNA A COR CINZA \n(6)REPRESENTAR UMA COR EM HEXADECIMAL");
                int i;
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        corRgb.MostraRecebeCorRed(); //5
                        break;

                    case 2:
                        corRgb.MostraRecebeCorBlue();//10
                        break;
                    case 3:
                        corRgb.MostraRecebeCorGreen();//3
                        break;

                    case 4:
                        corRgb.ler_luminosidade();
                        break;
                    case 5:
                        corRgb.RetornaCinza(CorRGB);
                        break;
                    case 6:
                        corRgb.CorHexa(CorRGB);
                        break;

                 
                }


         
            
                
            }

        }
    }
}
