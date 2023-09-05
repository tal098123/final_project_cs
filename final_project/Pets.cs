using System;
using Database;
namespace Pets
{
	[Serializable]
	public class Pet
	{
		public string name;
		public DateTime arriving_date;
		public DateTime birth_date;
		public int id;

		public void set_name(string name_in) { name = name_in; }
		public void set_date_in(DateTime date_in) { arriving_date = date_in; }
		public void set_birth_date(DateTime birth_date_in) { birth_date = birth_date_in; }

		public string get_name() { return name; }
		public DateTime get_arriving_date() { return arriving_date; }
		public TimeSpan get_age()
		{
			TimeSpan age = DateTime.Now - birth_date;
			return age;
		}
		public int get_id() { return id; }

		public virtual string check_on_pet() { return "the pet is unknown :$"; }
		public virtual string serve_food() { return "the pet is unknown :$"; }
	}

	public class Cat : Pet
	{
		public override string check_on_pet()
		{
			return "\"meow grrr meow\" (it sounds very happy) :)";
		}

	}

	public class Siamese : Cat
	{
		public Siamese(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
			id = SharedDatabase.id_counter;
			SharedDatabase.id_counter++;
		}

		public override string serve_food()
		{
			return $"{name}, the siamese cat, eating with joy";
		}
	}
	public class British : Cat
	{
		public British(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
			id = SharedDatabase.id_counter;
			SharedDatabase.id_counter++;
		}
		public override string serve_food()
		{
			return $"{name}, the british cat, left no crumbs";
	}
	}
	public class Dog : Pet
	{
		public override string check_on_pet()
		{
			return "\"how how\" (sounds like it had a great day) :)";
		}
	}

	public class Poodle : Dog
	{
		public Poodle(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
			id = SharedDatabase.id_counter;
			SharedDatabase.id_counter++;
		}
		public override string serve_food()
		{
			return $"{name}, the poodle, is eating deligtfully";
	}
	}

	public class GoldenRetriever : Dog
	{
		public GoldenRetriever(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
			id = SharedDatabase.id_counter;
			SharedDatabase.id_counter++;
		}
		public override string serve_food()
		{
			return $"{name}, the golden retriever, loves the food as always.";
		}
	}

	public class Fish : Pet
	{
		public override string check_on_pet()
		{
			return "bloop bloop (never seen it so alive) :)";
		}
	}

	public class Goldfish : Fish
	{
		public Goldfish(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
			id = SharedDatabase.id_counter;
			SharedDatabase.id_counter++;
		}
		public override string serve_food()
		{
			return $"{name}, the goldfish, still trying to catch all the pieces";
	}
	}

	public class Angelfish : Fish
	{
		public Angelfish(string name_in, DateTime date_in, DateTime birth_date_in)
		{
			name = name_in;
			arriving_date = date_in;
			birth_date = birth_date_in;
			id = SharedDatabase.id_counter;
			SharedDatabase.id_counter++;
		}
		public override string serve_food()
		{
			return $"{name}, the angelfish, happy to get its food";
	}
	}
}
