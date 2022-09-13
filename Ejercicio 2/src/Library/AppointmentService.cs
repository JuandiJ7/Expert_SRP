using System;
using System.Text;
using System.Collections.Generic;



namespace Library
{
    /* public class AppointmentService //Esta clase se basa en el principio SRP, ya que tiene una única responsabilidad, la cual es validar una cita.
    { // Sin embargo, utiliza atributos que podrían estar definidos en otras clases, ya que no necesita guardar el nombre y el teléfono del paciente.
    //Por ende, se puede hacer otra clase llamada Paciente, y otra clase llamada Doctor para que esta clase recurra a la experta en cada ambito.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }*/


    public class AppointmentService2 //Clase que se basa en el principio Expert, no solo crea una cita y la guarda en una lista de citas, sino que tambien revisa su validez
    {
        private static List<string> citas = new List<string>();
        public static string CreateAppointment(string infoPatient, DateTime dates, string appointmentPlace, string infoDoctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(infoPatient))
            {
                stringBuilder.Append("Unable to schedule appointment, this patient does not exist.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(infoDoctor))
            {
                stringBuilder.Append("Unable to schedule appointment, this doctor does not exist\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append($"Appointment scheduled.");
                citas.Add($"La cita N° {identifier} pertenece a: {infoPatient},en la fecha {dates}, en {appointmentPlace}, con el doctor {infoDoctor}");
                identifier++;
            }

            return stringBuilder.ToString();
            

        }
        public static string print(int identifier){
            return (citas[identifier]);
        }
        private static int identifier = 0;
    }
    public class Patient //Clase que se basa en el principio SRP, solo tiene una unica razon por la cual cambiar.
    {
        private static string Name;
        private static string Id;
        private static string PhoneNumber;
        private static string Age;

        public Patient(string name, string id, string phoneNumber, string age)
        {
            Name = name;
            Id = id;
            PhoneNumber = phoneNumber;
            Age = age;
        }
        public string getInfo()
        {
            return (Patient.Name, Patient.Id, Patient.PhoneNumber, Patient.Age).ToString();
        }

    }

    public class Doctor //Clase que se basa en el principio SRP, solo tiene una unica razon por la cual cambiar.
    {
        
        private static string doctorName;
        private static string doctorSpecialty;

        public Doctor(string name, string specialty){
            doctorName = name;
            doctorSpecialty = specialty;
        }
        public string getInfo(){
            return (Doctor.doctorName, Doctor.doctorSpecialty).ToString();
        }

    }
}
