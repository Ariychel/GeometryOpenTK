using Geometry.Structures;
using OpenTK;
using System;
using System.Drawing;
using Visualizer.Debug;
using Visualizer.OpenGLViews;

namespace Visualizer
{
    public static class LabSolver
    {
        //Use method Camera.SetCamera for controlling camera's parameters
        public static void SetCamera()
        {
            Camera.SetCamera(new Point3f(0, 0, 30), new Point3f(0, 0, 0));
        }

        public static void ResultRendering()
        {
            //Use Visualizer.Debug.GeometryDisplay class for rendering geometry

            Vector2d vector = new Vector2d(2, 2);
            //Вектор без зміг
            GeometryDisplay.Vector(new Vector3d(vector.X, vector.Y, 0), 2, Color.White);

            double[,] yMatrix = {
                { -1, 0 },
                { 0, 1}
            };

            Vector2d yInvert = MultiplyByMatrix(vector, yMatrix);

            //Вектор відбитий відносно осі Y 
            GeometryDisplay.Vector(new Vector3d(yInvert.X, yInvert.Y, 0), 2, Color.Gold);

            double[,] inverseMatrix = {
                { -1, 0 },
                { 0, -1 }
            };

            Vector2d inversedVector = MultiplyByMatrix(yInvert, inverseMatrix);

            //Інвертований вектор
            GeometryDisplay.Vector(new Vector3d(inversedVector.X, inversedVector.Y, 0), 2, Color.Pink);


            double angle = 15;
            double[,] MP = {
                { Math.Cos(angle * Math.PI / 180), -Math.Sin(angle * Math.PI / 180)},
                { Math.Sin(angle * Math.PI / 180), Math.Cos(angle * Math.PI / 180) }
            };

            Vector2d rotatedVector = MultiplyByMatrix(inversedVector, MP);

            //Обернений вектор
            GeometryDisplay.Vector(new Vector3d(rotatedVector.X, rotatedVector.Y, 0), 2, Color.Cyan);
        }

        private static Vector2d MultiplyByMatrix(Vector2d vector, double[,] matrix)
        {
            if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
                throw new Exception("Wrong size of matrix");

            return new Vector2d(
                matrix[0, 0] * vector.X + matrix[1, 0] * vector.Y,
                matrix[0, 1] * vector.X + matrix[1, 1] * vector.Y);
        }
    }
}
