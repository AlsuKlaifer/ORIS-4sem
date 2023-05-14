using DogWebApi.Models;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace DogWebApi.Data
{
    public static class DataSeeds
    {
        public static readonly List<Dog> list = new List<Dog>
        {
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description1",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Красивая собака",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description2",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description1",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Еще красивая собака",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description2",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description1",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Ну еще красивая собака",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description2",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description1",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "и овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description2",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description1",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Красивая собака",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description2",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
            new Dog {
                Id = Guid.NewGuid(),
                Description = "Description",
                Family = new Family
                {
                    Id = Guid.NewGuid(),
                    Name = "Овчарка",
                    Description = ""
                },
                MaxAge = 15,
                MinAge = 10,
                Height = 100,
                ImgUrl = "https://upravadorogomilovo.ru/files/data/user/elena/files/2021.09.30-1633008456.3425_sobaka.jpg",
                Weight = 1000,
                ShortDescription = "Short Description",
            },
        };
    }
}
