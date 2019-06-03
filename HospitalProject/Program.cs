
using System;
using System.Collections.Generic;

namespace Hospital2
{
    public class Program
    {


        static void Main(string[] args)
        {

            List<Employee> listOfEmployees = new List<Employee>();
            Employee doctorOctopus = new Doctor("Doctor Octopus", 224, "Heart");
            Employee ratchet = new Nurse("Nurse Ratchet", 225, 15);
            Employee doctorDrey = new Doctor("Doctor Drey", 226, "Lung");
            Employee anonnurse = new Nurse("Nurse Anonymous", 227, 25);
            Employee farley = new Janitor("Farley", 228, true);
            Employee janet = new Receptionist("Janet Jones", 229, true);
            Patient testPatient = new Patient("Sickly Jones");

            Menu menu = new Menu();

            listOfEmployees.Add(doctorOctopus);
            listOfEmployees.Add(ratchet);
            listOfEmployees.Add(doctorDrey);
            listOfEmployees.Add(anonnurse);
            listOfEmployees.Add(farley);
            listOfEmployees.Add(janet);
            string userInput = "";

            while (userInput != "9")
            {
                Console.Clear();
                menu.ShowMainMenu();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();

                            for (int i = 0; i < listOfEmployees.Count; i++)
                            {
                                Console.Write(i + " ");
                                listOfEmployees[i].PrintEmployee();

                            }
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            doctorDrey.PayEmployee();
                            anonnurse.PayEmployee();
                            ratchet.PayEmployee();
                            doctorDrey.PayEmployee();
                            farley.PayEmployee();
                            janet.PayEmployee();
                            Console.ReadKey();


                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            for (int i = 0; i < listOfEmployees.Count; i++)
                            {
                                Console.Write(i + " ");
                                listOfEmployees[i].PrintEmployee();

                            }
                            Console.WriteLine("please select the number of employee you want to choose");
                            int choiceInput = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("you have chosen: ");
                            listOfEmployees[choiceInput].PrintEmployee();
                            Console.WriteLine("press any key to continue");
                            Console.ReadKey();


                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine("Choose who you would like to draw blood from the Patient.");
                            Console.WriteLine("1. Doctor");
                            Console.WriteLine("2. Nurse");
                            string drawChoice = (Console.ReadLine());
                            switch (drawChoice)
                            {
                                case "1":
                                    doctorDrey.DrawBlood(testPatient);
                                    break;
                                case "2":
                                    ratchet.DrawBlood(testPatient);
                                    break;
                                default:
                                    return;
                                

                                
                            }

                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("Choose who you would like to care for the Patient.");
                            Console.WriteLine("1. Doctor");
                            Console.WriteLine("2. Nurse");
                            string careChoice = (Console.ReadLine());
                            switch (careChoice)
                            {
                                case "1":
                                    doctorDrey.CarePatient(testPatient);
                                    break;
                                case "2":
                                    ratchet.CarePatient(testPatient);
                                    break;
                                default:
                                    return;
                            }

                        }
                        break;
                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Goodbye");
                            Console.ReadKey();
                        }
                        break;
                }
            }

            
            Console.WriteLine("DONE");
            Console.ReadKey();

        }

    }

}
