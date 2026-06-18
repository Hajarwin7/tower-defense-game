using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using TowerDefense.Core.Entities;


namespace TowerDefense.Core.Abstract
{
    // Abstract base class for all tower types
    public abstract class Kule
    {
        // common tower properties 
        public int Damage { get; protected set; }    
        public int Range { get; protected set; }     
        public int FireRate { get; protected set; }  
        public int Cost { get; protected set; }

        public Point Konum { get; set; }  // tower position on the map

        protected double Mesafe(Point hedef) // distance helper 
        {
            int dx = hedef.X - Konum.X;
            int dy = hedef.Y - Konum.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        protected double Mesafe(Point a, Point b)  // iki nokta arasındaki mesafe
        {
            int dx = a.X - b.X;
            int dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Polymorphic attack behavior 
        public abstract void Saldir(List<Dusman> dusmanlar);

        protected DateTime SonAtesZamani = DateTime.MinValue;  // last attack time
        protected bool AtesEdebilirMi()  // ateş edebilir mi kontrol
        {
            return (DateTime.Now - SonAtesZamani).TotalMilliseconds >= FireRate;
        }

    }
}

