using System; 

namespace Builder_Pattern
{
    public class InventoryBuilderDirector
    {
        private IFurnitureInventoryBuilder _builder; 

        public InventoryBuilderDirector(IFurnitureInventoryBuilder concreteBuilder)
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
}