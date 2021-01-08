using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ5
{
    interface Entregable
    {
        public void Entregar();
        public void Devolver();
        public bool IsEntregado();
        public bool CompareTo(Object a);

    }
}
