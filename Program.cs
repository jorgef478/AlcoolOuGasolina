string opcao;
 
Console.Clear();
Console.WriteLine("Seja bem vindo!");
Console.WriteLine("Digite o valor dos combustíveis abaixo para saber qual melhor escolha para você, Etanol ou Gasolina.");
Console.WriteLine();
 
Console.Write("Digite o preço da gasolina (R$).: ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o preço do etanol (R$)...: ");
decimal etanol = Convert.ToDecimal(Console.ReadLine());
 
if (AbastecerGasolina(etanol, gasolina))
{
    opcao = "Gasolina";
    }
else
{
    opcao = "Etanol";
}
 
double razao = GasolinaEtanol(etanol, gasolina) * 100;
Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Abasteça com {opcao.ToUpper()}!.");
 
double GasolinaEtanol(decimal precoEtanol, decimal precoGasolina)
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}
bool AbastecerGasolina(decimal precoEtanol, decimal precoGasolina)
{
    const double RazaoGasolina = 0.73;
    return GasolinaEtanol(precoEtanol, precoGasolina) >= RazaoGasolina;
}
 
 