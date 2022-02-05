namespace DesignPatterns.Builder.Example01.Version02.Business.Builder;

public interface IFurnitureInventoryBuilder
{
    IFurnitureInventoryBuilder AddTitle();
    IFurnitureInventoryBuilder AddDimensions();
    IFurnitureInventoryBuilder AddLogistics(DateTime dateTime);
    InventoryReport GetDailyReport();
}