using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            int u, o, t;
            string[] palavrale = new string[61], dicale = new string[61];
            palavrale[0] = "empatia";
            dicale[0] = "Capacidade de compreender o sentimento ou reação de outrem.";
            palavrale[1] = "proativo";
            dicale[1] = "Aquele que visa antecipar futuros problemas, necessidades ou diversidades.";
            palavrale[2] = "consumo";
            dicale[2] = "Ato de extração de mercadoria, aplicações das riquezas na satisfação das necessidades econômicas do homem.";
            palavrale[3] = "casa";
            dicale[3] = "Lugar onde alguém mora";
            palavrale[4] = "cais";
            dicale[4] = "Muralha de alvenaria ou pedras, levantada ao longo de um curso de água para firmar as margens e impedir transbordamentos.";
            palavrale[5] = "autonomia";
            dicale[5] = "Aquele que é independente, que toma suas próprias decisões.";
            palavrale[6] = "entrada";
            dicale[6] = "Ponto inicial que dá acesso à determinado local.";
            palavrale[7] = "xingamentos";
            dicale[7] = "Chamar a pessoa de algo que ela não goste.";
            palavrale[8] = "hur dur";
            dicale[8] = "É uma palavra usada na internet se referindo à uma pessoa com pouco discernimento mental.";
            palavrale[9] = "dropado";
            dicale[9] = "Termo técnico/popular para remoção de dados de um banco de dados.";
            palavrale[10] = "resistencia";
            dicale[10] = "Força que se opõe à outra, que não cede a outra.";
            palavrale[11] = "letivo";
            dicale[11] = "Relativos à lição ou a programações de educação.";
            palavrale[12] = "stalkear";
            dicale[12] = "Vigilância exacerbada que uma pessoa faz  a outra, muitas vezes forçando contatos indesejados.";
            palavrale[13] = "cetico";
            dicale[13] = "Aquele que tem que ver para crer.";
            palavrale[14] = "cliche";
            dicale[14] = "Aquilo que é previsível, desgastou-se e perdeu o sentido ou se tornou algo que gera uma reação ruim, algo cansativo em vez de dar o efeito esperado ou simplesmente repetitivo.";
            palavrale[15] = "clickbait";
            dicale[15] = "Conteúdo de natureza sensacionalista ou provocativa, cujo principal é atrair atenção e chamar usuários para determinado website.";
            palavrale[16] = "escroto";
            dicale[16] = "Malfeito, ordinário, grosseiro, vagabundo.";
            palavrale[17] = "cocota";
            dicale[17] = "Gata, mulher que chama atenção!";
            palavrale[18] = "inquisiçao";
            dicale[18] = "Retomar à terra sagrada dos héreges.";
            palavrale[19] = "rapariga";
            dicale[19] = "Denominação nas regiões do Norte e Nordeste do Brasil, que é sinônimo de meretriz e amante.";
            palavrale[20] = "mickey";
            dicale[20] = "mascote da disney";
            palavrale[21] = "tortura";
            dicale[21] = "programaçao";
            palavrale[22] = "simpsons";
            dicale[22] = "pessoas amarelas";
            palavrale[23] = "viado";
            dicale[23] = "gaucho";
            palavrale[24] = "fome";
            dicale[24] = "comunismo";
            palavrale[25] = "naruto";
            dicale[25] = "melhor anime";
            palavrale[26] = "gaviao arqueiro";
            dicale[26] = "vingador mais forte";
            palavrale[27] = "bomberman";
            dicale[27] = "1º batlle royale";
            palavrale[28] = "computador";
            dicale[28] = "máquina electrónica que permite processar dados";
            palavrale[29] = "interminavel";
            dicale[29] = "one piece";
            palavrale[30] = "funk";
            dicale[30] = "não deveria ser considerado estilo musical";
            palavrale[31] = "austria";
            dicale[31] = "País da Europa";
            palavrale[32] = "golfinho";
            dicale[32] = "Mamífero";
            palavrale[33] = "axila";
            dicale[33] = "corpo humano";
            palavrale[34] = "carbono";
            dicale[34] = "Elemento Químico";
            palavrale[35] = "oganesson";
            dicale[35] = "Elemento Químico";
            palavrale[36] = "piracanjuba";
            dicale[36] = "peixe ou latcinos";
            palavrale[37] = "carlos";
            dicale[37] = "vendeu o play4 pra volta com a namorada";
            palavrale[38] = "urubu";
            dicale[38] = "carniça";
            palavrale[39] = "xvideos";
            dicale[39] = "site com filmes, series, animes e porno";
            palavrale[40] = "alegria";
            dicale[40] = "sentimento";
            palavrale[41] = "lampada";
            dicale[41] = "Feito de uma ideia";
            palavrale[42] = "infraestrutura";
            dicale[42] = "base invisivel que suporta uma contruçao.";
            palavrale[43] = "tinta";
            dicale[43] = "uma das primeiras foi sangue";
            palavrale[44] = "feromonio";
            dicale[44] = "usado na comunicaçao de individuos da mesma especie como os insetos.";
            palavrale[45] = "peixe";
            dicale[45] = "animal";
            palavrale[46] = "acne";
            dicale[46] = "condicao da pele.";
            palavrale[47] = "elevador";
            dicale[47] = "usado na locomoçao de pessoas.";
            palavrale[48] = "enclausurado";
            dicale[48] = "Sofreu as consequencias de um crime.";
            palavrale[49] = "tardigrado";
            dicale[49] = "animal resistente e microscopico";
            palavrale[50] = "gravata";
            dicale[50] = "usado em eventos sociais e combates.";
            palavrale[51] = "caverna";
            dicale[51] = "Um lugar seguro";
            palavrale[52] = "ventilador";
            dicale[52] = "refrescante";
            palavrale[53] = "montanha";
            dicale[53] = "alto";
            palavrale[54] = "cachorro";
            dicale[54] = "confiança";
            palavrale[55] = "horizonte";
            dicale[55] = "lugar visivel e intocavel";
            palavrale[56] = "camaleao";
            dicale[56] = "animal ninja";
            palavrale[57] = "bala";
            dicale[57] = "doce";
            palavrale[58] = "teclado";
            dicale[58] = "instrumento musical";
            palavrale[59] = "diamante";
            dicale[59] = "pedra";
            palavrale[60] = "arvore";
            dicale[60] = "vegetal";
            u = 1;
            do
            {
                Console.WriteLine("Escolha o modo de jogo\n1 - Contra outro jogador\n2 - Contra a maquina\n3 - Sair");
                o = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (o)
                {
                    case 1:
                        int p = 1;
                        do
                        {
                            int x, y, w, k;
                            string palavra, dica, palavra2, palavra3, palavra4, alfa, h;
                            char[] func = new char[30], func2 = new char[30], chute = new char[30];
                            char letra, z, alfabeto;
                            w = 0;
                            Console.WriteLine("Digite uma palavra: ");
                            palavra = Console.ReadLine();
                            Console.WriteLine("Digite uma dica: ");
                            dica = Console.ReadLine();
                            Console.Clear();
                            for (y = 0; y < 30; y++)
                            {
                                func[y] = '_';
                                func2[y] = '_';
                            }
                            palavra = palavra + "                                        ";
                            for (y = 0; y < 30; y++)
                            {
                                letra = palavra[y];
                                func[y] = letra;
                            }
                            for (x = 0; x < 30; x++)
                            {
                                if (func[x] != ' ')
                                {
                                    func2[x] = '_';
                                }
                                else if (func[x] == ' ')
                                {
                                    func2[x] = ' ';
                                }
                            }
                            palavra2 = "";
                            palavra3 = "";
                            palavra4 = "";
                            alfa = "";
                            for (x = 0; x < 30; x++)
                            {
                                palavra2 = palavra2 + func[x];
                            }
                            y = 1;
                            while (y == 1)
                            {
                                if (w == 0)
                                {
                                    Console.WriteLine(" -------------------------------------- ");
                                    Console.WriteLine("                                        ");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 1)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                        ");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 2)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                       |");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 3)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 4)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|\\");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 5)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|\\");
                                    Console.WriteLine("                                      / ");
                                }
                                else if (w == 6)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|\\");
                                    Console.WriteLine("                                      / \\");
                                    y = 2;
                                }
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0} ", func2[t]);
                                }
                                Console.WriteLine("\n{0}", alfa);
                                Console.WriteLine("A dica é {0}", dica);
                                Console.WriteLine("Digite uma letra:");
                                h = Console.ReadLine();
                                z = h[0];
                                k = 0;
                                for (x = 0; x < 30; x++)
                                {
                                    if (z == func[x])
                                    {
                                        func2[x] = z;
                                    }
                                    else
                                    {
                                        k++;
                                    }
                                }
                                if (k == 30)
                                {
                                    w++;
                                }
                                Console.Clear();
                                palavra3 = "";
                                for (x = 0; x < 30; x++)
                                {
                                    palavra3 = palavra3 + func2[x];
                                    if (palavra2 == palavra3)
                                    {
                                        y = 2;
                                    }
                                }
                                alfabeto = z;
                                alfa = alfa + "-" + alfabeto;
                                palavra4 = h + "                                   ";
                                for (x = 0; x < 30; x++)
                                {
                                    letra = palavra4[x];
                                    chute[x] = letra;
                                }
                                palavra4 = "";
                                for (x = 0; x < 30; x++)
                                {
                                    palavra4 = palavra4 + chute[x];
                                }
                                if (palavra2 == palavra4)
                                {
                                    y = 2;
                                }
                            }
                            if (palavra2 == palavra3)
                            {
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0}", func[t]);
                                }
                                Console.WriteLine("\nVoce Acertou a palavra");
                                Console.ReadKey();
                            }
                            else if (palavra4 == palavra2)
                            {
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0}", func[t]);
                                }
                                Console.WriteLine("\nVoce Acertou a palavra");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine(" Ô");
                                Console.WriteLine("/|\\");
                                Console.WriteLine("/ \\");
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0}", func[t]);
                                }
                                Console.WriteLine("\nVoce perdeu");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Deseja jogar novamente?\n1 - Sim\n2 - Não");
                            p = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (p == 1);
                        break;
                    case 2:
                        p = 1;
                        do
                        {
                            int x, y, w, k;
                            string palavra, dica, palavra2, palavra3, palavra4, alfa, h;
                            char[] func = new char[30], func2 = new char[30], chute = new char[30];
                            char letra, z, alfabeto;
                            w = 0;
                            Random random = new Random();
                            int ale = random.Next(0, 60);
                            palavra = palavrale[ale];
                            dica = dicale[ale];
                            Console.Clear();
                            for (y = 0; y < 30; y++)
                            {
                                func[y] = '_';
                                func2[y] = '_';
                            }
                            palavra = palavra + "                                        ";
                            for (y = 0; y < 30; y++)
                            {
                                letra = palavra[y];
                                func[y] = letra;
                            }
                            for (x = 0; x < 30; x++)
                            {
                                if (func[x] != ' ')
                                {
                                    func2[x] = '_';
                                }
                                else if (func[x] == ' ')
                                {
                                    func2[x] = ' ';
                                }
                            }
                            palavra2 = "";
                            palavra3 = "";
                            palavra4 = "";
                            alfa = "";
                            for (x = 0; x < 30; x++)
                            {
                                palavra2 = palavra2 + func[x];
                            }
                            y = 1;
                            while (y == 1)
                            {
                                if (w == 0)
                                {
                                    Console.WriteLine(" -------------------------------------- ");
                                    Console.WriteLine("                                        ");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 1)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                        ");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 2)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                       |");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 3)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|");
                                    Console.WriteLine("                                        ");
                                }
                                else if (w == 4)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|\\");
                                    Console.WriteLine("                                         ");
                                }
                                else if (w == 5)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|\\");
                                    Console.WriteLine("                                      / ");
                                }
                                else if (w == 6)
                                {
                                    Console.WriteLine("---------------------------------------Ô");
                                    Console.WriteLine("                                      /|\\");
                                    Console.WriteLine("                                      / \\");
                                    y = 2;
                                }
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0} ", func2[t]);
                                }
                                Console.WriteLine("\n{0}", alfa);
                                Console.WriteLine("A dica é {0}", dica);
                                Console.WriteLine("Digite uma letra:");
                                h = Console.ReadLine();
                                z = h[0];
                                k = 0;
                                for (x = 0; x < 30; x++)
                                {
                                    if (z == func[x])
                                    {
                                        func2[x] = z;
                                    }
                                    else
                                    {
                                        k++;
                                    }
                                }
                                if (k == 30)
                                {
                                    w++;
                                }
                                Console.Clear();
                                palavra3 = "";
                                for (x = 0; x < 30; x++)
                                {
                                    palavra3 = palavra3 + func2[x];
                                    if (palavra2 == palavra3)
                                    {
                                        y = 2;
                                    }
                                }
                                alfabeto = z;
                                alfa = alfa + "-" + alfabeto;
                                palavra4 = h + "                                   ";
                                for (x = 0; x < 30; x++)
                                {
                                    letra = palavra4[x];
                                    chute[x] = letra;
                                }
                                palavra4 = "";
                                for (x = 0; x < 30; x++)
                                {
                                    palavra4 = palavra4 + chute[x];
                                }
                                if (palavra2 == palavra4)
                                {
                                    y = 2;
                                }
                            }
                            if (palavra2 == palavra3)
                            {
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0}", func[t]);
                                }
                                Console.WriteLine("\nVoce Acertou a palavra");
                                Console.ReadKey();
                            }
                            else if (palavra4 == palavra2)
                            {
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0}", func[t]);
                                }
                                Console.WriteLine("\nVoce Acertou a palavra");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine(" Ô");
                                Console.WriteLine("/|\\");
                                Console.WriteLine("/ \\");
                                for (t = 0; t < 30; t++)
                                {
                                    Console.Write("{0}", func[t]);
                                }
                                Console.WriteLine("\nVoce perdeu");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Deseja jogar novamente?\n1 - Sim\n2 - Não");
                            p = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (p == 1);
                        break;
                }
                Console.WriteLine("Deseja voltar ao menu inicial\n1 - Sim\n2 - Não");
                u = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (u == 1);
            Console.WriteLine("Obrigado por jogar");
            System.Threading.Thread.Sleep(2000);
        }
    }
}

