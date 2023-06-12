using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Profile;
using BotanicAPI.Entities.User;
using BotanicAPI.Models.LoginModel;
using BotanicAPI.Models.Register;
using BotanicAPI.Repositories.MilestoneRepository.Interfaces;
using BotanicAPI.Repositories.ProfileRepository.Interfaces;
using BotanicAPI.Repositories.UserRepository.Interfaces;
using BotanicAPI.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text.Json;

namespace BotanicAPI.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IProfileRepository _profileRepository;
        private readonly IMilestonesRepository _milestonesRepository;
        public UserService(IUserRepository userRepository, IProfileRepository profileRepository, IMilestonesRepository milestonesRepository) 
        { 
            _userRepository = userRepository;
            _profileRepository = profileRepository;
            _milestonesRepository = milestonesRepository;
        }

        public RegisterResponse CreateAsync(UserProfileRegister user) 
        {
            try
            {
                var userObj = JsonConvert.DeserializeObject<List<RegisterProfile>>(user.RegisterProfile.ToString());

                UserEntity userEntity = new UserEntity();
                ProfileEntity profileEntity = new ProfileEntity();

                userEntity.Surname = user.Surname;
                userEntity.Dni = user.Dni;
                userEntity.Email = user.Email;
                userEntity.Password = user.Password;

                var entityUserDb = _userRepository.Create(userEntity);                
                
                RegisterResponse registerResponse = new RegisterResponse();
                foreach(var item in userObj) 
                {
                    profileEntity.UserId = (int)entityUserDb.Id;
                    profileEntity.Birthday = (DateTime)item.Birthday;
                    profileEntity.Gender = item.Gender;
                    profileEntity.Active = (bool)item.Active;
                    profileEntity.Name = item.Name;
                    profileEntity.Rol = item.Rol;    

                    profileEntity = _profileRepository.Create(profileEntity);
                    
                    registerResponse.RegisterUser.Add(profileEntity);
                    registerResponse.Email = entityUserDb.Email;
                }                
                
                return registerResponse;                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public LoginResponse LoginAsync(Login login) 
        {
            try
            {
                UserEntity user = new UserEntity();
                RegisterResponse registerResponse = new RegisterResponse();
                List<UserMilestonesEntity> userMilestonesEntity = new List<UserMilestonesEntity>();
                LoginResponse loginResponse = new LoginResponse();

                user.Password = login.Password;
                user.Email = login.Email;   

                var userEntity = _userRepository.Login(user);
                                
                if (!userEntity.Email.IsNullOrEmpty()) 
                { 
                    registerResponse.Email = userEntity.Email;

                    registerResponse.RegisterUser = new List<ProfileEntity>();
                    
                    registerResponse.RegisterUser.AddRange(_profileRepository.GetAllByUserId((int)userEntity.Id));

                    userMilestonesEntity.AddRange(_milestonesRepository.GetAllByUserId((int)userEntity.Id));
                }

                loginResponse.userMilestonesEntities = userMilestonesEntity;
                loginResponse.registerResponse = registerResponse;
                
                return loginResponse;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
               
            }
        }
        public ProfileEntity CreateProfileAsync(ProfileEntity profile)
        {
            try
            {
                var result = _profileRepository.Create(profile);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
