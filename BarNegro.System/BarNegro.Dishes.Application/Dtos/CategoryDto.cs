namespace BarNegro.Dishes.Application.Dtos
{
    public record CategoryDto
    {
        public CategoryDto(int categoryId, string description)
        {
            CategoryId = categoryId;
            Description = description;
        }

        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
