/*## Exercício 02 — Bug na conversão de temperatura
Você acabou de entrar como programador júnior na **ClimaTrack**, uma startup que exibe a temperatura em tempo real 
em painéis (dashboards) para eventos e empresas.
Nos últimos dias, vários usuários relataram que a temperatura em **Fahrenheit** está aparecendo errada 
quando o sensor envia o valor em **Celsius**. 
Seu **líder técnico** pediu para você corrigir a rotina de conversão, garantindo que o sistema aplique a 
fórmula correta e apresente o resultado com **2 casas decimais**.

✅ **Objetivo:** ler a temperatura em **Celsius (°C)** via teclado, converter para **Fahrenheit (°F)** e 
exibir o resultado.


{
    Console.Write("Informe a temperatura em Celsius (°C): ");
    double celsius = double.Parse(Console.ReadLine());

    // TODO: corrigir o cálculo abaixo (bug)
    double fahrenheit = 0;

    Console.WriteLine($"Temperatura em Fahrenheit (°F): {fahrenheit:F2}");
 }

*/

// -- Arquivo Exercicio2.cs
public static class Exercicio2
{
    public static void Executar()
    {
        double celsius = 0;

        Console.Write("Digite a temperatura em Celsius (°C): ");
        celsius = double.Parse(Console.ReadLine()!);

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Temperatura em Fahrenheit (°F): {fahrenheit:F2}");
    }
}