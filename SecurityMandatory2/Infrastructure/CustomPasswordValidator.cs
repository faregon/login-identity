using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace SecurityMandatory2.Infrastructure
{
    public class CustomPasswordValidator : PasswordValidator 
    {
        public override async Task<IdentityResult> ValidateAsync(string pass)
        {
            
            IdentityResult result = await base.ValidateAsync(pass);
            if (pass.Contains("12345"))
            {
                var errors = result.Errors.ToList();
                errors.Add("Password cannot contain numeric sequnces");
                result = new IdentityResult(errors);
            
            }else if (pass.ToUpper().Contains("ABCDE"))
            {
                var errors = result.Errors.ToList();
                errors.Add("Password cannot contain alphanumeric sequences f.x. 'abcd'");
                result = new IdentityResult(errors);
            }else if(pass.ToUpper().Contains("ASDFG")) {
                var errors = result.Errors.ToList();
                errors.Add("password cannot contain keyboard sequneces");
                result = new IdentityResult(errors);
            }
            return result;
        }
        
    }
}