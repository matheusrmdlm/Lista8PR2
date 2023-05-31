using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Este é o exercício 1.");
            int quantidadeTotal = 0;
            decimal valorTotal = 0;

            do
            {
                Console.Write("Digite a quantidade de itens adquiridos (ou <= 0 para sair): ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade <= 0)
                    break;

                Console.Write("Digite o preço do produto: R$ ");
                decimal preco = decimal.Parse(Console.ReadLine());

                quantidadeTotal += quantidade;
                valorTotal += quantidade * preco;

            } while (true);

            Console.WriteLine("Quantidade total de itens adquiridos: " + quantidadeTotal);
            Console.WriteLine("Valor total da compra: R$ " + valorTotal.ToString("F2"));
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Este é o exercício 2.");
            string produto;
            int quantidade;
            decimal preco;
            decimal maiorInvestimento = decimal.MinValue;
            decimal menorInvestimento = decimal.MaxValue;
            string produtoMaiorInvestimento = "";
            string produtoMenorInvestimento = "";

            do
            {
                Console.Write("Digite o nome do produto (ou 'parar' para encerrar o cadastro): ");
                produto = Console.ReadLine();

                if (produto.ToLower() == "parar")
                    break;

                Console.Write("Digite o número de itens do produto: ");
                quantidade = int.Parse(Console.ReadLine());

                Console.Write("Digite o preço de compra do produto: R$ ");
                preco = decimal.Parse(Console.ReadLine());

                decimal investimentoTotal = quantidade * preco;

                if (investimentoTotal > maiorInvestimento)
                {
                    maiorInvestimento = investimentoTotal;
                    produtoMaiorInvestimento = produto;
                }

                if (investimentoTotal < menorInvestimento)
                {
                    menorInvestimento = investimentoTotal;
                    produtoMenorInvestimento = produto;
                }

            } while (true);

            Console.WriteLine("Maior investimento: " + produtoMaiorInvestimento + " - R$ " + maiorInvestimento.ToString("F2"));
            Console.WriteLine("Menor investimento: " + produtoMenorInvestimento + " - R$ " + menorInvestimento.ToString("F2"));
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Este é o exercício 3.");
            int numeroAvaliacoes;
            decimal somaPesos = 0;

            Console.Write("Digite o número de avaliações que serão oferecidas: ");
            numeroAvaliacoes = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o peso da avaliação (em %): ");
                decimal peso = decimal.Parse(Console.ReadLine());

                somaPesos += peso;

                numeroAvaliacoes--;

            } while (numeroAvaliacoes > 0);

            Console.WriteLine("Soma total dos pesos: " + somaPesos + "%");

            if (somaPesos < 100)
            {
                Console.WriteLine("A soma total dos pesos é insuficiente.");
            }
            else if (somaPesos > 100)
            {
                Console.WriteLine("A soma total dos pesos é excedente.");
            }
            else
            {
                Console.WriteLine("A soma total dos pesos é adequada.");
            }
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Neste exercício será codificado o exercício 4");
            string sigla;
            string nomeEstado;

            do
            {
                Console.Write("Digite a sigla de um estado (ou 'sair' para encerrar): ");
                sigla = Console.ReadLine().ToUpper();

                switch (sigla)
                {
                    case "AC":
                        nomeEstado = "Acre";
                        break;
                    case "AL":
                        nomeEstado = "Alagoas";
                        break;
                    case "AM":
                        nomeEstado = "Amazonas";
                        break;
                    case "AP":
                        nomeEstado = "Amapá";
                        break;
                    case "BA":
                        nomeEstado = "Bahia";
                        break;
                    case "CE":
                        nomeEstado = "Ceará";
                        break;
                    case "DF":
                        nomeEstado = "Distrito Federal";
                        break;
                    case "ES":
                        nomeEstado = "Espírito Santo";
                        break;
                    case "GO":
                        nomeEstado = "Goiás";
                        break;
                    case "MA":
                        nomeEstado = "Maranhão";
                        break;
                    case "MG":
                        nomeEstado = "Minas Gerais";
                        break;
                    case "MS":
                        nomeEstado = "Mato Grosso do Sul";
                        break;
                    case "MT":
                        nomeEstado = "Mato Grosso";
                        break;
                    case "PA":
                        nomeEstado = "Pará";
                        break;
                    case "PB":
                        nomeEstado = "Paraíba";
                        break;
                    case "PE":
                        nomeEstado = "Pernambuco";
                        break;
                    case "PI":
                        nomeEstado = "Piauí";
                        break;
                    case "PR":
                        nomeEstado = "Paraná";
                        break;
                    case "RJ":
                        nomeEstado = "Rio de Janeiro";
                        break;
                    case "RN":
                        nomeEstado = "Rio Grande do Norte";
                        break;
                    case "RO":
                        nomeEstado = "Rondônia";
                        break;
                    case "RR":
                        nomeEstado = "Roraima";
                        break;
                    case "RS":
                        nomeEstado = "Rio Grande do Sul";
                        break;
                    case "SC":
                        nomeEstado = "Santa Catarina";
                        break;
                    case "SE":
                        nomeEstado = "Sergipe";
                        break;
                    case "SP":
                        nomeEstado = "São Paulo";
                        break;
                    case "TO":
                        nomeEstado = "Tocantins";
                        break;
                    case "Sair":
                        continue;
                    default:
                        nomeEstado = "Sigla inválida";
                        break;
                }

                Console.WriteLine("O estado correspondente à sigla é: " + nomeEstado);

            } while (sigla != "SAIR");
        }

        public static void Exercicio5()
        {
            Console.WriteLine("Neste exercício será codificado o exercício 5");
            int mes;
            string estacao = "";

            do
            {
                Console.Write("Digite um número inteiro entre 1 e 12 (representando um mês do ano): ");
                mes = int.Parse(Console.ReadLine());

                switch (mes)
                {
                    case 12:
                    case 1:
                    case 2:
                        estacao = "Verão";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        estacao = "Outono";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        estacao = "Inverno";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        estacao = "Primavera";
                        break;
                    default:
                        Console.WriteLine("Número inválido. Por favor, tente novamente.");
                        continue;
                }
                if ((mes == 3 && DateTime.Now.Year == 2023) || (mes == 12 && DateTime.Now.Year == 2022))
                {
                    Console.Write("O mês escolhido possui duas estações. Digite '1' para considerar a primeira estação (Verão ou Primavera) ou '2' para considerar a segunda estação (Outono ou Inverno): ");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 2)
                    {
                        if (estacao == "Verão")
                            estacao = "Primavera";
                        else if (estacao == "Outono")
                            estacao = "Inverno";
                    }
                }

                Console.WriteLine("A estação do ano correspondente é: " + estacao);

            } while (mes < 1 || mes > 12);
        }



        public static void Exercicio6()
        {
            Console.WriteLine("Neste exercício será codificado o exercício 6");
            string comando;

            do
            {
                Console.Write("Digite o seu peso em kg: ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Digite a sua altura em metros: ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                string faixaDePeso;

                if (imc < 18.5)
                {
                    faixaDePeso = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    faixaDePeso = "Peso normal";
                }
                else if (imc >= 25.0 && imc <= 29.9)
                {
                    faixaDePeso = "Sobrepeso";
                }
                else if (imc >= 30.0 && imc <= 34.9)
                {
                    faixaDePeso = "Obesidade grau 1";
                }
                else if (imc >= 35.0 && imc <= 39.9)
                {
                    faixaDePeso = "Obesidade grau 2";
                }
                else
                {
                    faixaDePeso = "Obesidade grau 3 (mórbida)";
                }

                Console.WriteLine("O seu IMC é: " + imc);
                Console.WriteLine("Faixa de peso: " + faixaDePeso);

                Console.Write("Digite 'sair' para encerrar o programa ou pressione Enter para realizar uma nova entrada: ");
                comando = Console.ReadLine();

            } while (comando.ToLower() != "sair");
        }

        public static void Exercicio7()
        {
            Console.WriteLine("Neste exercício será codificado o exercício 7");
            int numero;

            do
            {
                Console.Write("Digite um número inteiro maior que zero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("Número inválido. Por favor, tente novamente.");
                    continue;
                }

                Console.WriteLine("Divisores de " + numero + ":");

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            } while (numero <= 0);
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("     Menu");
                Console.WriteLine("Para sair, digite 0");
                Console.WriteLine("exercício 1");
                Console.WriteLine("exercício 2");
                Console.WriteLine("exercício 3");
                Console.WriteLine("exercício 4");
                Console.WriteLine("exercício 5");
                Console.WriteLine("exercício 6");
                Console.WriteLine("exercício 7");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        Exercicio7();
                        break;
                    default:
                        Console.WriteLine("O número não corresponde a um exercício válido. Por favor, tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
