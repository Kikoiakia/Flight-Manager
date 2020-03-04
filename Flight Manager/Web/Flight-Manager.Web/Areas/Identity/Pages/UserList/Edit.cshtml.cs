namespace Flight_Manager.Web.Areas.Identity.Pages.UserList
{
    using Flight_Manager.Data;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    [Authorize]
    public class EditModel : PageModel
    {

        private readonly FlightDbContext _context;

        public EditModel(FlightDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FlightUserModel FlightUser { get; set; }

        public class FlightUserModel
        {
            [HiddenInput]
            public string Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Surname { get; set; }

            [MinLength(10)]
            [StringLength(10, ErrorMessage = "Personal Id must be 10 characters long")]
            [RegularExpression(@"^[0-9]*$", ErrorMessage = "Personal Id must be only numbers")]
            public string PersonalId { get; set; }

            [Required]
            public string Address { get; set; }

            [Required]
            [Phone]
            public string PhoneNumber { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Username { get; set; }
        }

        public async void OnGet(string id)
        {
            var UserFromDb = await _context.Users.FindAsync(id);
            FlightUser = new FlightUserModel()
            {
                Id = UserFromDb.Id,
                Name = UserFromDb.Name,
                Surname = UserFromDb.Surname,
                PersonalId = UserFromDb.PersonalId,
                Address = UserFromDb.Address,
                PhoneNumber = UserFromDb.PhoneNumber,
                Username = UserFromDb.UserName,
                Email = UserFromDb.Email
            };
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var UserFromDb = await _context.Users.FindAsync(FlightUser.Id);
                UserFromDb.Id = FlightUser.Id;
                UserFromDb.Name = FlightUser.Name;
                UserFromDb.Surname = FlightUser.Surname;
                UserFromDb.PersonalId = FlightUser.PersonalId;
                UserFromDb.Address = FlightUser.Address;
                UserFromDb.PhoneNumber = FlightUser.PhoneNumber;
                UserFromDb.UserName = FlightUser.Username;
                UserFromDb.Email = FlightUser.Email;

                await _context.SaveChangesAsync();

                return Redirect("/Identity/UserList");
            }

            return RedirectToPage();
        }
    }
}
