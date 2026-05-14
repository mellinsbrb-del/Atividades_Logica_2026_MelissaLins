
Console.WriteLine(" Calculadora de IMC ");
Console.Write("Digite seu peso: ");
string inputPeso = Console.ReadLine().Replace(",", "."); 
float.TryParse(inputPeso, out float peso);

Console.Write("Digite sua altura (ex: 1.75): ");
string inputAltura = Console.ReadLine().Replace(",", "."); 
float.TryParse(inputAltura, out float altura);

if (altura > 0)
{
    float imc = peso / (altura * altura);

    Console.WriteLine($ "Seu IMC é: {imc:F2}");

    else if (imc < 18.5) Console.WriteLine("Classificação: Abaixo do peso");
    else if (imc < 25.0) Console.WriteLine("Classificação: Peso normal");
    else if (imc < 29.9) Console.WriteLine("Classificação: Acima do peso");
    else if (imc > 40.0) Console.WriteLine("Classificação: Obesidade");
}
