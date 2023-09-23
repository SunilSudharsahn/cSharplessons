using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWind.Models
{
    public class OrderIDviewModel
    {
        public int ID { get; set; }
        public readonly List<SelectListItem> OrderIDselectListItems;
        public OrderIDviewModel(List<int> orderIDs)
        {
            OrderIDselectListItems=new List<SelectListItem>();  
            foreach(var no in orderIDs)
            {
                OrderIDselectListItems.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
