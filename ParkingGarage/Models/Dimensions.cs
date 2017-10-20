using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage.Models
{
    class Dimensions
    {
        private int Width { get; set; }
        private int Length { get; set; }
        private int Height { get; set; }

        public Dimensions(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetLength()
        {
            return Length;
        }

        public int GetHeight()
        {
            return Height;
        }
    }
}
