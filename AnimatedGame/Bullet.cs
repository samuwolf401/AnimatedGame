using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AnimatedGame
{
    class Bullet
    {
        public int speed, x, y, size, dir;
        public SolidBrush brushColor = new SolidBrush(Color.DarkRed);

        public Bullet(int _speed, int _x, int _y, int _size, int _dir, SolidBrush _brushColor)
        {
            speed = _speed;
            x = _x;
            y = _y;
            size = _size;
            dir = _dir;
            brushColor = _brushColor;
        }

        public void Move()
        {
            //1 is left, 2 is up, 3 is right, 4 is down, 5 is top right, 6 is top left, 7 is bottom left, 8 is bottom right
            //moving in 8 directions
            if (dir == 1)
            {
                x += speed;
            }
            if(dir == 2)
            {
                y -= speed;
            }
            if (dir == 3)
            {
                x -= speed;
            }
            if (dir == 4)
            {
                y += speed;
            }
            if (dir == 5) //using pythegreom theroem to calculate how far to move on angles 
            {
                x += speed - 4;
                y -= speed - 4;
                
            }
            if (dir == 6)
            {
                x -= speed - 4;
                y -= speed - 4;
                
            }
            if (dir == 7)
            {
                x -= speed - 4;
                y += speed - 4;
                
            }
            if (dir == 8)
            {
                x += speed - 4;
                y += speed - 4;
                
            }

        }

    }
}
