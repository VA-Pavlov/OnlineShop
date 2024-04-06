using System.ComponentModel;

namespace OnlineShopWebApp.Models.ProductClasses
{
    public enum RoutesDifficulty
    {
        [Description("Простой. Подойдет для каждого.")]
        Easy,
        [Description("Средний. Требует физической подготовки.")]
        Medium,
        [Description("Сложный. Требует хорошей физической подготовки и опыта в туризме.")]
        Hard
    }
}
