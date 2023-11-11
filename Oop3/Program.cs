using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            ILoggerService fileLoggerService = new FileLoggerService();

            List<IKrediManager> krediManagers = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new DatabaseLoggerService(),new SmsLoggerService()
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);
            basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);
            Console.ReadLine();
        }
    }
}
