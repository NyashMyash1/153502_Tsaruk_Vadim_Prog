using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Vector
    {
        public int[] values = new int[3];
        public Vector()
        {
            this.values[0] = 0;
            this.values[1] = 0;
            this.values[2] = 0;
        }
        public Vector(int a, int b, int c)
        {
            this.values[0] = a;
            this.values[1] = b;
            this.values[2] = c;
        }

        //private int a;

        //public int A
        //{
        //    get { return a; }
        //    set { a = value; }
        //}


        //private int b;

        //public int B
        //{
        //    get { return b; }
        //    set { b = value; }
        //}


        //private int c;

        //public int C
        //{
        //    get { return c; }
        //    set { c = value; }
        //}

        public static Vector operator +(Vector x, Vector y)
        {
            Vector z = new Vector();
            z.values[0] = x.values[0] + y.values[0];
            z.values[1] = x.values[1] + y.values[1];
            z.values[2] = x.values[2] + y.values[2];
            return z;
        }

        public static Vector operator -(Vector x, Vector y)
        {
            Vector z = new Vector();
            z.values[0] = x.values[0] - y.values[0];
            z.values[1] = x.values[1] - y.values[1];
            z.values[2] = x.values[2] - y.values[2];
            return z;
        }

        public static bool operator ==(Vector x, Vector y)
        {
            return x.values[0] == y.values[0] && x.values[1] == y.values[1] && x.values[2] == y.values[2];
        }

        public static bool operator !=(Vector x, Vector y)
        {
            return x.values[0] != y.values[0] || x.values[1] != y.values[1] || x.values[2] != y.values[2];
        }

        public static Vector operator ++(Vector x)
        {
            Vector newX = new Vector();
            newX.values[0] = x.values[0] + 1;
            newX.values[1] = x.values[1] + 1;
            newX.values[2] = x.values[2] + 1;
            return newX;
        }

        public static Vector operator --(Vector x)
        {
            Vector newX = new Vector();
            newX.values[0] = x.values[0] - 1;
            newX.values[1] = x.values[1] - 1;
            newX.values[2] = x.values[2] - 1;
            return newX;
        }

        public static Vector operator *(Vector x, Vector y)
        {
            Vector z = new Vector();
            z.values[0] = x.values[0] * y.values[0];
            z.values[1] = x.values[1] * y.values[1];
            z.values[2] = x.values[2] * y.values[2];
            return z;
        }

        public static Vector operator *(Vector x, int y)
        {
            Vector z = new Vector();
            z.values[0] = x.values[0] * y;
            z.values[1] = x.values[1] * y;
            z.values[2] = x.values[2] * y;
            return z;
        }

        public static Vector operator /(Vector x, int y)
        {
            Vector z = new Vector();
            z.values[0] = x.values[0] / y;
            z.values[1] = x.values[1] / y;
            z.values[2] = x.values[2] / y;
            return z;
        }

        public static bool operator true(Vector x)
        {
            return x.values[0] != 0 || x.values[1] != 0 || x.values[2] != 0;
        }

        public static bool operator false(Vector x)
        {
            return x.values[0] == 0 && x.values[1] == 0 && x.values[2] == 0;
        }

        public static explicit operator double(Vector x)
        {
            return Math.Sqrt(Math.Pow(x.values[0], 2) + Math.Pow(x.values[1], 2) + Math.Pow(x.values[2], 2));
        }

        public override string ToString()
        {
            return "a = " + values[0].ToString() + ", b = " + values[1].ToString() + ", c = " + values[2].ToString();
        }

        public int this[int index]
        {
            get => values[index];
            set => values[index] = value;
        }
    }
}
