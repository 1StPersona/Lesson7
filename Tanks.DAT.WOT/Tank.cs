using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.DAL.WOT
{
    public class Tank
    {

        static Random rand = new Random();
        private string Naming { get; set; }
        private int Ammo { get; set; }
        private int Armor { get; set; }
        private int Mobility { get; set; }

        public Tank() { }


        public Tank(string naming)
        {
            this.Naming = naming;
            this.Ammo = rand.Next(101);
            this.Armor = rand.Next(101);
            this.Mobility = rand.Next(102);
        }

        public string ReturnAmmo()
        {
            return this.Ammo.ToString();
        }
        public string ReturnArmor()
        {
            return this.Armor.ToString();
        }
        public string ReturnMobility()
        {
            return this.Mobility.ToString();
        }

        public static Tank operator *(Tank a, Tank b)
        {
            if (a.Ammo > b.Ammo && a.Armor > b.Armor ||
               a.Mobility > b.Mobility && a.Armor > b.Armor)
            {
                return a;
            }
            else return b;
        }

        public void getInfo()
        {
            Console.WriteLine("Name: {0}\nAmmo: {1}\nArmor: {2}\nMobility: {3}", this.Naming, this.Ammo, this.Armor, this.Mobility);
        }
        public string getNaming()
        {
            return this.Naming;
        }

    }
}