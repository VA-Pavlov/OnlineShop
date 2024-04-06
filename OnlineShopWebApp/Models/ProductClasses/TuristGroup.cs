namespace OnlineShopWebApp.Models.ProductClasses
{
    public class TuristGroup
    {
        private int actualValuePeopleInGroup;

        public int MaximumPeopleInGroup { get; }
        public int ActualValuePeopleInGroup
        {
            get { return actualValuePeopleInGroup; }
            set
            {
                if (value < 0 || value > MaximumPeopleInGroup) throw new Exception("Некорректное количество участников");
                actualValuePeopleInGroup = value;
            }
        }
        public TuristGroup(int maximumPeopleInGroup, int actualValuePeopleInGroup)
        {
            MaximumPeopleInGroup = maximumPeopleInGroup;
            ActualValuePeopleInGroup = actualValuePeopleInGroup;
        }

        public override string ToString()
        {
            return $"{ActualValuePeopleInGroup}/{MaximumPeopleInGroup}";
        }
    }
}