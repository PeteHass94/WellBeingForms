using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace WellBeingForms
{
    
    class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://xamarinfirebase-AIzaSyCChuUMIokEigzE2CR9k8gcwYqWP3B7VrQ.firebaseio.com/");
        public async Task<List<User>> GetAllUsers()
        {    

            return (await firebase
              .Child("users")
              .OnceAsync<User>()).Select(item => new User
              {
                  Id = item.Object.Id,
                  Image = item.Object.Image,
                  Name = item.Object.Name,
                  Pin = item.Object.Pin
              }).ToList();
        }
        //public bool checkUserExists()
        //{
        //    if(await firebase
        //        .Child("users").OnceAsync<User>
        //        )
        //}
    }

   
}
