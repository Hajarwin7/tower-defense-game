using System;
using System.Collections.Generic;
using System.Drawing;

namespace TowerDefense.Core.Entities
{
    // enemy path 
    public class Yol
    {
        public List<Point> Noktalar { get; } = new List<Point>();

        // creates a dynamic zigzag path based on panel size
        public void GuncelleYol(int panelGenislik, int panelYukseklik)
        {
            Noktalar.Clear();

            // basic layout values    
            int ortaY = panelYukseklik / 2;

            int solX = 0;
            int sagX = panelGenislik ;

            int birinciX = panelGenislik / 4;
            int ikinciX = panelGenislik / 2;
            int ucuncuX = (panelGenislik * 3) / 4;

            int ustY = ortaY - 80;
            int altY = ortaY + 80;

            //path noktaları 
            Noktalar.Add(new Point(solX, ortaY));      // start left-middle
            Noktalar.Add(new Point(birinciX, ortaY));  // go right
            Noktalar.Add(new Point(birinciX, ustY));   // go up
            Noktalar.Add(new Point(ikinciX, ustY));    // go right
            Noktalar.Add(new Point(ikinciX, altY));    // go down
            Noktalar.Add(new Point(ucuncuX, altY));    // go right
            Noktalar.Add(new Point(ucuncuX, ortaY));   // go up
            Noktalar.Add(new Point(sagX, ortaY));      // finish right edge
        }
    }
}
