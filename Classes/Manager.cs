using HospitalTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTrackingApp.Classes
{
    public class Manager
    {
        public static List<PersonLocation> personLocations { get; set; } = new List<PersonLocation>();

        public static void GeneratePersonLocations(int countOfPersons)
        {
            personLocations.Clear();
            Random rnd = new Random();

            for (int i = 1; i <= countOfPersons; i++)
            {
                PersonLocation personLocation =
                    new PersonLocation(i, rnd.Next(0, 2) == 0 ? "Клиент" : "Сотрудник", rnd.Next(0, 23), rnd.Next(0, 2) == 0 ? "in" : "out", new DateTime(2024, 3, 17, rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60)));

                personLocations.Add(personLocation);
            }
        }
    }
}
