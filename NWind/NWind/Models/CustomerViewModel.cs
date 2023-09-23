using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWind.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; } //for the selected item. ie one id for the dropdown
        public readonly List<SelectListItem> CustomerIdsSelectedList;
        public CustomerViewModel(List<string> customerIds)
        {
            CustomerIdsSelectedList = new List<SelectListItem>();
            foreach (var no in customerIds)
            {
                CustomerIdsSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
