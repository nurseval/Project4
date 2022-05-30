// See https://aka.ms/new-console-template for more information

try
{
    int a = int.Parse(Console.ReadLine());

    int b = int.Parse(Console.ReadLine());

    int c = a+b;

    Console.WriteLine(c);
}
catch(Exception ex)
{
    Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}