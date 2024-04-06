using System.ComponentModel;

namespace OnlineShopWebApp.Models.OrderClasses
{
    public enum OrderStatus
    {
        [Description("Принят")]
        accepted,
        [Description("В работе")]
        inProgress,
        [Description("Готов к отправке")]
        ready,
        [Description("В пути")]
        onTheWay,
        [Description("Выполнен")]
        completed,
        [Description("Отменен")]
        cancelled
    }
}

