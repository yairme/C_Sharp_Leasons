using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle_Class
{
    public class Retangle
    {
        private int x;
        private int y;
        private float width;
        private float height;

        //Constructs
        public Retangle(int x, int y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public Retangle(int x, int y, float size)
        {
            this.x = x;
            this.y = y;
            width = size;
            height = size;
        }
        public Retangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public Retangle(float size)
        {
            width = size;
            height = size;
        }

        
        //Fields
        public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }
        public float Width()
        {
            return width;
        }
        public float Height()
        {
            return height;
        }

        //Is Widght == Height
        public bool IsSquared()
        {
            if (height == width)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //Functions

        public void MoveTo(int x, int y)
        {
            return; 
        }

        public void Set(int x, int y, float width, float height)
        {
            this.width = width;
            this.height = height;
            MoveTo(x, y);
            IsSquared();
        }
    }
}
