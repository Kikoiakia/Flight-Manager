﻿namespace Flight_Manager.Web.Areas.Identity.Pages.Account
{
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Flight_Manager.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System;
    using Flight_Manager.Data;
    using System.Linq;

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<FlightUser> _signInManager;
        private readonly UserManager<FlightUser> _userManager;
        private readonly FlightDbContext _context;

        public RegisterModel(
            UserManager<FlightUser> userManager,
            SignInManager<FlightUser> signInManager,
            FlightDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }


        public class InputModel
        {
            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Surname")]
            public string Surname { get; set; }


            [Display(Name = "PersonalId")]
            [MinLength(10)]
            [StringLength(10, ErrorMessage = "Personal Id must be 10 characters long")]
            [RegularExpression(@"^[0-9]*$", ErrorMessage = "Personal Id must be only numbers")]
            public string PersonalId { get; set; }

            [Required]
            [Display(Name = "Address")]
            public string Address { get; set; }

            [Required]
            [Phone]
            [Display(Name = "PhoneNumber")]
            public string PhoneNumber { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = "/";
            if (ModelState.IsValid)
            {
                var user = new FlightUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Input.Name,
                    Surname = Input.Surname,
                    PersonalId = Input.PersonalId,
                    Address = Input.Address,
                    PhoneNumber = Input.PhoneNumber,
                    UserName = Input.Username,
                    Email = Input.Email
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    if (this._context.Users.Count() == 1)
                    {
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, "NotAdmin");
                    }
                   
                    return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
