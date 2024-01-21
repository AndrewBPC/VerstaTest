using System.Text;

namespace VerstaApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserFriendlyId { get; set; } = GenerateRandomOrderID(5);
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
        public static string GenerateRandomOrderID(int length)
        {
            const string characters = "ABCDFGHJKLMNOPQRSTUVXYZ0123456789";
            StringBuilder orderID = new StringBuilder(length);

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length);
                orderID.Append(characters[index]);
            }

            return orderID.ToString();
        }
    }
}
