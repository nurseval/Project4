using System;

namespace hatayonetimi
{
    class Program
    {

        static void Main(string[]args)
        {
            try
           {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı"+ sayi);
            }

            catch(Exception ex)

           {
                Console.WriteLine("Hata:"+ ex.Message.ToString());
            }

            finally
           {
                Console.Write("İşlem tamamlandı.");
            }
            Console.ReadKey();
             
             /* try
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
                }*/



        }  
    
    }
}
    

