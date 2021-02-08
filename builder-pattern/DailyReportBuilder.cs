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

        public void AddTitle()
        {
            _report.TitleSection = "------------ Daily Inventory Report ---------------\n\n"; 
        }

        public void AddDimensions()
        {
            _report.DimensionsSection = string.Join(Environment.NewLine, this._items.Select(product=>$"Product: {product.Name} \n Price: {product.Price} \n Height:{product.Height} \n Width:{product.Width} \n Weight: {product.Weight}")); 
        }
        public void AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime}"; 
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport finishedReport = _report; 
            Reset(); 
            return finishedReport; 
        }
    }
}