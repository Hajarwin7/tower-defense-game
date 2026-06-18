using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Core.Entities;

namespace TowerDefense.Core.Interfaces
{
    // Interface for attack capability 
    public interface ISaldirabilir
    {
        // attack method for towers 
        void Saldir(List<Dusman> dusmanlar);
    }
}
