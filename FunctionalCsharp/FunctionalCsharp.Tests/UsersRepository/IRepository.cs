using LanguageExt;

namespace FunctionalCsharp.UsersRepository;

public interface IRepository
{
    Option<User> LoadUser(int userId);
}