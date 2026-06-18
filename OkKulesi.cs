using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TowerDefense.Core.Abstract;
using TowerDefense.Core.Entities;
using TowerDefense.Core.Interfaces;

namespace TowerDefense.Core.Towers
{
    // tek hedefe saldırı
    public class OkKulesi : Kule, ISaldirabilir, IYukseltilebilir
    {
        public OkKulesi()
        {
            Damage = 15;
            Range = 150;
            FireRate = 1000; // 1s
            Cost = 100;
        }

        // single target attack en yakın düşman
        public override void Saldir(List<Dusman> dusmanlar)
        {
            if (!AtesEdebilirMi()) return;

            Dusman hedef = null;
            double enKisaMesafe = double.MaxValue;

            foreach (var d in dusmanlar)
            {
                if (d.IsDead) continue;

                double mesafe = Mesafe(this.Konum, d.Konum);

                if (mesafe <= Range && mesafe < enKisaMesafe)
                {
                    enKisaMesafe = mesafe;
                    hedef = d;
                }
            }

            if (hedef != null)
            {
                hedef.Health -= Damage;

                hedef.IsHit = true;
                hedef.HitTime = DateTime.Now;

                SonAtesZamani = DateTime.Now;
         

            }
        }



        // Upgrade method
        public void Yukselt()
        {
            Damage += 5;
            Range += 10;
        }

    }
}
