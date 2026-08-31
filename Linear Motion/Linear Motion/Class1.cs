using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Motion
{
    internal class Vector3D
    {
        #region Private Variables

        float x;
        float y;
        float z;

        float w = 1;

        #endregion

        #region Constructors

        public Vector3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3D(Vector3D v)
        {

        }

        public Vector3D(float a, float b)
        {
            x = a;
            y = b;
            z = 0;
        }

        public Vector3D(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }
        #endregion

        #region Setters
        public void SetRectGivenRect(float a, float b)
        {
            x = a;
            y = b;
            z = 0;
        }

        public void SetRectGivenRect(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }
        #endregion

        #region Printers
        public string PrintRect()
        {
            return ($"<{x}, {y}, {z}>");
        }

        public string PrintMag()
        {
            return $"{GetMag()}";
        }

        #endregion

        #region Getters
        public float GetMag()
        {

            return MathF.Sqrt((x * x) + (y * y) + (z * z));
        }

        public float GetMagSq()
        {
            return (x * x) + (y * y) + (z * z);
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public float getZ() { return z; }
        #endregion

        #region
        public static Vector3D operator +(Vector3D first, Vector3D second)
        {
            Vector3D sum = new Vector3D();

            sum.SetRectGivenRect(first.getX() + second.getX(),
                first.getY() + second.getY(), first.getZ() + second.getZ());
            return sum;
        }

        public static Vector3D operator -(Vector3D first, Vector3D second)
        {
            Vector3D difference = new Vector3D();

            difference.SetRectGivenRect(first.getX() - second.getX(),
                first.getY() + second.getY(), first.getZ() + second.getZ());
            return difference;
        }

        public static Vector3D operator *(Vector3D vec, float scalar)
        {
            Vector3D quantity = new Vector3D();

            quantity.SetRectGivenRect(vec.getX() * scalar,
                vec.getY() * scalar, vec.getZ() * scalar);
            return quantity;
        }

        public static Vector3D operator *(float scalar, Vector3D vec)
        {
            Vector3D quantity = new Vector3D();

            quantity.SetRectGivenRect(vec.getX() * scalar,
                vec.getY() * scalar, vec.getZ() * scalar);
            return quantity;
        }

        public static Vector3D operator ~(Vector3D vec)
        {
            Vector3D normal = new Vector3D();

            if (vec.x == 0 && vec.y == 0 && vec.z == 0)
            {
                normal.SetRectGivenRect(0, 0, 0);
            }
            else
            {
                normal.SetRectGivenRect(vec.getX() / vec.GetMag(),
                    vec.getY() / vec.GetMag(), vec.getZ() / vec.GetMag());
            }
            return normal;
        }
        #endregion
    }
}

