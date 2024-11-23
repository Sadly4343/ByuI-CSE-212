using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;

public class FeatureCollection
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public List<Properties> propertiess { get; set; }


}
public class Properties
{
    public double mag { get; set; }
}