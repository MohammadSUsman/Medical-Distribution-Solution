using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrFingerXLib;
namespace Medcine_ManagmentSystem
{
    class TTemplate
    {
        // Template data.
        public Array _tpt;
        // Template size
        public int _size;

        public TTemplate()
        {
            // Create a byte buffer for the template
            _tpt = new byte[10000];
            _size = 0;
        }
    }
}
