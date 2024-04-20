using System.Runtime.Serialization;

namespace TradeCompanyWCF.Models
{
    /// <summary>
    /// Покупатель
    /// </summary>
    [DataContract]
    public class Customer
    {
        /// <summary>
        /// Идентификатор покупателя
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [DataMember]
        public string Surname { get; set; }

        /// <summary>
        /// Год рождения
        /// </summary>
        [DataMember]
        public int BirthYear { get; set; }
    }
}
