using static System.Console;
int a, b;
WriteLine("Digite o 1º valor:");
a = Convert.ToInt16(ReadLine());
WriteLine("Digite o 2º valor");
b = Convert.ToInt16(ReadLine());
int soma = a + b;
if(soma >= 100)
{   
    WriteLine("A soma foi maior que 100, o valor foi: "+soma);
}
else
{
    WriteLine("A soma foi menor que 100, o valor foi: "+ soma);
}