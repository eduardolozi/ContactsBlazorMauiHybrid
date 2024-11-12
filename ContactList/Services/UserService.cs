using ContactList.Models;

namespace ContactList.Services;

public class UserService(ContactContext contactContext) {

    public void Add(User user)
    {
        contactContext.Users.Add(user);
        contactContext.SaveChanges();
    }
    
    public void Edit(User user)
    {
        contactContext.Users.Update(user);
        contactContext.SaveChanges();
    }
    
    public void Delete(User user)
    {
        contactContext.Users.Remove(user);
        contactContext.SaveChanges();
    }
    
    public List<User> GetAll()
    {
        return contactContext.Users.ToList();
    }
    
    public User? GetById(int id)
    {
        return contactContext.Users.Find(id);
    }
}