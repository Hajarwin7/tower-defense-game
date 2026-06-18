using System;
using System.Collections.Generic;
using TowerDefense.Core.Abstract;
using TowerDefense.Core.Entities;
using TowerDefense.Core.Interfaces;

namespace TowerDefense.Core.Towers
{
    // area damage 
    public class TopKulesi : Kule, ISaldirabilir, IYukseltilebilir
    {
        public TopKulesi()
        {
            Damage = 50;
            Range = 120;
            FireRate = 3000; // 3s
            Cost = 250;
        }

        // area attack damages all enemies in range
        public override void Saldir(List<Dusman> dusmanlar)
        {
            if (!AtesEdebilirMi()) return;

            bool vurdu = false;

            foreach (var d in dusmanlar)
            {
                if (d.IsDead) continue;

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



        // upgrade method
        public void Yukselt()
        {
            Damage += 10;
            Range += 5;
        }
    }
}
