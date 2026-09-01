using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public string Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Car is moving");  
        }

        public void turn()
        {
            Debug.Log("Car is turngin");    
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            
            Car car1 = new Car();
            car1.Name = "Lamborgini";
            Debug.Log(car1.Name);
            car1.Move();
            car1.turn();


            Car car2 = new();
            car2.Name = "TOYOTA";
            Debug.Log(car2.Name);
            // Student code ends HERE 
        }
    }
}
