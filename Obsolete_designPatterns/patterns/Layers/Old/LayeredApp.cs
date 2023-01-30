namespace patterns.Layers.Old;

public class LayeredApp
{
    public void Main()
    {
        var dal = new Dal();
        var bl = new BL(dal);
        var ui = new UI(bl);

        ui.ViewA();
    }
}