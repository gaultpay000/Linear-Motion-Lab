namespace Linear_Motion
{
//created by Payton Gaultney on 08/27/2026, Math and Physics for Games.
/*
     The main functionality of this lab is sampling the motion of a ball using the Euler methodoligies, having a starting
     position and factoring in the acceleration due to gravity, and taking in an initial velocity from the user, this lab 
     will show a hypothetical for where the ball landed,  how far it moved, and various unit directions and magnitudes 
     based on the labs results.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //starting constant vectors that won't change (came from the lab)
            Vector3D acceleration = new Vector3D(0f, 0f, -9.8f);
            Vector3D startingPosition = new Vector3D(0f, 0f, 2f);

            // user input for the x y and z variables for the user vector

            Console.WriteLine("Input  x, y, z.");
            float userX = float.Parse(Console.ReadLine());

            float userY = float.Parse(Console.ReadLine());

            float userZ = float.Parse(Console.ReadLine());

            Console.WriteLine("Input time step.");
            Vector3D userVector = new Vector3D(userX, userY, userZ);//makes the user vector

            float deltaT = float.Parse(Console.ReadLine());// the time that will pass each itteration of the loop

            Vector3D unitDirection = ~userVector;//calculates the unit direction of the initial user vector
            Console.WriteLine();
            Console.WriteLine($"Initial Unit Direction: {unitDirection.PrintRect()}"); //prints the unit direction of the initial user vector

            //variables for the while loop
            float timeElapsed = 0;//time elapsed looks at how many times the while loop runs
            Vector3D r = startingPosition;//r is the position

            while (r.getZ() >= 0)//runs while the z position (height) is greater than zero
            {
                //these are the Euler Motion equations that produce the "moving ball"
                r = r + userVector * deltaT;// new poisition = old position + old velocity * change in time
                userVector = userVector + acceleration * deltaT; // new velocity = old velocity + acceleration * change in time

                timeElapsed += deltaT;//tracks time
            }

            Vector3D final = r - startingPosition;//holds the raw final displacement vector
            Vector3D finalUnitDirection = ~final;//holds the unit direction of the displacement of the ball

            Console.WriteLine();//little bit of extra space to differentiate the before and after
            Console.WriteLine($"Time Elapsed: {timeElapsed}s");//prints total time elapsed
            Console.WriteLine($"Ball Landing Position: {r.PrintRect()}m");// prints final position of the ball
            Console.WriteLine($"Unit Direction of the Displacement: {finalUnitDirection.PrintRect()}");//prints the unit direction of the displacement
            Console.WriteLine($"Magnitude: {final.GetMag()}m/s, and Magnitude squared: {final.GetMagSq()}m/s, Of Displacement");//prints the magnitude of the displacement
        }
    }
}
