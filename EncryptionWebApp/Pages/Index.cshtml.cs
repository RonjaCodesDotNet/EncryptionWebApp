using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EncryptionWebApp.Models;

namespace EncryptionWebApp.Pages
{
    internal class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string EncryptOrDecrypt { get; set; }

        [BindProperty]
        public string MethodChoice { get; set; }

        [BindProperty]
        public string TextInput { get; set; }

        public string TextOutput { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (EncryptOrDecrypt == "encrypt")
            {
                switch (MethodChoice)
                {
                    case "caesarCipher":
                        TextOutput = CaesarCipherMethod.Encrypt(TextInput);
                        break;

                    default:
                        Console.WriteLine("No method was specified.");
                        break;
                }
            }
            else if (EncryptOrDecrypt == "decrypt")
            {
                switch (MethodChoice)
                {
                    case "caesarCipher":
                        TextOutput = CaesarCipherMethod.Decrypt(TextInput);
                        break;

                    default:
                        Console.WriteLine("No method was specified.");
                        break;
                }
            }

            return Page();
        }
    }
}