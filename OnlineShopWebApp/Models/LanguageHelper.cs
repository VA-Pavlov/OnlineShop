namespace OnlineShopWebApp.Models
{
    public static class LanguageHelper
    {
        public static string ReturnLangugeFormFoDay(int countDay)
        {
            switch (countDay % 10)
            {
                case 1:
                    return "день";
                case 2:
                case 3:
                case 4:
                    return "дня";
            }
            return "дней";
        }
    }
}
