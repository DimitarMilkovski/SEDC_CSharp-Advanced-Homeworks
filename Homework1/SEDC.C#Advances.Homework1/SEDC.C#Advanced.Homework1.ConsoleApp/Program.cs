
using SEDC.C_Advances.Homework1;
using SEDC.C_Advances.Homework1.Models;

PetStore<Dog> dogStore = new PetStore<Dog>();
PetStore<Cat> catStore = new PetStore<Cat>();
PetStore<Fish> fishStore =  new PetStore<Fish>();


dogStore.Insert(new Dog() { Name = "Bard", Age = 4, Type = "Husky", FavouriteFood = "bones" });
dogStore.Insert(new Dog() { Name = "Reks", Age = 2, Type = "German shepherd", FavouriteFood = "meat" });
catStore.Insert(new Cat() { Name = "Lina", Age = 3, Type = "type1", Lazy = true, LivesLeft = 9 });
catStore.Insert(new Cat() { Name = "Maca", Age = 1, Type = "type2", Lazy = false, LivesLeft =6 });
fishStore.Insert(new Fish() { Name = "Nemo", Age = 1, Type = "crvenoperka", Color = "Red", Size = "small" });
fishStore.Insert(new Fish() { Name = "Srpska Riba", Age = 1, Type = "Oslich", Color = "Grey", Size = "medium" });

Console.WriteLine("==== Before====");
dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("====After====");


dogStore.BuyPet("Bard");
catStore.BuyPet("Maca");

dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();



