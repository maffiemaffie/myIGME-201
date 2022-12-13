using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Cohen_PE13
{
    static internal class Program
    {
        public static Pets pets;

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(20000);
            myTimer.Elapsed += new ElapsedEventHandler(Dog.EvictCat);
            myTimer.Start();

            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            pets = new Pets();

            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");

                        Console.Write("Dog's Name => ");
                        string sName = Console.ReadLine();

                        int nAge;
                        do
                        {
                            Console.Write("Age => ");
                            string sAge = Console.ReadLine();
                            if ( int.TryParse(sAge, out nAge) ) break ;
                        } while (true);

                        Console.Write("License => ");
                        string sLicense = Console.ReadLine();

                        pets.Add(new Dog(sLicense, sName, nAge));

                    }
                    else
                    {
                        Console.WriteLine("You bought a cat!");

                        Cat thisCat = new Cat();
                        Console.Write("Cat's Name => ");
                        string sName = Console.ReadLine();

                        int nAge;
                        do
                        {
                            Console.Write("Age => ");
                            string sAge = Console.ReadLine();
                            if (int.TryParse(sAge, out nAge)) break;
                        } while (true);

                        thisCat.Name = sName;
                        thisCat.age = nAge;

                        pets.Add(thisCat);
                    }
                }
                else
                {
                    int nPetSelector = rand.Next(0, pets.Count);
                    thisPet = pets[nPetSelector];

                    if (thisPet == null) continue;

                    if (thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (Cat)thisPet;
                        switch (rand.Next(0, 5))
                        {
                            case 0:
                                iCat.Eat();
                                break;
                            case 1:
                                iCat.Play();
                                break;
                            case 2:
                                iCat.Purr();
                                break;
                            case 3:
                                iCat.Scratch();
                                break;
                            case 4:
                                iCat.GotoVet();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        iDog = (Dog)thisPet;
                        switch (rand.Next(0, 5))
                        {
                            case 0:
                                iDog.Eat();
                                break;
                            case 1:
                                iDog.Play();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                            case 4:
                                iDog.GotoVet();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }

    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
        void GotoVet();
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        public Pet() { }
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Pets
    {
        List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }
                return returnVal;
            }

            set
            {
                if (nPetEl < petList.Count)
                {
                    petList[nPetEl] = value;
                }
                else
                {
                    petList.Add(value);
                }
            }
        }

        public int Count { get { return petList.Count; } }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }

    public class Cat : Pet, ICat
    {
        public override void Eat()
        {
            Console.WriteLine("{0} ate an entire fish. incredible.", Name);
        }
        public override void Play()
        {
            Console.WriteLine("{0} played with a toy mouse... I-I think it's a toy..", Name);
        }
        public void Purr()
        {
            Console.WriteLine("{0} purred softly. Sometimes the little things mean the most.", Name);
        }
        public void Scratch()
        {
            Console.WriteLine("YOWCH! {0} scratched you. You didn't do anything wrong this time, {0} merely gave in to the intrusive thoughts :(", Name);
        }
        public override void GotoVet()
        {
            Console.WriteLine("{0} went to the vet. It went surprisingly well actually.", Name);
        }

        public void Evicted()
        {
            Console.WriteLine("{0}: You can't eject me!! I'm ejecting you!", Name);
            for (int i = 0; i < Program.pets.Count; i++)
            {
                if (Program.pets[i] is Dog) ((Dog)Program.pets[i]).Evicted();
            }
        }

        public Cat() : base()
        {
            Name = "test";
        }
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {
            Console.WriteLine("{0} devoured an entire roasted ham. Maybe you shouldn't have left that there...", Name);
        }
        public override void Play()
        {
            Console.WriteLine("{0} played fetch for a few hours. Miraculously, {0} is not tired yet.", Name);
        }
        public void Bark()
        {
            Console.WriteLine("BARK BARK BARK BARK BARK BARK BARK!!!! (that was {0} not me, I swear).", Name);
        }
        public void NeedWalk()
        {
            Console.WriteLine("You took {0} for a walk. If we're being honest, you probably needed it more than they did.", Name);
        }
        public override void GotoVet()
        {
            Console.WriteLine("It took a little work, but you were able to coax {0} to visit the vet. They're still not thrilled but I'm proud of you", Name);
        }

        public static void EvictCat(object sender, ElapsedEventArgs e)
        {
            Dog dog = null;
            Cat cat = null;

            for (int i = 0; i < Program.pets.Count; i++)
            {
                if (Program.pets[i] is Dog)
                {
                    dog = ((Dog)Program.pets[i]);
                }
            }

            for (int i = 0; i < Program.pets.Count; i++)
            {
                if (Program.pets[i] is Cat)
                {
                    cat = ((Cat)Program.pets[i]);
                }
            }

            if (dog == null || cat == null) return;

            Console.WriteLine("{0}: {1} has been ejected.", dog.Name, cat.Name);
            cat.Evicted();
        }

        public void Evicted()
        {
            Console.WriteLine("{0} was the impostor.", Name);
        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            license = szLicense;
        }

    }


}
