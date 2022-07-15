using System;
using System.Collections.Generic;
using System.Text;

namespace Cores_RGB
{
    class CorRGB //classe que represente uma cor RGB
    {
        //representação estatica da classe
        public int red { get; set; }     //priv
        public int green { get; set; }
        public int blue { get; set; }
        public int luminosidade { get; set; }
                        
                            //parametros do contrutor
        public CorRGB(int red,int blue,int green) //construtor para criar uma cor
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        //construtor para criar uma cópia
        public CorRGB(CorRGB rgbcopia)
        {
            this.red = rgbcopia.red;
            this.green = rgbcopia.green;
            this.blue = rgbcopia.blue;
        }
  
        //construtor da cor preta
        public CorRGB()
        {
            red = 0;
            green = 0;
            blue = 0;
        }

        public int MostraRecebeCorRed() //metodos MostrarReceberCorRed
        {
            Console.WriteLine("Digite o valor da cor red: ");
            this.red = Int32.Parse(Console.ReadLine()); //this serve para se referir aos atributos da classe
            return red;
        }
        public int MostraRecebeCorGreen() 
        {
            Console.WriteLine("Digite o valor da cor green: ");
            this.green = Int32.Parse(Console.ReadLine());
            return green;
        }
        public int MostraRecebeCorBlue() 
        {
            Console.WriteLine("Digite o valor da cor blue: ");
            this.blue = Int32.Parse(Console.ReadLine());
            return blue;
        }
        public int ler_luminosidade()
        {   //truncamento do valor
            var luminosidade = Math.Truncate(red * 0.3 + green * 0.59 + blue* 0.11);
            int lum = Convert.ToInt32(luminosidade);
            Console.WriteLine("O valor da luminosidade é: "+ lum);
            return lum;//retorno do metodo
        }

     

        //metodo que compara se as cores são iguais
        public bool CompararCores(CorRGB cor1,CorRGB cor2)
        {
            if (cor1.red.Equals (cor2.red)&& (cor1.blue == cor2.blue)&&(cor1.green == cor2.green)) { 
         
                return true;
            }

            else
            {
                return false;
            }
        }
        //metodo para retornar uma nova cor que equivale ao cinza
        public CorRGB RetornaCinza(CorRGB cor) //tipo objeto novo
        {
           int luminosidadee = ler_luminosidade(); //acessa a luminosidade de uma nova cor

           CorRGB novaCor = new CorRGB(); 
            novaCor.red = luminosidadee;   //coloca a luminosidade da cor 
            novaCor.green = luminosidadee;
            novaCor.blue = luminosidadee;
            Console.WriteLine("#" + luminosidadee + luminosidadee + luminosidadee);
            return novaCor; //falta terminar
            //converter em hexadecimal;
          }

        public CorRGB CorHexa(CorRGB corhex) //metodo para transforma a cor digitada em hexadecimal
        {
            int corR = MostraRecebeCorRed();
            int corG = MostraRecebeCorGreen();
            int corB = MostraRecebeCorBlue();
            CorRGB corHex = new CorRGB();
            corHex.red = corR;
            corHex.green = corG;
            corHex.blue = corB;
            string hex = corR.ToString("X");
            string hex1 = corG.ToString("x");
            string hex2 = corB.ToString("X");
            Console.WriteLine("#"+ hex + hex1 + hex2);
            return corHex;
        }
        //metodo clarear tem q continuar
        public CorRGB Clarear(CorRGB corclara) //metodo para transforma a cor digitada em hexadecimal
        {
            int corR = MostraRecebeCorRed();
            int corG = MostraRecebeCorGreen();
            int corB = MostraRecebeCorBlue();
            CorRGB corClara = new CorRGB();
            corclara.red = corR;
            corclara.green = corG;
            corclara.blue = corB;
            string hex = corR.ToString("X");
            string hex1 = corG.ToString("x");
            string hex2 = corB.ToString("X");
            Console.WriteLine("#" + hex + hex1 + hex2);
            return corclara;
        }



        /*  public int Soma(int a, int b) //exemplo do metodo
          {
              int resultado = a + b;
              return resultado;
          }*/


    }
    }

