using System;

class Program
{
    static void Main(string[] args)
    {
        //EXEC 1
        //    Console.WriteLine ("diga um número considerando que cada um vale de 1 a 7: ");
        //    int dia = int.Parse(Console.ReadLine());

        //    switch (dia)
        //    {
        //        case 1:
        //            Console.WriteLine("Domingo");
        //            break;
        //        case 2:
        //            Console.WriteLine("Segunda-feira");
        //            break;
        //        case 3:
        //            Console.WriteLine("Terça-feira");
        //            break;
        //        case 4:
        //            Console.WriteLine("Quarta-feira");
        //            break;
        //        case 5:
        //            Console.WriteLine("Quinta-feira");
        //            break;
        //        case 6:
        //            Console.WriteLine("Sexta-feira");
        //            break;
        //        case 7:
        //            Console.WriteLine("Sábado");
        //            break;
        //        default:
        //            Console.WriteLine("Número inválido");
        //            break;
        //    }
        //}
        //}

        //EXEC 2

        //        Console.Write("qual o valor total da compra? ");
        //        double valorTotal = double.Parse(Console.ReadLine());

        //        Console.WriteLine("em qual forma de pagamento você pagará? ");
        //        Console.WriteLine("1 - À vista no dinheiro (15% de desconto)");
        //        Console.WriteLine("2 - À vista no PIX (10% de desconto)");
        //        Console.WriteLine("3 - No débito (5% de acréscimo)");
        //        Console.WriteLine("4 - No cartão de crédito (10% de acréscimo)");
        //        int formaPagamento = int.Parse(Console.ReadLine());

        //        double valorFinal = valorTotal;

        //        switch (formaPagamento)
        //        {
        //            case 1:
        //                valorFinal *= 0.85;
        //                Console.WriteLine("Valor final a ser pago: R$" + valorFinal);
        //                break;
        //            case 2:
        //                valorFinal *= 0.9;
        //                Console.WriteLine("Valor final a ser pago: R$" + valorFinal);
        //                break;
        //            case 3:
        //                valorFinal *= 1.05;
        //                Console.WriteLine("Valor final a ser pago: R$" + valorFinal);
        //                break;
        //            case 4:
        //                valorFinal *= 1.1;
        //                Console.WriteLine("Valor final a ser pago: R$" + valorFinal);
        //                break;
        //            default:
        //                Console.WriteLine("Forma de pagamento inválida");
        //                break;
        //        }
        //    }
        //}

        //EXEC 3

        //        Console.Write("escolha um mês de 1 a 12: ");
        //        int mes = int.Parse(Console.ReadLine());

        //        Console.Write("escolha um ano: ");
        //        int ano = int.Parse(Console.ReadLine());

        //        int qtdDias = 0;
        //        string nomeMes = "";

        //        switch (mes)
        //        {
        //            case 1:
        //                nomeMes = "Janeiro";
        //                qtdDias = 31;
        //                break;
        //            case 2:
        //                nomeMes = "Fevereiro";
        //                if (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0))
        //                {
        //                    qtdDias = 29; // Ano bissexto
        //                }
        //                else
        //                {
        //                    qtdDias = 28; // Ano comum
        //                }
        //                break;
        //            case 3:
        //                nomeMes = "Março";
        //                qtdDias = 31;
        //                break;
        //            case 4:
        //                nomeMes = "Abril";
        //                qtdDias = 30;
        //                break;
        //            case 5:
        //                nomeMes = "Maio";
        //                qtdDias = 31;
        //                break;
        //            case 6:
        //                nomeMes = "Junho";
        //                qtdDias = 30;
        //                break;
        //            case 7:
        //                nomeMes = "Julho";
        //                qtdDias = 31;
        //                break;
        //            case 8:
        //                nomeMes = "Agosto";
        //                qtdDias = 31;
        //                break;
        //            case 9:
        //                nomeMes = "Setembro";
        //                qtdDias = 30;
        //                break;
        //            case 10:
        //                nomeMes = "Outubro";
        //                qtdDias = 31;
        //                break;
        //            case 11:
        //                nomeMes = "Novembro";
        //                qtdDias = 30;
        //                break;
        //            case 12:
        //                nomeMes = "Dezembro";
        //                qtdDias = 31;
        //                break;
        //            default:
        //                Console.WriteLine("Mês inválido");
        //                break;
        //        }

        //        if (qtdDias > 0)
        //        {
        //            Console.WriteLine(nomeMes + " tem " + qtdDias + " dias.");
        //        }
        //    }
        //}

        //EXEC 4

        //    Console.Write("Digite o primeiro número: ");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.Write("Digite o segundo número: ");
        //    int num2 = int.Parse(Console.ReadLine());

        //    Console.Write("Digite a operação (+, -, *, / ou ^): ");
        //    char operacao = char.Parse(Console.ReadLine());

        //    switch (operacao)
        //    {
        //        case '+':
        //            Console.WriteLine(num1 + num2);
        //            break;
        //        case '-':
        //            Console.WriteLine(num1 - num2);
        //            break;
        //        case '*':
        //            Console.WriteLine(num1 * num2);
        //            break;
        //        case '/':
        //            if (num2 != 0)
        //            {
        //                Console.WriteLine((double)num1 / num2);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Valor inválido, pois não é possível dividir por zero.");
        //            }
        //            break;
        //        case '^':
        //            Console.WriteLine(Math.Pow(num1, num2));
        //            break;
        //        default:
        //            Console.WriteLine("Operação inválida");
        //            break;
        //    }
        //}
        //}


        //EXEC 5

        //        Console.Write("qual o salário atual do funcionário? ");
        //        double salario = double.Parse(Console.ReadLine());

        //        Console.Write("qual é o código desse funcionário? ");
        //        int codigo = int.Parse(Console.ReadLine());

        //        double novoSalario;

        //        switch (codigo)
        //        {
        //            case 101:
        //                novoSalario = salario * 1.075;
        //                break;
        //            case 102:
        //                novoSalario = salario * 1.097;
        //                break;
        //            case 103:
        //                novoSalario = salario * 1.117;
        //                break;
        //            case 204:
        //                novoSalario = salario * 1.089;
        //                break;
        //            case 206:
        //                novoSalario = salario * 1.1324;
        //                break;
        //            case 301:
        //                novoSalario = salario * 1.104;
        //                break;
        //            case 302:
        //                novoSalario = salario * 1.146;
        //                break;
        //            default:
        //                novoSalario = salario * 1.435;
        //                break;
        //        }

        //        double diferenca = novoSalario - salario;

        //        Console.WriteLine("Salário atual: R$" + salario);
        //        Console.WriteLine("Novo salário: R$" + novoSalario);
        //        Console.WriteLine("Diferença: R$" + diferenca);
        //    }
        //}

        //EXEC 6

        Console.Write("Digite o salário mensal: ");
        double salario = double.Parse(Console.ReadLine());

        double imposto = 0;
        if (salario <= 1903.98)
        {
            imposto = 0;
        }
        else if (salario <= 2826.65)
        {
            imposto = salario * 0.075;
        }
        else if (salario <= 3751.05)
        {
            imposto = salario * 0.15;
        }
        else if (salario <= 4664.68)
        {
            imposto = salario * 0.225;
        }
        else
        {
            imposto = salario * 0.275;
        }

        double salarioLiquido = salario - imposto;

        Console.WriteLine($"Imposto a ser recolhido: R${imposto:F2}");
        Console.WriteLine($"Salário líquido: R${salarioLiquido:F2}");
    }
}