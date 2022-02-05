using System.Text;

namespace DesignPatterns.Builder.Example01.Version02.Business;

public class InventoryReport
{
    public string TitleSection;
    public string DimensionsSection;
    public string LogisticsSection;

    public string Debug()
    {
        return new StringBuilder()
            .AppendLine(TitleSection)
            .AppendLine(DimensionsSection)
            .AppendLine(LogisticsSection)
            .ToString();
    }
}