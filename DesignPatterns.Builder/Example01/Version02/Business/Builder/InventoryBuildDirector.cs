namespace DesignPatterns.Builder.Example01.Version02.Business.Builder;

public class InventoryBuildDirector
{
    private readonly IFurnitureInventoryBuilder _builder;

    public InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
    {
        _builder = concreteBuilder;
    }

    public void BuildCompleteReport()
    {
        _builder.AddTitle();
        _builder.AddDimensions();
        _builder.AddLogistics(DateTime.Now);
    }
}