using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unlocked_pc_prank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("PC is unlocked? We have a job for you Mr. Powers!");

            System.Console.WriteLine("Deploying Special Agent Austin Powers...");
            Wallpaper.Set(Resources.dangerously, Wallpaper.Style.Stretched);

            System.Console.WriteLine("Austin was delivered - Mission succesful\n");
            System.Console.WriteLine("Press any key to exit and leave the scene quietly...");

            System.Console.ReadLine();
        }
    }
}
