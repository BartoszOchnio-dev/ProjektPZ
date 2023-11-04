using Gielda_biblioteka;
using Gielda_Biblioteka;
using System.Diagnostics;

namespace Gielda_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gielda gielda = new Gielda();

            
            InstrumentFinansowy akcja1 = new Akcja("A-1", "A1", "Firma A1", 5m);
            InstrumentFinansowy akcja2 = new Akcja("A-2", "A2", "Firma A2", 10m);
            InstrumentFinansowy akcja3 = new Akcja("A-3", "A3", "Firma A3", 15m);


            InstrumentFinansowy obligacja1 = new Obligacja("O-1", "O1", 4.4m, TypObligacjiEnum.Government, 12);
            InstrumentFinansowy obligacja2 = new Obligacja("O-2", "O2", 4.7m, TypObligacjiEnum.Corporate, 18);
            InstrumentFinansowy obligacja3 = new Obligacja("O-3", "O3", 5.4m, TypObligacjiEnum.Municipal, 36);

            InstrumentFinansowy surowiec1 = new Surowiec("złoto", "Z");
            InstrumentFinansowy surowiec2 = new Surowiec("drewno", "D");
            InstrumentFinansowy surowiec3 = new Surowiec("miedź", "M");

            InstrumentFinansowy waluta1 = new Waluta("euro", "EU", KrajEnum.Eurozone);
            InstrumentFinansowy waluta2 = new Waluta("funt brytyjski", "GBP", KrajEnum.UnitedKingdom);
            InstrumentFinansowy waluta3 = new Waluta("jaun", "CNY", KrajEnum.China);

            InstrumentFinansowy krypto1 = new Kryptowaluta("bitcoin", "BC", KrajEnum.All, BlockchainEnum.Bitcoin, new(2001, 2, 14));
            InstrumentFinansowy krypto2 = new Kryptowaluta("etherium", "ET", KrajEnum.All, BlockchainEnum.Etherium, new(2005, 5, 23));
            InstrumentFinansowy krypto3 = new Kryptowaluta("solana", "SO", KrajEnum.All, BlockchainEnum.Solana, new(2004, 7, 12));

            InstrumentInfo i1 = new InstrumentInfoLimitowanyDostep(akcja1, DateTime.Now, 1000, 1000, JednostkaMiaryEnum.sztuka, 50);
            InstrumentInfo i2 = new InstrumentInfoLimitowanyDostep(akcja2, DateTime.Now, 1000, 1000, JednostkaMiaryEnum.sztuka, 100);
            InstrumentInfo i3 = new InstrumentInfoLimitowanyDostep(akcja3, DateTime.Now, 1000, 1000, JednostkaMiaryEnum.sztuka, 150);
            InstrumentInfo i4 = new InstrumentInfoLimitowanyDostep(obligacja1, DateTime.Now, 100, 100, JednostkaMiaryEnum.sztuka, 750);
            InstrumentInfo i5 = new InstrumentInfoLimitowanyDostep(obligacja2, DateTime.Now, 100, 100, JednostkaMiaryEnum.sztuka,  1000);
            InstrumentInfo i6 = new InstrumentInfoLimitowanyDostep(obligacja3, DateTime.Now, 100, 100, JednostkaMiaryEnum.sztuka,  5000);
            InstrumentInfo i7 = new InstrumentInfoLimitowanyDostep(surowiec1, DateTime.Now, 100, 100, JednostkaMiaryEnum.uncja, 9423.23m);
            InstrumentInfo i8 = new InstrumentInfoLimitowanyDostep(surowiec2, DateTime.Now, 200, 200, JednostkaMiaryEnum.tona, 745.33m);
            InstrumentInfo i9 = new InstrumentInfoLimitowanyDostep(surowiec3, DateTime.Now, 300, 300, JednostkaMiaryEnum.kilogram, 54.55m);
            InstrumentInfo i10 = new InstrumentInfoNieLimitowanyDostep(waluta1, DateTime.Now, 1.2m);
            InstrumentInfo i11 = new InstrumentInfoNieLimitowanyDostep(waluta2, DateTime.Now, 1.35m);
            InstrumentInfo i12 = new InstrumentInfoNieLimitowanyDostep(waluta3, DateTime.Now, 0.14m);
            InstrumentInfo i13 = new InstrumentInfoNieLimitowanyDostep(krypto1, DateTime.Now, 43555.32m);
            InstrumentInfo i14 = new InstrumentInfoNieLimitowanyDostep(krypto2, DateTime.Now, 13542.22m);
            InstrumentInfo i15 = new InstrumentInfoNieLimitowanyDostep(krypto3, DateTime.Now, 5695.62m);


            gielda.addInstrument(i1);
            gielda.addInstrument(i2);
            gielda.addInstrument(i3);
            gielda.addInstrument(i4);
            gielda.addInstrument(i5);
            gielda.addInstrument(i6);
            gielda.addInstrument(i7);
            gielda.addInstrument(i8);
            gielda.addInstrument(i9);
            gielda.addInstrument(i10);
            gielda.addInstrument(i11);
            gielda.addInstrument(i12);
            gielda.addInstrument(i13);
            gielda.addInstrument(i14);
            gielda.addInstrument(i15);

            gielda.showAllInstruments();




            Uzytkownik portfel1 = new Portfel(1, "Bartosz", "Ochnio");
            Uzytkownik portfel2 = new Portfel(2, "Jan", "Szpontyl");
            Uzytkownik portfel3 = new Portfel(3, "Kamil", "Wazik");

            gielda.addUser(portfel1);
            gielda.addUser(portfel2);
            gielda.addUser(portfel3);

            gielda.showAllUsers();


            gielda.copyToInteface();


            gielda.copyToInteface();

            Console.WriteLine("---------------------------------");

            addTransaction(gielda, portfel1, akcja1);
            addTransaction(gielda, portfel1, waluta3);
            addTransaction(gielda, portfel1, obligacja2);
            addTransaction(gielda, portfel1, surowiec1);
            addTransaction(gielda, portfel1, krypto2);


            Console.WriteLine(portfel1.ToString());

        }

            

        public static void  addTransaction(Gielda gielda, Uzytkownik portfel, InstrumentFinansowy instrFinansowy)
        {
            InstrumentInfoLimitowanyDostep lim;
            InstrumentInfoNieLimitowanyDostep noLim;

            if (instrFinansowy is Interface1)
            {
                lim = gielda.findLimitedInsrumentByInstrument(instrFinansowy);
                InstrumentFinansowy instrumentFin = lim.Instrument;
                decimal price = lim.Price;

                InstrumentTransakcja t1 = new InstrumentTransakcja(instrumentFin, price, 20, DateTime.Now);
                ((Portfel)portfel).addTransaction(t1);
            }
            else if (instrFinansowy is Interface2)
            {
                noLim = gielda.findNoLimitedInsrumentByInstrument(instrFinansowy);
                InstrumentFinansowy instrumentFin = noLim.Instrument;
                decimal exchangeRateToUSD = noLim.ExchangeRateToUSD;
                USD usd = new USD();
                InstrumentTransakcja t1 = new InstrumentTransakcja(instrumentFin, exchangeRateToUSD * usd.Value, 20, DateTime.Now);
                ((Portfel)portfel).addTransaction(t1);
            }
        }
    }
}
