using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        /// What You Can Write Inside The Struct Or Class
        ///1. Attributes[Fields] => Member Variable
        #region Attributes
        public int X;
        public int Y;
        #endregion

        ///2. Functions[Constructor, Getter Setter, Method]

        /// Constructor Special Function
        ///1.Name Constructor Same Name Class or Struct
        ///2.no return

        //0 references
        #region Constructors
        public Point()
        {
            X = default;
            Y = default;
        }

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        #endregion

        public override string ToString()
        {
            return $"[{X},{Y}]";
        }

    }
}
