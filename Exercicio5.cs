/*## Exercício 05 — Bug no cálculo de comissão de vendas

Você é programador júnior na **VendaCerta CRM**, uma plataforma usada por equipes comerciais. Nas últimas semanas, alguns vendedores reclamaram que o sistema está mostrando **comissão errada** no fechamento do mês.

Seu **líder técnico** descobriu que o erro está na rotina que calcula a comissão com base no **total vendido** e no **percentual de comissão**.

Sua missão é **corrigir o cálculo** para que o sistema mostre corretamente:

1. **Total vendido** (valor da venda × quantidade)
2. **Valor da comissão** (total vendido × percentual/100)
3. **Total a receber** (salário fixo + comissão)

✅ Regras:

- Exiba os resultados com **2 casas decimais**.*/
public static class Exercicio5
{
    public static void Executar()
    {
        double valorVenda = 0;
        int quantidadeVendida = 0;
        double percentualComissao = 0;
        double salarioFixo = 0;

        Console.Write("Digite o valor da venda: ");
        valorVenda = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade vendida: ");
        quantidadeVendida = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o percentual de comissão: ");
        percentualComissao = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o salário fixo do vendedor: ");
        salarioFixo = double.Parse(Console.ReadLine()!);

        double totalVendido = valorVenda * quantidadeVendida;
        double valorComissao = totalVendido * (percentualComissao / 100);
        double totalReceber = salarioFixo + valorComissao;

        Console.WriteLine($"Total vendido: R$ {totalVendido:F2}");
        Console.WriteLine($"Valor da comissão: R$ {valorComissao:F2}");
        Console.WriteLine($"Total a receber: R$ {totalReceber:F2}");
    }
}