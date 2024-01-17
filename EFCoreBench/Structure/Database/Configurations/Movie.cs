using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MovieConfiguration : IEntityTypeConfiguration<Movie> {
    public void Configure(EntityTypeBuilder<Movie> builder) {
        builder.Property(movie => movie.Id)
            .ValueGeneratedOnAdd();

        builder.Property(movie => movie.Title)
            .HasMaxLength(50)
            .IsRequired();
    }
}
