using System.Collections.Generic; 
using System.Linq; 
using System; 

namespace Builder_Pattern
{
    public class DailyReportBuilder: IFurnitureInventoryBuilder 
    {
        private InventoryReport _report; 
        private IEnumerable<FurnitureItem> _items; 

    public DailyReportBuilder(IEnumerable<FurnitureItem> furnitureItems)
    {
        Reset(); 
        this._items = furnitureItems; 
    }
        public void Reset()
        {
            this._report = new InventoryReport(); 
        }

        public IFurnitureInventoryBuilder AddTitle()
        {
            _report.TitleSection = "------------ Daily Inventory Report ---------------\n\n"; 
            return this; 
        }

        public IFurnitureInventoryBuilder AddDimensions()
        {
            _report.DimensionsSection = string.Join(Environment.NewLine, this._items.Select(product=>$"Product: {product.Name} \n Price: {product.Price} \n Height:{product.Height} \n Width:{product.Width} \n Weight: {product.Weight}")); 
            return this; 
        }
        public IFurnitureInventoryBuilder AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime}"; 
            return this; 
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport finishedReport = _report; 
            Reset(); 
            return finishedReport; 
        }
    }
}