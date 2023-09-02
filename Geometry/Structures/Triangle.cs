using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Structures
{
    public class Triangle
    {
        public Point3f A { get; }

        public Point3f B { get; }

        public Point3f C { get; }

        public Vector3 Normal { get; }

        public Triangle(Point3f a, Point3f b, Point3f c, Vector3 normal)
        {
            A = a;
            B = b;
            C = c;
            Normal = Vector3.Normalize(normal);
        }

        public Triangle(Point3f a, Point3f b, Point3f c)
        {
            A = a;
            B = b;
            C = c;

            Vector3 aToB = new Vector3(b.X - a.X, b.Y - a.Y, b.Z - a.Z);
            Vector3 aToC = new Vector3(c.X - a.X, c.Y - a.Y, c.Z - a.Z);

            Normal = Vector3.Normalize(Vector3.Cross(aToB, aToC));
        }
    }
}
