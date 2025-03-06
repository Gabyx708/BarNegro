namespace BarNegro.Dishes.Application.Dtos
{
    public class ChangeDishPriceDto
    {
        public ChangeDishPriceDto(string dishId, decimal price, string userId, string userName, string userLastName)
        {
            DishId = dishId;
            Price = price;
            UserId = userId;
            UserName = userName;
            UserLastName = userLastName;
        }

        public string DishId { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
    }
}
