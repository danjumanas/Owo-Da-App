using System;

namespace Owo_Da_App
{
    internal class OwoDaApp
    {
        static void Main(string[] args)
        {
            
            var owoDa = new OwoDaApp();
            double finalCollection = owoDa.OwoDa();

        }

        public double OwoDa() 
        {
            double finalFee;
            double totalCollected = 0;
            double fee;

            for (int count = 1; count < 6; count++)
            {
                Console.WriteLine("Enter type of Vehicle\nTricycle\nMotorcycle\nMinibus\nBus");
                string vehicleType = Console.ReadLine();


                switch (vehicleType)
                {
                    case "Tricycle":
                        fee = 100;
                        break;

                    case "Motorcycle":
                        fee = 50;
                        break;

                    case "Minibus":
                        fee = 200;
                        break;

                    case "Bus":
                        fee = 300;
                        break;

                    default:
                        fee = 100;
                        break;

                }


                Console.WriteLine("You a member? Input\ntrue or\nfalse");
                bool member = bool.Parse(Console.ReadLine());

                if (member == true)
                {
                    fee = fee * 0.7;
                }
                else
                {
                    fee = fee;
                }

                

                Console.WriteLine("How many trips have you done?");
                int trips = int.Parse(Console.ReadLine());

                finalFee = fee * trips;
                Console.WriteLine("Your fee is " + finalFee + " naira after " + trips + "trips.");

                totalCollected += finalFee;

            }

            Console.WriteLine("Total Money Collected from 5 drivers is " + totalCollected + " naira.");

            return 0; 
        }
    }

    
}
