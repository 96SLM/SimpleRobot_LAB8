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
        public int X {  get; set; }
        public int Y { get; set; }

       //public static string direction { get; set; }

        public Robot()
        {
            X = 90;
            Y = 90;
            //direction = "North";           
        }
    }
}
