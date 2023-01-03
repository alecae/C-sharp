using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    public interface IVolant
    {
        public void Voler ()
        {
            return $"Je suis entrain de voler!";
        }
    }
}
