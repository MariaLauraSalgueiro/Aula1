/*## Exercício 01 — Bug no cálculo do desconto (somente aritmética)

Você é programador júnior na **Loja TechMax**, um e-commerce que está com reclamações de clientes porque o sistema está exibindo **valores finais incorretos** no carrinho.

Seu líder técnico identificou que o erro está na rotina que calcula o total da compra com base em:

Sua missão é **corrigir o cálculo** para que o sistema mostre corretamente:

1. **Subtotal** (valor unitário × quantidade)
2. **Valor do desconto** (subtotal × percentual/100)
3. **Total a pagar** (subtotal − desconto)


    {
        Console.Write("Informe o valor do produto (R$): ");
        decimal valorProduto = decimal.Parse(Console.ReadLine());

        Console.Write("Informe a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Informe o desconto (%): ");
        decimal percentualDesconto = decimal.Parse(Console.ReadLine());

        // TODO: corrigir o cálculo abaixo (bug)
        decimal subtotal = 0;
        decimal valorDesconto = 0;
        decimal totalPagar = 0;

        // Exibir resultados
        // :F2 limita a 2 casas decimais depois do ponto
        Console.WriteLine($"Subtotal: R$ {subtotal:F2}"); 
        Console.WriteLine($"Desconto: R$ {valorDesconto:F2}");
        Console.WriteLine($"Total a pagar: R$ {totalPagar:F2}");
    }

*/

// -- Arquivo Exercicio1.cs
public static class Exercicio1
{
    public static void Executar()
    {
        double valorUnitario = 0;
        int quantidade = 0;
        double percentualDesconto = 0;

        Console.Write("Digite o valor unitário do produto: ");
        valorUnitario = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade do produto: ");
        quantidade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o percentual de desconto: ");
        percentualDesconto = double.Parse(Console.ReadLine()!);

        double subtotal = valorUnitario * quantidade;
        double valorDesconto = subtotal * (percentualDesconto / 100);
        double totalPagar = subtotal - valorDesconto;

        Console.WriteLine($"Subtotal: R$ {subtotal:F2}");
        Console.WriteLine($"Valor do desconto: R$ {valorDesconto:F2}");
        Console.WriteLine($"Total a pagar: R$ {totalPagar:F2}");
    }
}
