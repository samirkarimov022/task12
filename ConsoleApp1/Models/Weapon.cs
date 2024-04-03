using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Weapon
    {
        private int bulletCapacity;
        private int bulletCount;
        private int fireRate;
        private int reloadTime;
        private string shootingMode;

        public int BulletCapacity
        {
            get { return bulletCapacity; }
            set { bulletCapacity = value; }
        }

        public int BulletCount
        {
            get { return bulletCount; }
            private set { bulletCount = value; }
        }

        public int FireRate
        {
            get { return fireRate; }
            set { fireRate = value; }
        }

        public int ReloadTime
        {
            get { return reloadTime; }
            set { reloadTime = value; }
        }

        public string ShootingMode
        {
            get { return shootingMode; }
            set { shootingMode = value; }
        }

        public Weapon(int bulletCapacity, int fireRate, int reloadTime, string shootingMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCapacity;
            FireRate = fireRate;
            ReloadTime = reloadTime;
            ShootingMode = shootingMode;
        }

        public void Shoot()
        {
            if (BulletCount > 0)
            {
                Console.WriteLine("Gülle atıldı.");
                BulletCount--;
            }
            else
            {
                Console.WriteLine("Daraqda gülle yoxdur.");
            }
        }

        public void Fire()
        {
            if (BulletCount > 0)
            {
                double timeToFinish = (double)BulletCount / FireRate;
                Console.WriteLine($"Təxmini {timeToFinish:F2} saniyədə bitəcək.");
                BulletCount = 0;
            }
            else
            {
                Console.WriteLine("Daraqda gülle yoxdur.");
            }
        }

        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletCount;
        }

        public void Reload()
        {
            Console.WriteLine("Daraq yenidən doldurulur...");
            BulletCount = BulletCapacity;
        }

        public void ChangeFireMode()
        {
            if (ShootingMode == "tekli")
            {
                ShootingMode = "avtomatik";
            }
            else
            {
                ShootingMode = "tekli";
            }
        }
    }
}
