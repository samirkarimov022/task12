using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(bulletCapacity: 30, fireRate: 5, reloadTime: 3, shootingMode: "tekli");

            while (true)
            {
                Console.WriteLine("\n0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqrami dayandırmaq üçün");

                Console.Write("Seçiminizi daxil edin: ");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine($"Daraqın boşalma saniyəsi: {weapon.ReloadTime}");
                        Console.WriteLine($"Daraqdakı güllə sayı: {weapon.GetRemainBulletCount()}");
                        Console.WriteLine($"Darağın güllə tutumu: {weapon.BulletCapacity}");
                        Console.WriteLine($"Atış modu: {weapon.ShootingMode}");
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine($"Daraqdakı güllə sayı: {weapon.GetRemainBulletCount()}");
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        Console.WriteLine("Atış modu dəyişdirildi.");
                        break;
                    case "6":
                     
                        return;
                    default:
                        Console.WriteLine("Düzgün seçim daxil edilməyib.");
                        break;
                }
            }
        }
    }
}
