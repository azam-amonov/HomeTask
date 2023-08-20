using System.Net.Sockets;

namespace HomeTask_27_C25.N25_HT1;

public interface IProductService
{
    List<IProduct> Inventory { get;}
    
    void Add(IProduct product);
    ProductFilterDataModel GetFilterData();
    

}