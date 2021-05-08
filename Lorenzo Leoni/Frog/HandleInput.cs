using System;
using System.Collections.Generic;
using System.Text;

namespace Frog
{
    public class HandleInput
    {
        public string Input(int i)
        {

            int caseSwitch = i;
            if (i>0 && i<5)
            {
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Stading");
                        return "Standing";
                  
                    case 2:
                        Console.WriteLine("Running left");
                        return "Running left";
                        
                    case 3:
                        Console.WriteLine("Running right");
                        return "Running right";
                        
                    case 4:
                        Console.WriteLine("Jumping");
                        return "Jumping";
                        
                       
                }
            }
            return "Command Error";
        }
        

        }
    }
