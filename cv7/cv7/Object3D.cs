using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    abstract internal class Object3D : ObjectGr
    {
        abstract public double calcSurface();
        abstract public double calcVolume();
    }
}
