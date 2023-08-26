using System;
namespace Pets
{
	class Pet
	{
		private string name;
		private DateTime arriving_date;
		private DateTime birth_date;

		public set_name(string name_in) { name = name_in; }
		public set_date_in(DateTime date_in) { this->arriving_date = date_in; }
		public set_birth_date(DateTime birth_date_in) { birth_date = birth_date_in; }
		public get_name() { return name}
		public get_date_in() { return arriving_date}
		public get_age()
		{
			int age = DateTime.Today - birth_date;
			return age;
		}
		public virtual string check_on_pet() { }
		public virtual string serve_food() { }
	}

	class Cat : Pet
	{
		public override string check_on_pet()
		{
			return "\"meow grrr meow\" (it sounds very happy) :)"
		}

	}

	class Siamese : Cat
	{
		Siamese(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
		}

		public override string serve_food()
		{
			return $"{name}, the siamese cat, eating with joy"
		}
	}
	class British : Cat
	{
		British(string name_in, DateTime date_in, DateTime birth_date_in)
		public override string serve_food()
		{
			return $"{name}, the british cat, left no crumbs"
	}
	}
	class Dog : Pet
	{
		public override string check_on_pet()
		{
			return "\"how how\" (sounds like it had a great day) :)"
		}
	}

	class Poodle : Dog
	{
		Poodle(string name_in, DateTime date_in, DateTime birth_date_in)
		public override string serve_food()
		{
			return $"{name}, the poodle, is eating deligtfully"
	}
	}

	class GoldenRetriever : Dog
	{
		GoldenRetriever(string name_in, DateTime date_in, DateTime birth_date_in)
		public override string serve_food()
		{
			return $"{name}, the golden retriever, loves the food as always."
	}
	}

	class Fish : Pet
	{
		public override string check_on_pet()
		{
			return "bloop bloop (never seen it so alive) :)"
		}
	}

	class Goldfish : Fish
	{
		Goldfish(string name_in, DateTime date_in, DateTime birth_date_in)
		public override string serve_food()
		{
			return $"{name}, the goldfish, still trying to catch all the pieces"
	}
	}

	class Angelfish : Fish
	{
		Angelfish(string name_in, DateTime date_in, DateTime birth_date_in)
		public override string serve_food()
		{
			return $"{name}, the angelfish, happy to get its food"
	}
	}
}
