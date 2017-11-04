using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_enunciado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara as constantes nlin (numero de linhas) e ncol (numero de colunas)
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            const int nlin = 20;
            const int ncol = 34;
            // codigo das setas de deslocamento: 37<-; 38 para cima; 39 ->; 40 para baixo

            // declara e inicia a matriz 10x8
            string[,] labirinto = new string[nlin, ncol]
            {
                { "\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"," ","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588 "," "," "," "," ","\u2588"," "," "," "," "," "," ","E","\u2588","\u2588","\u2588","E","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588"," "," "," "," ","\u2588"," ","\u2588"," "," "," "," "," "," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588"," ","\u2592","\u2588","\u2588","\u2588"," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588",},
                { "\u2588"," ","\u2588","\u2588","\u2588","\u2588"," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","E","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588"," ","\u2588","\u2588","\u2588","\u2588"," ","E","\u2588","\u2588","\u2588"," "," "," "," "," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","E","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { " "," ","\u2588","\u2588","\u2588","\u2588"," ","\u2588",""," "," "," "," "," ","C","E","T","2","2","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588","\u2588","\u2588","C"," ","\u2588","\u2588","\u2588","D","I","O","G","O","\u2592","N","A","S","C","I","M","E","N","T","O","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588","\u2588"," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"," "," "," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588","\u2588","E","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"," "," ","C"," "," ","\u2588","\u2588"," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588"," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"," ","\u2588","\u2588"," "," ","\u2588"," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588"," "," "," "," "," ","\u2588","\u2588","\u2588","\u2588","\u2588"," ","\u2588","\u2588","\u2588"," "," ","\u2588","\u2588"," "," "," "," "," "," "," "," "," "," "," "," ","E","\u2588"},
                { "\u2588"," ","E","\u2588","\u2588","\u2588","C","\u2588","\u2588","E","\u2588","\u2588"," ","\u2588","\u2588","\u2588"," "," ","\u2588","\u2588"," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588"," ","\u2588","\u2588","\u2588","\u2588"," ","\u2588","\u2588"," ","\u2588","\u2588"," ","\u2588","\u2588","\u2588"," "," "," "," "," "," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588"," ","\u2588","\u2588","\u2588","\u2588"," ","\u2588","\u2588"," ","\u2588","\u2588"," ","\u2588","\u2588","\u2588"," "," ","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588"," ","\u2588","\u2588","\u2588","\u2588"," "," "," "," "," "," "," ","\u2588","\u2588","\u2588"," "," "," "," "," "," "," ","G","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","E","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},
                { "\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588","\u2588"},


            };

            //para criar o jogador
            // ver caracteres no site unicode
            //string jog = "\x01";
            string jog = "X";
            labirinto[8, 0] = jog; // coloca o jogador no inicio
            //como movimentar o jogador no labirinto
            bool sair = false;
            //declarar as variaveis de deslocamento no labirinto
            int comando;
            int dinheiro = 0;
            int passos = 550;
            int l = 8, c = 0; //novas variaveis que referenciam o jogador a cada momento
            int xl = 10, xc = 15;
            while (sair == false)
            {
                
                Console.Clear();
                //mostrar o labirinto
                Console.WriteLine();
                Console.WriteLine("\n\n tem " + passos + " passos restantes");
                Console.WriteLine("\n\n tem " + dinheiro + " Euros");
                for (int i = 0; i < xl; i++)
                {
                    
                    Console.Write("\t\t\t\t\t\t\t");
                    for (int j = 0; j < xc; j++)
                        Console.Write(labirinto[i, j]);
                    //i e j vao referenciando cada posição do array
                    Console.WriteLine();
                }
                //indicar ao utilizador para se movimentar
                Console.WriteLine(" use as setas de deslocamento para se movimentar no labirinto");
                Console.WriteLine("Vá recolhendo o Dinheiro");
                Console.WriteLine(" DICA: o jogo só acaba se tiver a quantia necessaria");
                
                comando = Convert.ToInt32(Console.ReadKey().Key);
                Console.Clear();
                if (comando == 39)//desloca para a direita
                {
                    if (labirinto[l, c + 1] == " ")
                    {
                        labirinto[l, c] = " ";
                        labirinto[l, ++c] = jog;
                        labirinto[8, 0] = "\u2588";
                        passos--;
                    }
                }
                if (comando == 37)//desloca para a esquerda
                {
                    if (labirinto[l, c - 1] == " ")
                    {

                        labirinto[l, c] = " ";
                        labirinto[l, --c] = jog;
                        passos --;
                    }
                }
                if (comando == 38)//desloca para cima
                {
                    if (labirinto[l - 1, c] == " ")
                    {

                        labirinto[l, c] = " ";
                        labirinto[--l, c] = jog;
                        passos--;
                    }
                }
                if (comando == 40)//desloca para baixo
                {
                    if (labirinto[l + 1, c] == " ")
                    {

                        labirinto[l, c] = " ";
                        labirinto[++l, c] = jog;
                        passos--;
                    }
                }

                if (labirinto[l, c - 1] == "C")
                {

                    xl = 20;
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l, c - 1] = " ";
                        
                    }
                }
                
                if (labirinto[l, c + 1] == "C")
                {

                    xl = 20; xc = 34;
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l, c + 1] = " ";

                    }
                }
                if (labirinto[l - 1, c] == "E")
                {
                    
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l -1, c] = " ";
                        dinheiro++;
                      

                    }
                }
                if (labirinto[l, c+1] == "E")
                {
                    
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l, c+1] = " ";
                        dinheiro++;
                        
                    }
                }
                if (labirinto[l, c + 1] == "E")
                {

                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l, c + 1] = " ";
                        dinheiro++;

                    }
                }

                if (labirinto[l+1, c] == "E")
                {
                    
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l +1, c] = " ";
                        dinheiro++;
                       
                    }
                }


                if (labirinto[l + 1, c] == "C")
                {
                    xl = 20;xc = 25;
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l +1, c] = " ";

                    }
                }

                if (labirinto[l, c + 1] == "G")
                {  
                    labirinto[5, 2] = "E";
                    xl = 20; xc = 34;
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l, c + 1] = " ";
                        

                    }
                }
                if (dinheiro>=110&& dinheiro<140) labirinto[17, 1] = "P";
                if (labirinto[l + 1, c] == "P")
                {
                    labirinto[12, 31] = " ";
                    labirinto[11, 31] = " ";
                    labirinto[10, 31] = " ";
                    labirinto[9, 31] = " ";
                    labirinto[8, 31] = " ";
                    labirinto[7, 31] = " ";
                    labirinto[7, 30] = " ";
                    labirinto[7, 29] = " ";
                    labirinto[7, 28] = " ";
                    labirinto[7, 27] = " ";
                    labirinto[7, 26] = " ";
                    labirinto[7, 25] = " ";
                    labirinto[7, 24] = " ";
                    labirinto[7, 23] = " ";
                    labirinto[7, 22] = " ";
                    labirinto[7, 21] = " ";
                    labirinto[7, 20] = " ";
                    labirinto[7, 19] = " ";
                    labirinto[6, 19] = " ";
                    labirinto[5, 19] = " ";
                    labirinto[4, 19] = " ";
                    labirinto[4, 18] = " ";
                    labirinto[4, 17] = " ";
                    labirinto[4, 16] = " ";
                    labirinto[4, 15] = " ";
                    labirinto[9, 15] = "$";
                    labirinto[8, 1] = "E";
                    xl = 20; xc = 34;
                    Console.WriteLine();
                    for (int i = 0; i < xl; i++)
                    {
                        Console.Write("\t\t\t\t\t\t\t");
                        for (int j = 0; j < xc; j++)
                            Console.Write(labirinto[i, j]);
                        labirinto[l + 1, c] = " ";
                        

                    }

                }
                

                    if (dinheiro >= 160) labirinto[8, 7] = "H";
                {
                    
                    if (labirinto[l, c+1] == "H")
                    {
                        labirinto[9, 6] = " ";
                        labirinto[9, 7] = " ";
                        labirinto[9, 8] = " ";
                        labirinto[9, 9] = " ";
                        labirinto[10, 9] = " ";
                        labirinto[10, 10] = " ";
                        labirinto[10, 11] = " ";
                        labirinto[10, 12] = " ";
                        labirinto[10, 13] = " ";
                        labirinto[10, 14] = " ";
                        labirinto[10, 15] = " ";
                        labirinto[8, 1] = "E";
                        labirinto[7, 29] = "E";
                        labirinto[11, 31] = "E";
                        xl = 20; xc = 34;
                        Console.WriteLine();
                        for (int i = 0; i < xl; i++)
                        {
                            Console.Write("\t\t\t\t\t\t\t");
                            for (int j = 0; j < xc; j++)
                                Console.Write(labirinto[i, j]);
                            labirinto[l + 1, c] = " ";
                        }
                        }
                }
                    if (passos == 0)
                    { Console.Clear();

                    Console.WriteLine("╒═════════╕ ");
                    Console.WriteLine("│GAME     │");
                    Console.WriteLine("│OVER     │");
                    Console.WriteLine("╘═════════╛");
                    Console.ReadLine();
                    sair = true;

                    }
                
                if (labirinto[l - 1, c] == "$"&& dinheiro>200)
                {

                    Console.Clear();
                    Console.WriteLine("░█░░░░░░░░░░░░░░░░░████████░░ ");
                    Console.WriteLine("▐▌░░░░░░░░░░░░░░░░░▀██████▌░░ ");
                    Console.WriteLine("░▌▄███▌░░░░▀████▄░░░░▀████▌░░ ");
                    Console.WriteLine("▐▀▀▄█▄░▌░░░▄██▄▄▄▀░░░░████▄▄░ ");
                    Console.WriteLine("▐░▀░░═▐░░░░░░══░░▀░░░░▐▀░▄▀▌▌ ");
                    Console.WriteLine("▐░░░░░▌░░░░░░░░░░░░░░░▀░▀░░▌▌ ");
                    Console.WriteLine("▐░░░▄▀░░░▀░▌░░░░░░░░░░░░▌█░▌▌ ");
                    Console.WriteLine("░▌░░▀▀▄▄▀▀▄▌▌░░░░░░░░░░▐░▀▐▐░ ");
                    Console.WriteLine("░▌░░▌░▄▄▄▄░░░▌░░░░░░░░▐░░▀▐░░ ");
                    Console.WriteLine("░█░▐▄██████▄░▐░░░░░░░░█▀▄▄▀░░ ");
                    Console.WriteLine("░▐░▌▌░░░░░░▀▀▄▐░░░░░░█▌░░░░░░ ");
                    Console.WriteLine("░░█░░▄▀▀▀▀▄░▄═╝▄░░░▄▀░▌░░░░░░ ");
                    Console.WriteLine("░░░▌▐░░░░░░▌░▀▀░░▄▀░░▐░░░░░░░ ");
                    Console.WriteLine("░░░▀▄░░░░░░░░░▄▀▀░░░░█░░░░░░░ ");
                    Console.WriteLine("░░░▄█▄▄▄▄▄▄▄▀▀░░░░░░░▌▌░░░░░░ ");
                    Console.WriteLine("░░▄▀▌▀▌░░░░░░░░░░░░░▄▀▀▄░░░░░ ");
                    Console.WriteLine("▄▀░░▌░▀▄░░░░░░░░░░▄▀░░▌░▀▄░░░ ");
                    Console.WriteLine("░░░░▌█▄▄▀▄░░░░░░▄▀░░░░▌░░░▌▄▄ ");
                    Console.WriteLine("░░░▄▐██████▄▄░▄▀░░▄▄▄▄▌░░░░▄░ ");
                    Console.WriteLine("░░▄▌████████▄▄▄███████▌░░░░░▄ ");
                    Console.WriteLine("░▄▀░██████████████████▌▀▄░░░░ ");
                    Console.WriteLine("▀░░░█████▀▀░░░▀███████░░░▀▄░░ ");
                    Console.WriteLine("░░░░▐█▀░░░▐░░░░░▀████▌░░░░▀▄░ ");
                    Console.WriteLine("░░░░░░▌░░░▐░░░░▐░░▀▀█░░░░░░░▀ ");
                    Console.WriteLine("░░░░░░▐░░░░▌░░░▐░░░░░▌░░░░░░░ ");
                    Console.WriteLine("░╔╗║░╔═╗░═╦═░░░░░╔╗░░╔═╗░╦═╗░ ");
                    Console.WriteLine("░║║║░║░║░░║░░░░░░╠╩╗░╠═╣░║░║░ ");
                    Console.WriteLine("░║╚╝░╚═╝░░║░░░░░░╚═╝░║░║░╩═╝░ ");
                    sair = true;

                }





                //i e j vao referenciando cada posição do array

                // um console writeline em chavetas dentro do for para o labirinto nao ficar so numa linha
                Console.WriteLine();


            }

          


            

            Console.ReadKey();
        }
    }
}
