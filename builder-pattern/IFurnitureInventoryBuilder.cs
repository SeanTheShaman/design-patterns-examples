using System; 

namespace Builder_Pattern
{

public interface IFurnitureInventoryBuilder
{
    IFurnitureInventoryBuilder AddTitle(); 

    IFurnitureInventoryBuilder AddDimensions(); 

    IFurnitureInventoryBuilder AddLogistics(DateTime dateTime); 

    InventoryReport GetDailyReport(); 
}

}