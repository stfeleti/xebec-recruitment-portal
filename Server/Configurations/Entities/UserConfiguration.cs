using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared;

namespace Server.Configurations.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                new User
                {
                    Id = 1,
                    Email = "sample@gmail.com",
                    PasswordHash = "2526sgfgfhsgdf984894s",
                    Role = "Candidate"    
                }
            );
        }
    }
}