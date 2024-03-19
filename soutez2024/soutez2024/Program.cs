using System.Drawing;

namespace soutez2024
{
    class Program
    {
        public static void Main(string[] args)
        {
            //zetony();
            //jednicka dvojka a rozdil
            
            mozaika();
            //pouze jednicka

            //domecky();
            //pouze jednicka
        }

        public static void mozaika()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vyber si typ vstupu: ");
                Console.WriteLine("1) Podle počtu řad v mozaice");
                Console.WriteLine("2) Podle počtu bílých čtverců");
                Console.WriteLine("3) Podle počtu čtverců celkem");
                //nechame si uzivatele vybrat moznost
                int vyber = Convert.ToInt32(Console.ReadLine());
                if (vyber == 1)
                {
                    //hotovo
                    //clear na lepsi cteni
                    Console.Clear();
                    Console.Write("Zadej počet řad v mozaice: ");
                    int pocetRad = Convert.ToInt32(Console.ReadLine());
                    //podle zadani
                    int pocetSloupcu = pocetRad + 1;

                    int pocetBilychCtvercu = 0;

                    //i je kazda rada
                    for (int i = 0; i < pocetRad; i++)
                    {
                        //j je kazdej sloupec v rade
                        for (int j = 0; j < pocetSloupcu; j++)
                        {
                            if (i == 0 || j == 0 || i == pocetRad - 1 || j == pocetSloupcu - 1)
                            {
                                Console.Write("0");
                                pocetBilychCtvercu += 1;
                            }
                            else Console.Write("1");
                        }
                        Console.WriteLine();
                    }

                    //kdyz vime pocet bilych ctvercu a vsech ctvercu muzeme si lehce vypocitat zbytek
                    int pocetSedychCtvercu = (pocetRad * pocetSloupcu) - pocetBilychCtvercu;

                    Console.WriteLine(string.Format("Počet bílych ctverecku: {0}", pocetBilychCtvercu));
                    Console.WriteLine(string.Format("Počet šedých ctverecku: {0}", pocetSedychCtvercu));
                    Console.ReadKey();
                }
                if (vyber == 2)
                {
                    //nevim bro
                    Console.Clear();
                    Console.Write("Zadej počet bílých čtverců (min. 10): ");
                    int pocetBilychCtvercu = Convert.ToInt32(Console.ReadLine());



                    Console.WriteLine(string.Format("Počet bílych sloupců: {0}", pocetBilychCtvercu));
                    //Console.WriteLine(string.Format("Počet šedých sloupců: {0}", radku*sloupcu));
                    Console.ReadKey();
                }
                if (vyber == 3)
                {
                    //nevim broo
                    Console.Clear();
                    Console.Write("Zadej počet čtverců celkem (min. 12): ");
                    Console.Write("\n moc tezke :(");
                    Console.ReadKey();
                }
            }
        }

        //hotovo
        public static void zetony()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Vyber si typ vstupu: ");
                Console.WriteLine("1) Podle počtu žetonů ve středu desky");
                Console.WriteLine("2) Podle rozměru desky");
                Console.WriteLine("3) vypočítat rozdíl mezi počtem žetonů dvou desek s jinýmy rozměry");

                int vyber = Convert.ToInt32(Console.ReadLine());

                if (vyber == 1)
                {
                    Console.Clear();
                    Console.Write("Zadej počet žetonů ve středu desky: ");
                    int pocetZetonuStred = Convert.ToInt32(Console.ReadLine());
                    // zjisteni pocet radku a sloupcu
                    // napr.
                    // pocet zetonu na stredu = 3
                    // 3 - 1 = 2 (jednicku si dáme pryc, liche cisla budou primo uprostred, sudy cislo nebude primo ve stredu)
                    // 2 * 2 = 4 (cisla jdou z obou stran proto nasobíme)
                    // 4 + 1 = 5 (vratime zpatky jednicku)
                    int vypocet = ((pocetZetonuStred - 1) * 2) + 1;
                    int pocetPolicek = 0;

                    for (int i = 0; i < vypocet; i++)
                    {
                        for (int j = 0; j < vypocet; j++)
                        {
                            Console.Write(string.Format("[{0}, {1}] ", i, j));
                            pocetPolicek += 1;
                        }
                        Console.WriteLine("");
                    }

                    Console.WriteLine(string.Format("Počet všech políček: {0}", pocetPolicek));
                    Console.WriteLine(string.Format("Počet všech políček v každé řadě: {0}", vypocet));

                    Console.ReadKey();
                }

                if(vyber == 2 )
                {
                    Console.Clear();
                    Console.Write("Zadej rozměr desky (např 3 = 3x3): ");
                    int rozmer = Convert.ToInt32(Console.ReadLine());
                    //at to nekam muzu ukladat
                    int pocetPolicekUrcityZeton = 0;
                    for(int i = 0; i < rozmer; i++)
                    {
                        for(int j = 0; j < rozmer; j++)
                        {
                            //je to debilní ale příklad to vyřeší
                            //mohl jsem to udělat dynamický ale tohle mi pro to zadaní příšlo jednoduší
                            if (i == 0 || j == 0 || j == rozmer-1 || i == rozmer-1)
                                Console.Write("1");
                            else
                                if (i == 1 || j == 1 || j == rozmer-2 || i == rozmer-2)
                                {
                                    Console.Write("2");
                                    pocetPolicekUrcityZeton += 1;
                                }
                                else
                                    Console.Write("0");
                        }
                        Console.WriteLine("");
                    }

                    Console.WriteLine(string.Format("Počet všech políček, na nichž leží právě 2 žetony: {0}", pocetPolicekUrcityZeton));
                    Console.ReadKey();
                }

                if(vyber==3)
                {
                    Console.Clear();
                    Console.Write("Zadej rozměr první desky (např 3 = 3x3): ");
                    int prvniRozmer = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nZadej rozměr druhé desky (např 3 = 3x3): ");
                    int druhyRozmer = Convert.ToInt32(Console.ReadLine());
                    int vypocet = 0;

                    //no tak do mínusu počítat nebudem že ne
                    if(prvniRozmer > druhyRozmer)
                        vypocet = prvniRozmer * prvniRozmer - druhyRozmer * druhyRozmer;
                    else
                        vypocet = druhyRozmer * druhyRozmer - prvniRozmer * prvniRozmer;

                    Console.WriteLine(string.Format("Počet žetonů na první desce ({0}x{0}): {1}", prvniRozmer, prvniRozmer*prvniRozmer));
                    Console.WriteLine(string.Format("Počet žetonů na druhé desce ({0}x{0}): {1}", druhyRozmer, druhyRozmer*druhyRozmer));
                    Console.WriteLine(string.Format("Rozdíl: {0}", vypocet));
                    Console.ReadKey();
                }

            }
        }

        public static void domecky()
        {
            while(true)
            {
                Console.Clear();

                Console.WriteLine("Vyber si typ vstupu: ");
                Console.WriteLine("1) Podle počtu domů");
                Console.WriteLine("2) Podle počtu krizovatek");
                Console.WriteLine("3) Podle počtu ulic");
                int vyber = Convert.ToInt32(Console.ReadLine());

                if(vyber ==1)
                {
                    Console.Clear();
                    Console.WriteLine("Zadej počet domů: ");
                    int pocetDomu = Convert.ToInt32(Console.ReadLine());
                    int pocetUlic = 0;
                    int pocetKrizovatek = 0;
                    for(int i = 1; i <= pocetDomu; i++)
                    {
                        //pokud je cislo domu delitelny dvema tak ma ulici
                        if(i % 2 == 0)
                        {
                            pocetUlic+=1;
                        }
                        //no a pokud jsou 2 ulice tak je jedna krizovatka
                        // 0 % 2 == 0 proto ta podmínka jeste
                        if(pocetUlic % 2 == 0 && pocetUlic != 0)
                        {
                            pocetKrizovatek += 1;
                        }
                    }

                    Console.WriteLine("pocet domu: " + pocetDomu);
                    Console.WriteLine("pocet ulic: " + pocetUlic);
                    Console.WriteLine("pocet krizovatek: " + pocetKrizovatek);
                    Console.ReadKey();
                }

                if (vyber == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Zadej počet křižovatek: ");
                    int pocetKrizovatek = Convert.ToInt32(Console.ReadLine());
                    int pocetUlic = 0;
                    int pocetDomu = 0;

                    Console.WriteLine("pocet domu: " + pocetDomu);
                    Console.WriteLine("pocet ulic: " + pocetUlic);
                    Console.WriteLine("pocet krizovatek: " + pocetKrizovatek);
                    Console.ReadKey();
                }

                if (vyber == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Zadej počet ulic: ");
                    int pocetUlic = Convert.ToInt32(Console.ReadLine());
                    int pocetKrizovatek = 0;
                    int pocetDomu = pocetUlic*2;

                    Console.WriteLine("pocet domu: " + pocetDomu);
                    Console.WriteLine("pocet ulic: " + pocetUlic);
                    Console.WriteLine("pocet krizovatek: " + pocetKrizovatek);
                    Console.ReadKey();
                }
            }
        }
    }
}