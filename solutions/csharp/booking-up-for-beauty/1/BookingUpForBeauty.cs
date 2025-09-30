static class Appointment
{

    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        int hour = appointmentDate.Hour;
        string period = "AM";
        if (hour >= 12)
        {
            period = "PM";
            if (hour > 12)
                hour -= 12;
        }
        if (hour == 0)
            hour = 12;
        return $"You have an appointment on {appointmentDate.Month}/{appointmentDate.Day}/{appointmentDate.Year} {hour}:{appointmentDate.Minute:D2}:{appointmentDate.Second:D2} {period}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}
