    using UnityEngine;


namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        // 0. make MakeSound method to virtual method
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        // student code here ...
        // 1. declare overridden MakeSound() method

        // student code ends ...

        public override void MakeSound()
        {
            base.MakeSound();
            Debug.Log("Woof!");
        }
    }

    public class Cat : Animal 
    {
        // student code here ...
        // 2. declare overridden MakeSound() method

        // student code ends ...

        public override void MakeSound()
        {
            Debug.Log("Meaw!");
        }
    }



    public class LCT05VirtualOverride
    {
        public void Start()
        {
            // 3. create instance of Dog and call MakeSound()
            Dog d = new Dog();
            d.MakeSound();

            // 4. create instance of Cat and call MakeSound()
            Dog c = new();
            c.MakeSound();

            // 5. create instance of Animal and call MakeSound()
            Animal a = new();
            a.MakeSound();
        }
    }
}
