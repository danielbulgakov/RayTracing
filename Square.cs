using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Object
{
    internal class Square
    {
        private List<float> VerticesList = new List<float>();
        private List<uint> Indices = new List<uint>();
        private Color Color;

        public Square(float[] Vertecies, Color Color)
        {
            foreach (var item in Vertecies)
            {
                VerticesList.Add(item);
            }
            this.Color = Color;
            this.CalculateIndices();
        }

        private void CalculateIndices()
        {
            Indices.Add(0);
            Indices.Add(1);
            Indices.Add(2);
            Indices.Add(2);
            Indices.Add(3);
            Indices.Add(0);
        }

        public float[] GetAll(bool isNormals = true, bool isTexCoords = true)
        {
            List<float> result = new List<float>();

            for (int i = 0; i < VerticesList.Count / 3; ++i)
            {
                result.Add(VerticesList[i * 3]);
                result.Add(VerticesList[i * 3 + 1]);
                result.Add(VerticesList[i * 3 + 2]);

            }


            return result.ToArray();
        }


        public uint[] GetIndices()
        {
            return Indices.ToArray();
        }
    }
}