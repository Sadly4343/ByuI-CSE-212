using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;

public class FeatureCollection
{
    public Feature[] Features { get; set; }
}
public class Feature
{
    public Properties properties { get; set; }
}

public class Properties
{
    public string Place { get; set; }

    public double Mag { get; set; }
}
