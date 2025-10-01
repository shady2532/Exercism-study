using System.Threading.Tasks.Dataflow;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 => "center back",
            4 => "center back",
            5 => "right back",
            6 => "midfielder",
            7 => "midfielder",
            8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => "UNKNOWN"
        };
    }

    // Add the Injury class with a public Number property
    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
            int supporters => $"There are {supporters} supporters at the match.",
            string s => s,
            float => "",
            Foul => "The referee deemed a foul.",
            Incident => "An incident happened.",
            Manager m => m.Club != null ? $"{m.Name} ({m.Club})" : $"{m.Name}",
            _ => "",

        };
    }
}
