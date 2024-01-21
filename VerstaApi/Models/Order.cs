namespace VerstaApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CityFrom { get; set; }
        public string AddressFrom { get; set; }
        public string CityTo { get; set; }
        public string AddressTo { get; set; }
        public decimal CargoWeight { get; set; }
        public DateOnly PickupDate { get; set; }
        public Order() {}
        public Order(CreateOrderDTO dto)
        {
            CityFrom = dto.CityFrom;
            AddressFrom = dto.AddressFrom;
            CityTo = dto.CityTo;
            AddressTo = dto.AddressTo;
            CargoWeight = dto.CargoWeight;
            PickupDate = dto.PickupDate;
        }
    }
}
