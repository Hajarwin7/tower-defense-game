using System;
using System.Collections.Generic;
using System.Drawing;
using TowerDefense.Core.Entities;


namespace TowerDefense.Core.Managers
{
    // manages core game state
    public class GameManager
    {
        public int Altin { get; private set; }
        public int Can { get; private set; }
        public int Skor { get; private set; }

        public int MevcutDalga { get; private set; }
        public int ToplamDalga { get; private set; }

        // active enemies in the game
        public List<Dusman> Dusmanlar { get; } = new List<Dusman>();

        // düşman yolu
        public Yol Yol { get; } = new Yol();


        public GameManager(int baslangicAltin, int baslangicCan, int toplamDalga)
        {
            Altin = baslangicAltin;
            Can = baslangicCan;
            Skor = 0;

            MevcutDalga = 1;
            ToplamDalga = toplamDalga;
        }

        // move to next dalga
        public void SonrakiDalga()
        {
            if (MevcutDalga < ToplamDalga)
                MevcutDalga++;
        }

        // economy operations add gold
        public void AltinEkle(int miktar) => Altin += miktar;

        public bool AltinHarca(int miktar) // spend gold if possible
        {
            if (Altin < miktar) return false;
            Altin -= miktar;
            return true;
        }

        // player takes damage
        public void HasarAl(int miktar)
        {
            Can -= miktar;
            if (Can < 0) Can = 0;
        }

        public void SkorEkle(int miktar) => Skor += miktar;

        // move all enemies along the path
        public void DusmanlariHareketEttir()
        {
            foreach (var d in Dusmanlar)
            {
                if (d.IsDead) continue;

                if (d.HedefIndex >= Yol.Noktalar.Count)
                    continue;

                Point hedef = Yol.Noktalar[d.HedefIndex];
                d.HareketEt(hedef);

                // check if enemy reached the target point
                if (Math.Abs(d.X - hedef.X) < 5 &&
                    Math.Abs(d.Y - hedef.Y) < 5)
                {
                    d.HedefIndex++;
                }
            }
        }

    }

}
