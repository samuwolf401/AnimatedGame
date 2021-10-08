using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AnimatedGame
{
    class Tank
    {
        //variable set up
        public int speed, reaload, x, y, size, dir;
        public SolidBrush brushColor;

        public Tank(int _speed, int _reaload, int _x, int _y, int _size, SolidBrush _brushColor)
        {
            speed = _speed;
            reaload = _reaload;
            x = _x;
            y = _y;
            size = _size;
            brushColor = _brushColor;
        }

        public void Move(int _dir)
        {
            //1 is left, 2 is up, 3 is right, 4 is down, 5 is top right, 6 is top left, 7 is bottom left, 8 is bottom right
            //moving in 8 directions
            if (_dir == 1)
            {
                x += speed;
                dir = 1;
            }

            if (_dir == 2)
            {
                y -= speed;
                dir = 2;
            }
            if (_dir == 3)
            {
                x -= speed;
                dir = 3;
            }
            if (_dir == 4)
            {
                y += speed;
                dir = 4;
            }
            if (_dir == 5) //using pythegreom theroem to calculate how far to move on angles 
            {
                x += speed-1;
                y -= speed-1;
                dir = 5;
            }

            if (_dir == 6)
            {
                x -= speed - 1;
                y -= speed - 1;
                dir = 6;
            }
            if (_dir == 7)
            {
                x -= speed - 1;
                y += speed - 1;
                dir = 7;
            }
            if (_dir == 8)
            {
                x += speed - 1;
                y += speed - 1;
                dir = 8;
            }

        }

        public bool Collision(Bullet b, int _x, int _y, int _size)
        {
            //creating rectangles for collisions
            Rectangle playerRec = new Rectangle(_x, _y, _size, _size);

            Rectangle BulletRec = new Rectangle(b.x, b.y, b.size, b.size);

            //collision check between the rectangles
            if (playerRec.IntersectsWith(BulletRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
