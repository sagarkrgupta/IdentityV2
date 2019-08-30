using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityV2fundamental
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (SqlConnection cnn = new SqlConnection(@"server=(LocalDb)\MSSQLLocalDB; Database=IdentityV2Fundamental; trusted_Connection=True"))
            //{
            //    try
            //    {
            //        cnn.Open();
            //        Console.WriteLine("Connection Open ! ");
            //        cnn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Can not open connection ! ");
            //    }

            //}

            string usernameString = "sagar@yes.com" , passwordString= "Sagar@12345";

            UserStore<IdentityUser> usertsore =  new UserStore<IdentityUser>();
            UserManager<IdentityUser> usermanager =  new UserManager<IdentityUser>(usertsore);

            /* (1) Creating new user 
             ===============================================================
             */
            //IdentityResult result = usermanager.Create(new IdentityUser("sagar@yes.com"),"Sagar@12345");
            //Console.WriteLine($"Created: {result.Succeeded}");



            /* (2) Assigning Claim to user 
             ==================================================================
             */
            IdentityUser user = usermanager.FindByName(usernameString);
            //var claim_Result = usermanager.AddClaim(user.Id, new System.Security.Claims.Claim("given_name", "scott"));
            //Console.WriteLine($"Claim result: {claim_Result.Succeeded}");

            /* (3) Check/verifying password 
             ====================================================================
             */
            bool isMatch =  usermanager.CheckPassword(user, passwordString);
            Console.WriteLine($"Password match result: {isMatch}");






            Console.ReadKey();
        }
    }
}
