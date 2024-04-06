using System.ComponentModel;

namespace OnlineShopWebApp.Models.ProductClasses
{
    public enum ProductStatus
    {
        [Description("Актуальный тур.")]
        active,
        [Description("Тур снят с продажи и перемещен в архив.")]
        completed
    }
}
