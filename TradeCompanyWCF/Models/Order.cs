using System.Runtime.Serialization;

namespace TradeCompanyWCF.Models
{
    /// <summary>
    /// Заказ
    /// </summary>
    [DataContract]
    public class Order
    {
        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор заказчика
        /// </summary>
        [DataMember]
        public int CustomerId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        [DataMember]
        public int Price { get; set; }

        /// <summary>
        /// Кол-во товара
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
    }
}
