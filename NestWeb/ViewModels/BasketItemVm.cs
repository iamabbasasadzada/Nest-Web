namespace NestWeb.ViewModels
{
    public class BasketItemVm
    {
        public int ProdId { get; set; } 
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Raiting { get; set; }
        public int Count { get; set; }
        public bool IsAviable { get; set; }
    }
}
