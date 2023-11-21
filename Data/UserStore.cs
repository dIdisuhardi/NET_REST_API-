using Kel33_Mod9_TugasAPI.Models.Dto;

namespace Kel33_Mod9_TugasAPI.Data
{
    public static class UserStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
        {
             new UserDTO{Id=1, Username="Didi", Password="Suhardi"},
             new UserDTO{Id=2, Username="Uruha", Password="Rushia"}
        };
    }
}
