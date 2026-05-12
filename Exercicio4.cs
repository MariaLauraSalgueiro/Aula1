/*## 04 - Bug na troca de valores entre variáveis

Seu **professor de Lógica de Programação** identificou um problema em um módulo do sistema usado nas aulas: a rotina que **troca os valores entre duas variáveis** não está funcionando corretamente. Sua tarefa é corrigir a lógica para que, ao final, o valor de  **x**  passe para  **y**  e o valor de  **y**  passe para  **x** 

### Tarefa

Desenvolva um programa em C# que:

1. Crie as variáveis `x` e `y` com os valores recebendo valores via teclado.
2. Faça a **troca dos valores**, de modo que:
    - `x` passe a valer `y`
    - `y` passe a valer `x`
3. Exiba no console o valor de `x` e `y` **antes** e **depois** da troca.

✅ **Regras**

- A troca deve ser feita usando **apenas variáveis e atribuições***/
public static class Exercicio4
{
    public static void Executar()
    {
        double x = 0;
        double y = 0;

        Console.Write("Digite o valor de x: ");
        x = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o valor de y: ");
        y = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"\nAntes da troca: x = {x}, y = {y}");

        // Variável temporária para realizar a troca
        double temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"Depois da troca: x = {x}, y = {y}");
    }
}