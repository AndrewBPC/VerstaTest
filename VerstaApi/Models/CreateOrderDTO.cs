namespace VerstaApi.Models
{
    public class CreateOrderDTO
    {
        public string CityFrom { get; set; }
        public string AddressFrom { get; set; }
        public string CityTo { get; set; }
        public string AddressTo { get; set; }
        public decimal CargoWeight { get; set; }
        public DateOnly PickupDate { get; set; }
    }
}
