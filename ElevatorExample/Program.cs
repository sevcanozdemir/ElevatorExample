using System;

namespace ElevatorExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Elevator elevator = new Elevator();
            elevator.Capacity = 10000;

    

            while (true)
            {
                try
                {


                    Console.WriteLine("Gitmek istediğiniz kati seçiniz");
                    int t_index = Convert.ToInt32(Console.ReadLine());
                    int go = elevator.CurrentFloor(t_index);


                    if (!(elevator._floor < 0 && go > (int)Floors.floor4))
                    {

                        throw new InvalidOperationException();


                    }


                    if (elevator._floor == go)
                    {
                        elevator.OpenDoor();
                    }
                    else if (elevator._floor > go)
                    {

                        Console.WriteLine("Asansör " + elevator.Upstair(elevator._floor, go) +
                            "  kat aşağı iniyor");
                    }
                    else if (elevator._floor < go)
                    {
                        Console.WriteLine("Asansör " + elevator.Upstair(elevator._floor, go) +
                            "  kat yukari çikiyor");
                    }



                    if (go == (int)Floors.ground_floor)
                    {
                        Console.WriteLine("Floor:" + Floors.ground_floor);


                    }
                    else if (go == (int)Floors.floor1)
                    {
                        Console.WriteLine("Floor:" + Floors.floor1);

                    }
                    else if (go == (int)Floors.floor2)
                    {
                        Console.WriteLine("Floor:" + Floors.floor2);

                    }
                    else if (go == (int)Floors.floor3)
                    {
                        Console.WriteLine("Floor:" + Floors.floor3);

                    }
                    else if (go == (int)Floors.floor4)
                    {
                        Console.WriteLine("Floor:" + Floors.floor4);

                    }

                    elevator._floor = go;


                }
                catch (FormatException)
                {

                    Console.WriteLine("Hatali türde ");
                }
                catch (Exception)
                {

                    Console.WriteLine("Hatali giris ");
                }



            }
           

     

            



        }
    }
}
