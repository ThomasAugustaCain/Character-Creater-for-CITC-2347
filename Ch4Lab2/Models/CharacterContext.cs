using Microsoft.EntityFrameworkCore;

namespace LordsOfTheFallenCharacterCreation.Models
{
    public class CharacterContext : DbContext
    {

        public CharacterContext(DbContextOptions<CharacterContext> options)
           : base(options)
        { }

        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Ancestry> Acestrys { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ancestry>().HasData(
                new Ancestry { AncestryId = 1, AncestryName = "Elf"},
                new Ancestry { AncestryId = 2, AncestryName = "Dwarf"},
                new Ancestry { AncestryId = 3, AncestryName = "Halfling"},
                new Ancestry { AncestryId = 4, AncestryName = "Gnome"},
                new Ancestry { AncestryId = 5, AncestryName = "Human"},
                new Ancestry { AncestryId = 6, AncestryName = "Half-elf"}
            );


            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    ClassId = 1,
                    Name = "Hallowed Knight",
                    InitalLevel = 10,
                    InitalStrength = 12,
                    InitalAgility = 8,
                    InitalEndurance = 15,
                    InitalVitality = 11,
                    InitalRadiance = 9,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 2,
                    Name = "Udirangr Warwolf",
                    InitalLevel = 12,
                    InitalStrength = 16,
                    InitalAgility = 10,
                    InitalEndurance = 13,
                    InitalVitality = 10,
                    InitalRadiance = 8,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 3,
                    Name = "Partisan",
                    InitalLevel = 12,
                    InitalStrength = 13,
                    InitalAgility = 12,
                    InitalEndurance = 12,
                    InitalVitality = 12,
                    InitalRadiance = 8,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 4,
                    Name = "Mournstead Infantry",
                    InitalLevel = 12,
                    InitalStrength = 12,
                    InitalAgility = 14,
                    InitalEndurance = 12,
                    InitalVitality = 11,
                    InitalRadiance = 8,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 5,
                    Name = "Blackfeather Ranger",
                    InitalLevel = 8,
                    InitalStrength = 11,
                    InitalAgility = 13,
                    InitalEndurance = 11,
                    InitalVitality = 10,
                    InitalRadiance = 8,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 6,
                    Name = "Exiled Stalker",
                    InitalLevel = 10,
                    InitalStrength = 9,
                    InitalAgility = 16,
                    InitalEndurance = 11,
                    InitalVitality = 11,
                    InitalRadiance = 8,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 7,
                    Name = "Orian Preacher",
                    InitalLevel = 11,
                    InitalStrength = 10,
                    InitalAgility = 8,
                    InitalEndurance = 9,
                    InitalVitality = 11,
                    InitalRadiance = 18,
                    InitalInferno = 8
                },
                new Class
                {
                    ClassId = 8,
                    Name = "Pyric Cultist",
                    InitalLevel = 10,
                    InitalStrength = 9,
                    InitalAgility = 8,
                    InitalEndurance = 11,
                    InitalVitality = 9,
                    InitalRadiance = 8,
                    InitalInferno = 18
                },
                new Class
                {
                    ClassId = 9,
                    Name = "Condemned",
                    InitalLevel = 1,
                    InitalStrength = 9,
                    InitalAgility = 9,
                    InitalEndurance = 9,
                    InitalVitality = 9,
                    InitalRadiance = 9,
                    InitalInferno = 9
                }
            );
            
            
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = 1,
                    FirstName = "Radiant",
                    LastName = "Paladin",
                    Level = 51,
                    ClassId = 1,
                    AncestryId = 5,
                    Strength = 13,
                    Agility = 8,
                    Endurance = 16,
                    Vitality = 26,
                    Radiance = 34,
                    Inferno = 8

                },
                new Character
                {
                    CharacterId = 2,
                    FirstName = "Seismic",
                    LastName = "Sorcerer",
                    Level = 42,
                    ClassId = 8,
                    AncestryId = 2,
                    Strength = 8,
                    Agility = 13,
                    Endurance = 12,
                    Vitality = 20,
                    Radiance = 8,
                    Inferno = 35
                },
                new Character
                {
                    CharacterId = 3,
                    FirstName = "Death",
                    LastName = "Knight",
                    Level = 54,
                    ClassId = 9,
                    AncestryId = 6,
                    Strength = 13,
                    Agility = 13,
                    Endurance = 13,
                    Vitality = 25,
                    Radiance = 22,
                    Inferno = 22
                }



            );
        }


    }
}
