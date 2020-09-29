using System;//Построить иерархию классов в соответствии с вариантом задания: Млекопитающее, парнокопытное, птица, животное.

namespace ConsoleApp1
{
    public class Animal
    {
        int countLeg;
        string nameOfAnimal;
        bool wings;
        public Animal(string n, int c, bool w)
        {
            nameOfAnimal = n;
            countLeg = c;
            wings = w;
        }
        public string nameOfAnimal2
        {
            get
            {
                return nameOfAnimal;
                
            }
            set
            {
                nameOfAnimal = nameOfAnimal2;
            }
        }
        public int countleg2
        {
            get
            {
                return countLeg;

            }
            set
            {
                countLeg = countleg2;
            }
        }
        public bool wings2
        {
            get
            {
                return wings;

            }
            set
            {
                wings=wings2;
            }

        }
public void getInfo()
        {
            Console.WriteLine($"Name of animal : {nameOfAnimal} count leg : {countLeg} wings : {wings}");
        }
    }

    public class Ptiza : Animal
    {
        string nameP;
        bool fly;
        int maxEggs;
         
        public Ptiza(string n, int c, bool w, string np,bool f,int me) : base(n,c,w) // base ключевое слово наследования 
        {
            nameP = np;
            fly = f;
            maxEggs = me;
        }
        public void getInfo1()
        {
            Console.WriteLine($"name of animal {nameOfAnimal2} count of leg {countleg2} wings not or yes {wings2}type of bird : {nameP} abillity to fly : {fly} maxEggs : {maxEggs}");
        }
    }
    class Mlekopitayushee : Animal
    {
        bool moloko;
        int nipples;
        string typeOfwool;
        public bool moloko2
        {
            get
            {
                return moloko;

            }
            set
            {
                moloko = moloko2;
            }

        }
        public int nipples2
        {
            get
            {
                return nipples;

            }
            set
            {
                nipples = nipples2;
            }

        }
        public string typeofwool2
        {
            get
            {
                return typeOfwool;

            }
            set
            {
                typeOfwool = typeofwool2;
            }

        }
        public Mlekopitayushee(string n, int c, bool w,bool m,int np,string tW): base(n,c,w)
        
        {
            moloko = m;
            nipples = np;
            typeOfwool = tW;
            }
        public void getInfo2()
        {
            Console.WriteLine($"name of animal {nameOfAnimal2} count of leg {countleg2} wings not or yes {wings2} moloko yes or not {moloko} count of nipples {nipples} type of wool {typeOfwool}");
        }
    }
    class Parnokopitnoe : Mlekopitayushee
    {
        string typeOfFood;
        int pairOfcopita;
    public Parnokopitnoe(string n, int c, bool w, bool m, int np, string tW,string tof,int poc): base (n,c,w,m,np,tW)
        {
            typeOfFood = tof;
            pairOfcopita = poc;
        }
        public void getInfo3()
        {
            Console.WriteLine($"name of animal {nameOfAnimal2} count of leg {countleg2} wings not or yes {wings2} moloko yes or not {moloko2} count of nipples {nipples2} type of wool {typeofwool2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal an = new Animal("Kuriza",2, true );// first object 
            an.getInfo();
            Ptiza pt = new Ptiza("Pinguin", 2, true, "Pinguinovue", false, 4);
            pt.getInfo1();
            Mlekopitayushee ml = new Mlekopitayushee("Korova", 4, false, true, 8, "Мягкая");
               ml.getInfo2();
            Parnokopitnoe po = new Parnokopitnoe("Loshad", 4, false, false, 4, "Жесткая ", "grass", 2);
            po.getInfo3();

        } 
    }
}
