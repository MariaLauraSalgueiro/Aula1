/*## Exercício 03 — Bug no cálculo de consumo e custo da viagem (somente aritmética)

**RotaCerta Logística**, uma empresa que faz entregas entre cidades e precisa calcular rapidamente o custo de cada rota.

Nos últimos relatórios, o time financeiro percebeu divergências: algumas viagens estão sendo registradas 
com **litros e custo total incorretos**, o que afeta o planejamento de orçamento e o repasse para motoristas, 
você é o desenvolvedor da emrpesa e:

Você corrigir a rotina que calcula, a partir da **distância**, do **consumo do veículo (km/L)** e 
do **preço do combustível (R$/L)**

- Leia os dados **via teclado**.
- Exiba os resultados com **2 casas decimais**.

O sistema recebe dados básicos da rota e do veículo e deve calcular:

1. **Litros necessários** para o trajeto
2. **Custo total** do combustível
3. **Custo por km** da viagem
### Informações importantes

- O consumo do carro é informado em **km por litro (km/L)**
- A distância é informada em **km**
- O preço do combustível é informado em **R$/litro**
{
        Console.Write("Distância total da viagem (km): ");
        double distanciaKm = double.Parse(Console.ReadLine());

        Console.Write("Consumo do veículo (km/L): ");
        double consumoKmPorLitro = double.Parse(Console.ReadLine());

        Console.Write("Preço do combustível (R$/L): ");
        double precoLitro = double.Parse(Console.ReadLine());

        // Cálculos corretos
    

        Console.WriteLine("\n=== Resumo da Viagem ===");
        Console.WriteLine($"Litros necessários: {litrosNecessarios:F2} L");
        Console.WriteLine($"Custo total: R$ {custoTotal:F2}");
        Console.WriteLine($"Custo por km: R$ {custoPorKm:F2}");
    }*/

// -- Arquivo Exercicio3.cs
public static class Exercicio3
{
    public static void Executar()
    {
        double distanciaKm = 0;
        double consumoKmPorLitro = 0;
        double precoLitro = 0;

        Console.Write("Digite a distância total da viagem (km): ");
        distanciaKm = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o consumo do veículo (km/L): ");
        consumoKmPorLitro = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o preço do combustível (R$/L): ");
        precoLitro = double.Parse(Console.ReadLine()!);

        double litrosNecessarios = distanciaKm / consumoKmPorLitro;
        double custoTotal = litrosNecessarios * precoLitro;
        double custoPorKm = custoTotal / distanciaKm;

        Console.WriteLine("\n=== Resumo da Viagem ===");
        Console.WriteLine($"Litros necessários: {litrosNecessarios:F2} L");
        Console.WriteLine($"Custo total: R$ {custoTotal:F2}");
        Console.WriteLine($"Custo por km: R$ {custoPorKm:F2}");
    }
}
