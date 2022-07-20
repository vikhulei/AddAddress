using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string StreetAddress { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        [BindProperty(SupportsGet = true)]
        public string State { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string ZipCode { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //if (ModelState.IsValid == false)
            //{
            //    return Page();
            //}
            //return RedirectToPage("/Index", new { Address.City }); 
            return RedirectToPage("/Forms/AddAddress", new { Address.StreetAddress, Address.City, Address.State,  Address.ZipCode });
        }
    }
    
}
