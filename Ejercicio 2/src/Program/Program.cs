using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient("Juan","54818839","091511380","19");
            Doctor d1 = new Doctor("jorge","dentista");
            Console.WriteLine(AppointmentService2.CreateAppointment(p1.getInfo(),"27,06,2003","casa",d1.getInfo()));
        }
    }
}
