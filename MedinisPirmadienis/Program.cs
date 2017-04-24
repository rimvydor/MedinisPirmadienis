using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedinisPirmadieni
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite kuri dabar savaites diena yra,");
            Console.WriteLine("jei pirmadienis iveskite: pirmadienis,");
            Console.WriteLine("jei ne iveskite : kita");
            Console.WriteLine();

            var savaitesDiena = Console.ReadLine();
            while (true)
            {
                if (savaitesDiena == "pirmadienis" || savaitesDiena == "kita")
                {
                    break;
                }
                Console.WriteLine("Blogai ivedei");
                Console.WriteLine("Iveskite: pirmadienis arba kita");
                Console.WriteLine();
                savaitesDiena = Console.ReadLine();
            }

            switch (savaitesDiena)
            {
                case "pirmadienis":
                    Console.WriteLine("Ar tau sis pirmadienis yra blogas?");
                    Console.WriteLine("Ivesk: taip arba ne");
                    Console.WriteLine();
                    var busena = Console.ReadLine();
                    if (busena == "taip")
                    {
                        Console.WriteLine("Stai tau pasiseke tu gauni pirmadienio medini...");
                        Console.WriteLine();
                        Console.WriteLine("Vienas neturtingas kompiuteristas giriasi kitam:");
                        Console.WriteLine("- Vakar nauja projektoriu nusipirkau.");
                        Console.WriteLine("- Oho is kur pinigu gavai?");
                        Console.WriteLine("- Kompiuteri pardaviau");
                        Console.WriteLine();
                        Console.WriteLine("Kaip dabar, ar jau geresnis pirmadienis?");
                        Console.WriteLine("taip ar ne");
                        Console.WriteLine();
                        var busena1 = Console.ReadLine();
                        if (busena1 == "ne")
                        {
                            Console.WriteLine("Stai tau dar labiau pasiseke tu gauni dar viena pirmadienio medini...");
                            Console.WriteLine();
                            Console.WriteLine("Skundziasi dukra teciui:");
                            Console.WriteLine("-Mane klasiokai iki namu vijosi.");
                            Console.WriteLine("- Tai gal kibina? - klausia tetis.");
                            Console.WriteLine("- Ne jau valgiau");
                            Console.WriteLine();
                            Console.WriteLine("Kaip dabar, gal jau geresnis pirmadienis?");
                            Console.WriteLine("taip ar ne");
                            Console.WriteLine();
                            var busena2 = Console.ReadLine();
                            if (busena2 == "ne")
                            {
                                Console.WriteLine("Mes tau padeti negalime");
                                Console.WriteLine("Kreipkites i artimiausia psichologa");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Susitiksime kita pirmadieni...");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Susitiksime kita pirmadieni...");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Susitiksime kita pirmadieni...");
                        break;
                    }

                case "kita":
                    Console.WriteLine("Sekmes laukiant pirmadienio");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}

