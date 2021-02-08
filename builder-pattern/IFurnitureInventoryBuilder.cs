using System; 

namespace Builder_Pattern
{

public interface IFurnitureInventoryBuilder
{
    void AddTitle(); 

    void AddDimensions(); 

    void AddLogistics(DateTime dateTime); 

    InventoryReport GetDailyReport(); 
}

}