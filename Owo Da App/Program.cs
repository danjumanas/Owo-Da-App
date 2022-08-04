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

            for (int count = 1; count < 3; count++)
            {
                Console.WriteLine("Enter type of Vehicle\nTricycle\nMotorcycle\nMinibus\nBus");
                string vehicleType = Console.ReadLine();
                vehicleType = vehicleType.ToLower();



                switch (vehicleType)
                {
                    case "tricycle":
                        fee = 100;
                        break;

                    case "motorcycle":
                        fee = 50;
                        break;

                    case "minibus":
                        fee = 200;
                        break;

                    case "bus":
                        fee = 300;
                        break;

                    default:
                        fee = 100;
                        break;

                }


                Console.WriteLine("You a member? Input\ntrue or\nfalse");
                string member = (Console.ReadLine());
                member = member.ToLower();

                if (member == "true")
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
