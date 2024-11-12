using ContactList.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactList;

public class ContactContext : DbContext
{
    public ContactContext(DbContextOptions<ContactContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}