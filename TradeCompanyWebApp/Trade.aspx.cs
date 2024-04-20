using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TradeCompanyWebApp.TradeServiceReference;


namespace TradeCompanyWebApp
{
    public partial class Trade : System.Web.UI.Page
    {
        /// <summary>
        /// Коллекция покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Заказы выбранного покупателя
        /// </summary>
        private List<Order> _slectedCustomerOrders = new List<Order>();

        /// <summary>
        /// Получить клиент сервиса
        /// </summary>
        /// <returns></returns>
        private TradeServiceClient GetWCFClient() => new TradeServiceClient();

        /// <summary>
        /// Получить список покупателей
        /// </summary>
        /// <returns></returns>
        private List<Customer> GetCustomers()
        {
            using (var client = GetWCFClient())
            {
                return client.GetCustomers().ToList();
            }
        }

        /// <summary>
        /// Получить список заказов покупателя
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        private List<Order> GetOrders(int customerId)
        {
            using (var client = GetWCFClient())
            {
                return client.GetOrders(customerId).ToList();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _customers = GetCustomers();
            GridView1.DataSource = _customers;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // идентификатор выбранного покупателя
            var selectedCustomerId = (int)GridView1.SelectedValue;

            // если покупатель выбран то его код больше 0
            if (selectedCustomerId > 0)
            {
                // считываем заказы
                _slectedCustomerOrders = GetOrders(selectedCustomerId);
                GridView2.DataSource = _slectedCustomerOrders;
                GridView2.DataBind();
                // показываем панель с его заказами
                Panel1.Visible = true;

            }
            else
            {
                // прячем панель с заказами
                Panel1.Visible = false;
                // очищаем список заказов
                _slectedCustomerOrders = null;
                GridView2.DataSource = null;
                GridView2.DataBind();
            }
        }
    }
}