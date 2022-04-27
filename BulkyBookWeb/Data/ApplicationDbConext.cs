using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data;

public class ApplicationDbConext :DbContext
{
    public ApplicationDbConext(DbContextOptions<ApplicationDbConext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; } 
}
