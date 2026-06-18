using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TowerDefense.Core.Entities
{
    // enemy entity
    public class Dusman
    {
        public int Health { get; set; }
        public int Speed { get; set; }

        // current position
        public int X { get; set; }
        public int Y { get; set; }

        // which point on the path we are moving to
        public int HedefIndex { get; set; }

        public bool IsDead => Health <= 0;
        public bool Escaped { get; set; } = false;

        public bool IsHit { get; set; }
        public DateTime HitTime { get; set; }
        public bool IsDying { get; set; }
        public DateTime DeathTime { get; set; }


        public Point Konum => new Point(X, Y);

        public Dusman(int health, int speed, int startX, int startY)
        {
            Health = health;
            Speed = speed;
            X = startX;
            Y = startY;
            HedefIndex = 0;
        }
        public void HareketEt(Point hedef)
        {
            if (X < hedef.X) X += Speed;
            else if (X > hedef.X) X -= Speed;

            if (Y < hedef.Y) Y += Speed;
            else if (Y > hedef.Y) Y -= Speed;
        }
    }
}
