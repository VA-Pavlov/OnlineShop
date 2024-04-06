namespace OnlineShopWebApp.Models.ProductClasses
{
    public class Product
    {
        private int travelDuration;
        private DateTime endDate;
        private decimal cost;
        private int actualValuePeopleInGroup;
        private static int count = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string ProductImage { get; set; }
        public string Country { get; set; }
        public int TravelDuration
        {
            get
            {
                return travelDuration;
            }
            set
            {
                if (value > 0)
                    travelDuration = value;
                else
                    throw new Exception("Введена некорректная величина");
            }
        }
        public DateTime StartDate { set; get; }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (StartDate > value)
                    throw new Exception("Установлен неверный диапазон даты");
                endDate = value;
            }
        }
        public RoutesDifficulty RouteDifficulty { get; set; }
        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Установлена некорректная цена");
                cost = value;
            }
        }
        public TuristGroup Group { get; set; }
        public ProductStatus Status { get; set; }

        public Product(string name, string productImage, string country, int travelDuration, DateTime startDate, DateTime endDate, RoutesDifficulty routeDifficulty, decimal cost, int maximumPeopleInGroup, int actualValuePeopleInGroup, ProductStatus status)
        {
            Id = count++;
            Name = name;
            ProductImage = productImage;
            Country = country;
            TravelDuration = travelDuration;
            StartDate = startDate;
            EndDate = endDate;
            RouteDifficulty = routeDifficulty;
            Cost = cost;
            Group = new TuristGroup(maximumPeopleInGroup, actualValuePeopleInGroup);
            Status = status;
        }

        public override string ToString()
        {
            return $"ID: {Id}" +
                $"\n{ProductImage}" +
                $"\n{Country}" +
                $"\n{Name}\n" +
                $"Длительность: {TravelDuration} {LanguageHelper.ReturnLangugeFormFoDay(TravelDuration)}" +
                $"\nСложность: {RouteDifficulty}" +
                $"\n{(StartDate == EndDate ? $"{StartDate.ToString("dd-MM-yy")}" : $"C {StartDate.ToString("dd-MM")} по {EndDate.ToString("dd-MM-yy")}")}" +
                $"\nМест в группе {Group}" +
                $"\nЦена: {Cost} руб.";
        }

    }
}
