using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FormatException = System.FormatException;

namespace Csharp7._0TryCatch
{
    class Program
    {
/*Uygulamalarımınz çalışma zamanında almış olduğu sistemsel hataları yönetmek  için c# prog dilinde
 * try catch yapılarını kullanırız.
 *
 * Try{
 *
 *
 * }
 * Catch(){
 *
 *
 * }
 */



        static void Main(string[] args)
        {



            try
            {

                int sayi1 = 101;

                if (sayi1 > 100)
                {
                    // limit aşımı hatası

                throw  new LimitAsimiHatasi();
                }
                else
                {
                    Console.WriteLine("Herhangi bir hata yoktur.");
                }

            }//Kendi yazdığım sınıf
            catch (LimitAsimiHatasi ex)
            {

                Console.WriteLine("Lİmit aşım hatası oldu. Kendi yazdığımız class ile yazdık.Exception dan kalıtım alarak hata sınıfı yazdık " +
                                  "kendimize göre yazabilirz hatalrı yakalayabiliriz.");


            }
            catch (FormatException f)
            {
//kişiselleştirilmiş Catch bloğudur.
                Console.WriteLine(f.Message);
                Console.WriteLine(f.Source);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }//Finalyy bloğu herzmana çalışır hata alınsada alınmada içine yazılan bütün kodlar  herazman çalışır.
            finally
            {

                Console.WriteLine("Benim Herzman çalışmam gerekiyo .");
            }

            Console.ReadLine();
        }
    }
}
