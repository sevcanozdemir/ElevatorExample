using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorExample
{
    public class Elevator
    {
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }


        public int _floor=0;



        private Floors _floors;

        public Floors Floors
        {
            get { return _floors; }
            set { _floors = value; }
        }

        public int CurrentFloor(int index)
        {

            return index ;
        }

       

        public int Upstair(int index, int go)
        {
            int total = index + go;
            return total ;
        }

        public int Downstair(int index, int go)
        {
            int total = index - go;
            return total;
        }


        public void OpenDoor()
        {
            Console.WriteLine("Open Door ");
        }

        public void  CloseDoor()
        {

            Console.WriteLine( "Close Door");
        }





    }
}
