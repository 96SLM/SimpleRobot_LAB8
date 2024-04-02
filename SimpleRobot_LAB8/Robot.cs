using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot_LAB8
{
    //create a method to change cordinate lable to track robot
    //has to change bots location by 1 or 10
    //create a property to store robot direction
    //create a property to return robot's current position as a point structure
    //default direction should be north
    //create an event for if the user trys to move byond the edge

    internal class Robot
    {
        public bool IsNorth { get; set; }
        public bool IsSouth { get; set; }
        public bool IsWest { get; set; }
        public bool IsEast {  get; set; }
        public Point RobPoint { get; set; }

        public Robot(Point p)
        {
            RobPoint = p;
            IsNorth = true;
        }
       
        //move action method
        public void Move(int space)
        {
           
            if (IsNorth == true)
            {
                RobPoint = new Point(RobPoint.X, RobPoint.Y - space);
            }
            else if (IsSouth == true)
            {
                RobPoint = new Point(RobPoint.X, RobPoint.Y + space);
            }
            else if (IsWest == true)
            {
                RobPoint = new Point(RobPoint.X - space, RobPoint.Y);
            }
            else if(IsEast == true)
            {
                RobPoint = new Point(RobPoint.X + space, RobPoint.Y);
            }
                        
        }

        //declare event and delegate


    }
}
