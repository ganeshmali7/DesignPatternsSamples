using System;
using DesignPatternsSamples.KISSAndDRY;
using DesignPatternsSamples.OOD;
using DesignPatternsSamples.SOLID;

namespace DesignPatternsSamples
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Simple Demos: DRY, KISS, OOD & SOLID ===");
                Console.WriteLine();
                Console.WriteLine("DRY examples:");
                Console.WriteLine("  1) DRY_Violated (repeating work)");
                Console.WriteLine("  2) DRY_Followed  (single helper)");
                Console.WriteLine("  3) DRY_Both (violated then followed)");
                Console.WriteLine();
                Console.WriteLine("KISS examples:");
                Console.WriteLine("  4) KISS_Violated (over-engineered)");
                Console.WriteLine("  5) KISS_Followed (simple & clear)");
                Console.WriteLine("  6) KISS_Both (violated then followed)");
                Console.WriteLine();
                Console.WriteLine("OOD (Object Oriented Design) examples:");
                Console.WriteLine("  7) Encapsulation");
                Console.WriteLine("  8) Inheritance");
                Console.WriteLine("  9) Polymorphism");
                Console.WriteLine();
                Console.WriteLine("SOLID examples (violated / followed):");
                Console.WriteLine(" 10) SRP (violated)");
                Console.WriteLine(" 11) SRP (followed)");
                Console.WriteLine(" 12) OCP (violated)");
                Console.WriteLine(" 13) OCP (followed)");
                Console.WriteLine(" 14) LSP (violated)");
                Console.WriteLine(" 15) LSP (followed)");
                Console.WriteLine(" 16) ISP (violated)");
                Console.WriteLine(" 17) ISP (followed)");
                Console.WriteLine(" 18) DIP (violated)");
                Console.WriteLine(" 19) DIP (followed)");
                Console.WriteLine();
                Console.WriteLine("  0) Exit");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                Console.WriteLine();
                switch (choice)
                {
                    // DRY
                    case "1": KISSAndDRY.DRY_Violated.Run(); 
                              break;
                    case "2": KISSAndDRY.DRY_Followed.Run(); 
                              break;
                    case "3":
                              KISSAndDRY.DRY_Violated.Run();
                              Console.WriteLine();
                              KISSAndDRY.DRY_Followed.Run();
                              break;

                    // KISS
                    case "4": KISSAndDRY.KISS_Violated.Run(); 
                              break;
                    case "5": KISSAndDRY.KISS_Followed.Run(); 
                              break;
                    case "6":
                              KISSAndDRY.KISS_Violated.Run();
                              Console.WriteLine();
                              KISSAndDRY.KISS_Followed.Run();
                              break;

                    // OOD
                    case "7": EncapsulationExample.Run(); 
                              break;
                    case "8": InheritanceExample.Run(); 
                              break;
                    case "9": PolymorphismExample.Run(); 
                              break;

                    // SOLID
                    case "10": SRP_Violated.Run(); 
                               break;
                    case "11": SRP_Followed.Run(); 
                               break;
                    case "12": OCP_Violated.Run(); 
                               break;
                    case "13": OCP_Followed.Run();
                               break;
                    case "14": LSP_Violated.Run(); 
                               break;
                    case "15": LSP_Followed.Run(); 
                               break;
                    case "16": ISP_Violated.Run(); 
                               break;
                    case "17": ISP_Followed.Run(); 
                               break;
                    case "18": DIP_Violated.Run();
                               break;
                    case "19": DIP_Followed.Run(); 
                               break;

                    case "0": return;
                    default:
                        Console.WriteLine("Please enter a valid number (0-19).");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
