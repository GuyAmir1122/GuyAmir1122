using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class Apple
    {
        

        
        public Apple()
        {        
        }
        public void Draw(int xpos,int ypos) 
        {
            char ch = '█';
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i <= 2; i++)
            {
                Console.SetCursorPosition(xpos, ypos + i);
                Console.Write(new string(ch, 5));
            }
            Console.SetCursorPosition(xpos + 2, ypos - 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ch);
        }
        public void Erase(int xpos,int ypos)
        {
            char ch = '█';
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i <= 2; i++)
            {
                Console.SetCursorPosition(xpos, ypos + i);
                Console.Write(new string(ch, 5));
            }
            Console.SetCursorPosition(xpos + 2, ypos - 1);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(ch);
        }
        public void MoveDown(int xpos,int ypos ,int speed)
        {
            Draw(xpos,ypos);
            for (int i = 1; i < 2; i++)
            {
                Erase(xpos,ypos);
                ypos++;
                Draw(xpos,ypos);
                Thread.Sleep(speed);
            }
        }


    }
}
