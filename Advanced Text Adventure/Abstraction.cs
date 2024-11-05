using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
    
    }

    //Players is the broad class for all the specific classes like Benicio and Piper
    // 'abstract' makes it so you can't use it but it can still be used to add things that go to all individuals of the class so you don't have to add it to every class
    public abstract class Players
    {
        public int age;
        public (float r, float g, float b) hairColor;
        public string name;
         
        
        //"protected" means anything in the class or connected to the class has access to it
        //unlike private where it's only availible in that class or public where it is availble anywhere
        //protected int example;
    }
    
    //added Players to Benicio so it is conected to the Players class
    //So anything with ": Players" anything in the Players class goes to all with that Players thing
    public class Benicio : Players 
    {

    public float brainPower;

    }
    
    public class  Thomas : Players
    {

    public float SSJscale;

    }
    
    public class Cayden : Players
    {

    public float mafiaBossScale;

    }

    public class Braden : Players
    {

    public float basicScale;

    }
     public class Jaden : Players
    {

    public float fatScale;

    }
    public class Ruth : Players
    {

    public float stupidLevel;

    }

    public class Maliyah : Players
    {
    public float evilTyrant;
    }
     public class Alex : Players
    {
    public float fakeQueer;
    }
     public class Piper : Players
    {
    public float obsessive;
    }
    
    
    internal class Abstraction
    {
        static void Main(string[] args)
        {
            Benicio benicio = new() {age = 17, name = ("Benicio also known as Joe Biden"), hairColor = (0, 0, 0) };
            Thomas thomas = new() { age = 18, name = ("Thomas also known as the creature >:) "), hairColor = (0, 0, 0) };
            Cayden cayden = new() { age = 17, name = ("Cayden 🤓"), hairColor = (0, 0, 0) };
            Jaden jaden = new() { age = 17, name = ("Jaden also known as nerdbob"), hairColor = (196, 164, 132) };
            Braden braden = new() { age = 17, name = ("ඞ"), hairColor = (196, 164, 132) };
            Ruth ruth = new() { age = 17, name = ("Ruth also known as BrothBones☠︎"), hairColor = (92, 64, 51) };
            Piper piper = new() { age = 17 , name = ("Piper also known as Grim"), hairColor = (0, 0, 0) };
            Maliyah maliyah = new() { age = 17 , name = ("Maliyah also known as Lord Megatron"), hairColor = (92, 64, 51) };
            Alex alex = new() { age = 17, name = ("Alex eight handled sword divergent sila divine general mahoraga"), hairColor = (223, 195, 147)};

        List<Players> players = [benicio, thomas, cayden, jaden, braden, ruth, piper, maliyah, alex];
            
            //foreach (Players animal in animals)
            //{
            //    animal.Speak();
            //}
            
            

            
        }
    }

