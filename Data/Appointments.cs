using System;
using System.Collections.Generic;

namespace Blazor_DevExpress.Data
{
    public static class Appointments
    {
        public class Appointment
        {
            public Appointment() { }
            public int AppointmentType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Caption { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public int Label { get; set; }
            public int Status { get; set; }
            public bool AllDay { get; set; }
            public string Recurrence { get; set; }
        }

        public static List<Appointment> GetAppointments()
        {
            var date = DateTime.Today;

            var list = new List<Appointment>()
            {
                new Appointment
                {
                    Caption = "Upgrade Server Hardware",
                    StartDate = date.Add(new TimeSpan(6, 11, 0, 0)),
                    EndDate = date.Add(new TimeSpan(6, 13, 38, 8)),
                    Label = 8,
                    Status = 1
                },      
                new Appointment
                {
                    Caption = "Launch New Website",
                    StartDate=date+(new TimeSpan (5, 13, 20, 0)),
                    EndDate=date+(new TimeSpan (5, 16, 8, 8)),
                    Label = 9,
                    Status = 1
                }
                // Diğer randevuları buraya ekleyebilirsiniz.
            };

            return list;
        }
    }
}
