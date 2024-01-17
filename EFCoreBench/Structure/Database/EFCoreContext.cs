using Microsoft.EntityFrameworkCore;

public class EFCoreContext : DbContext {
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfiguration(new MovieConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
