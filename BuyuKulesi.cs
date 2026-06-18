using System;
using System.Collections.Generic;
using System.Linq;
using TowerDefense.Core.Abstract;
using TowerDefense.Core.Entities;
using TowerDefense.Core.Interfaces;

namespace TowerDefense.Core.Towers
{
    // damages limited number 
    public class BuyuKulesi : Kule, ISaldirabilir
    {
        public BuyuKulesi()
        {
            Damage = 25;
            Range = 130;
            FireRate = 1500; // 1.5s
            Cost = 200;
        }

        // attacks up to 5 closest enemies within range 
        public override void Saldir(List<Dusman> dusmanlar)
        {
            if (!AtesEdebilirMi()) return;

            var hedefler = dusmanlar
                .Where(d => !d.IsDead)
                .OrderBy(d => Mesafe(this.Konum, d.Konum))
                .Take(5);

            bool vurdu = false;

            foreach (var d in hedefler)
            {
                if (Mesafe(this.Konum, d.Konum) <= Range)
                {
                    d.Health -= Damage;
                    vurdu = true;
                    d.IsHit = true;
                    d.HitTime = DateTime.Now;
                }
            }

            if (vurdu)
                SonAtesZamani = DateTime.Now;
        }

    }
}