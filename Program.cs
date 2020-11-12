using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a primeira nota: ");
            double nota1= double.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota: ");
            double nota2= double.Parse(Console.ReadLine());

            double media= (nota1 + nota2) / 2;
            string situaçao= "";

            if(media >7){
                situaçao= "aprovado";
            }
            else{
                situaçao= "reprovado";
            }
            Console.WriteLine(situaçao);
        }
    }
}
