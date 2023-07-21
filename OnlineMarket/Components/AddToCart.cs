using Microsoft.AspNetCore.Mvc;

namespace OnlineMarket.Components
{
    [ViewComponent]
    public class AddToCart
    {
        public List<int> ints { get; set; }
        public async Task<string> InvokeAsync(int id)
        {
            //ints.Append(id);

            return id.ToString();
        }
    }
}
