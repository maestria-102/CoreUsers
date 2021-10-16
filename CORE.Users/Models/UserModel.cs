using System;

namespace CORE.Users.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}