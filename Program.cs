using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //variable = 1 piece of data
    //array = multiple variables(elements) of the same type of data
    //struct = multiple of(potentially various) types of data (IE: vectors, ...)
    //class = data + code relating to the same object (IE: player, enemy)
    class Program
    {
        struct Vector2
        {
            public float x;
            public float y;
        }
        struct Vector3
        {
            public float x;
            public float y;
            public float z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Structs:");
            Console.WriteLine("");
            //purpose
            //reading in gamepad input(left thumbstick(x,y))
            //moving 3d game obect - (x,y,z)
            // (hidden lesson on vectors)(linear algebra)
            //problem:
            //how do you "map" (x,y) to (x,y,z)
            Console.WriteLine("Before Structs");
            Console.WriteLine("");
            //gamepad (2D)
            float gamepadMovementX; //could be anything -1.0 ... 1.0 (left/right)
            float gamepadMovementY; //could be anything -1.0 ... 1.0 (up/down)
            //sample gameplay for gamepad
            gamepadMovementX = 0.0f; // would be read by method from gamepad
            gamepadMovementY = 0.0f; // would be read by method from gamepad
            //playermovement (3D)
            float playerMovementX; // (left/right)
            float playerMovementY; // (up/down)
            float playerMovementZ; // (forwards/backwards)
            //sample gameplay for playermovement
            playerMovementX = gamepadMovementX;
            playerMovementY = 0.0f;
            playerMovementZ = gamepadMovementY;
            Console.WriteLine("");
            Console.WriteLine(" After Structs");
            Console.WriteLine("");
            //gamepad(2d)
            Vector2 gamepad;
            //player movement(3d)
            Vector3 playerMovement;
            //sample gameplay
            gamepad = ReadGamepadInput();
            playerMovement.x = gamepad.x;
            playerMovement.y = 0.0f;
            playerMovement.z = gamepad.y;
            MovePlayer(playerMovement);
            Console.ReadKey(true);
        }
        static Vector2 ReadGamepadInput()
        {
            Vector2 output;
            output.x = 0.0f; //reading gamepad input
            output.y = 0.0f; //reading gamepad input
            return output;
        }
        static void MovePlayer(Vector3 movement)
        {
            //...
        }
    }
}
