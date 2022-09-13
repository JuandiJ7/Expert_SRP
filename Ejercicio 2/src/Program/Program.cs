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
            Console.WriteLine(AppointmentService2.CreateAppointment(p1.getInfo(),DateTime.Today,"casa",d1.getInfo()));
            Console.WriteLine(AppointmentService2.CreateAppointment(p1.getInfo(),DateTime.Now,"casa",d1.getInfo()));
            Console.WriteLine(AppointmentService2.print(0));
            Console.WriteLine(AppointmentService2.print(1));
        }
    }
}
