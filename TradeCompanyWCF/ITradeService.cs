using System.Collections.Generic;
using System.ServiceModel;
using TradeCompanyWCF.Models;

namespace TradeCompanyWCF
{
    /// <summary>
    /// WCF сервис данных
    /// </summary>
    [ServiceContract]
    public interface ITradeService
    {
        /// <summary>
        /// Получить список всех покупателей
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Customer> GetCustomers();

        /// <summary>
        /// Получить список всех заказов покупателя по его идентификатору
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [OperationContract]
        List<Order> GetOrders(int customerId);
    }
}
