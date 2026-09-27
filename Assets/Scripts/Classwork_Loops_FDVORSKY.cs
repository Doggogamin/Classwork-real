using UnityEngine;

// L8 - Loops (In-Class Reps)
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
public class Classwork_Loops_FDVORSKY : MonoBehaviour
{
    void Start()
    {
        // ============================================================
        // A1: How Many Times Does the Body Run? (predict, then test)
        // ============================================================
        // 1.
        //     int i = 0;
        //     while (i < 5)
        //     {
        //         i++;
        //     }
        // Answer: <5>
        //
        // 2.
        //     int i = 0;
        //     while (i < 0)
        //     {
        //         i++;
        //     }
        // Answer: <0>
        //
        // 3.
        //     int i = 0;
        //     do
        //     {
        //         i++;
        //     }
        //     while (i < 3);
        // Answer: <3>
        //
        // 4.
        //     for (int i = 0; i < 4; i++)
        //     {
        //     }
        // Answer: <4>
        //
        // 5.
        //     for (int i = 1; i <= 3; i++)
        //     {

        //     }
        // Answer: <3>

        // ============================================================
        // A2: Trace the Final Value
        // ============================================================
        // 6. What is n at the end?
        //     int n = 1;
        //     while (n < 100)
        //     {
        //         n *= 2;
        //     }
        // Answer: <128>
        //
        // 7. What is s at the end?
        //     int s = 0;
        //     for (int i = 1; i <= 4; i++)
        //     {
        //         s += i;
        //     }
        // Answer: <10>

        // ============================================================
        // A3: while, do-while, or for? (answer in a comment)
        // ============================================================
        // 8. Repeat a known number of times.
        // Answer: <for>
        // 9. Ask for a password; they must try at least once.
        // Answer: <do-while>
        // 10. Keep attacking while the enemy has health.
        // Answer: <while>

        // ============================================================
        // A4: break or continue? (answer in a comment)
        // ============================================================
        // 11. Stop searching once you find the item.
        // Answer: <break>
        // 12. Skip enemies that are already dead, keep checking the rest.
        // Answer: <continue>

        // ============================================================
        // A5: Spot the Bug (then write the fix)
        // ============================================================
        // 13. This is meant to print 0 through 4, but it has two problems:
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);

        //}
        //;
        // 14. This is meant to print 0 through 4, but something is missing:
        //     int i = 0;
        //     while (i < 5)
        //    {
        //         Debug.Log(i);
        //    i += 1;
        //     }

        // ============================================================
        // A6: Problem Solving (write the code)
        // ============================================================
        // 15. Use a for loop to print the numbers 1 through 10.
        //for (int i = 1; i < 11; i++)
        //{
        //    Debug.Log(i);
        //}
        // 16. Use a while loop to add up 1 through 100 and print the total.
        //int i = 0;
        //int total = 0;
        //while(i <= 100)
        //{
        //
        //    i++;
        //    total += i;
        //    
        //    if(i == 100)
        //    {
        //        Debug.Log("The Total is "+ total);
        //    }

        //}
        // 17. Loop 1 through 10, but use continue to skip 5 and break at 8.
        //     Which numbers print?
        // Answer: <1,2,3,4,6,7>
        //for(int i = 1; i <=10; i++)
        //{

        //    if (i == 5) 
        //    {
        //        continue;
        //    }

        //    if(i == 8)
        //    {
        //        break;
        //    }
        //    Debug.Log(i);

        //}
        // 18. FIZZBUZZ (1 to 20): print the numbers 1 through 20, but print
        //     "Fizz" if the number is divisible by 3, print "Buzz" if it is
        //     divisible by 5, and print "FizzBuzz" if it is divisible by both
        //     3 and 5.
        //for(int i = 1; i <=20; i++)
        //{
        //if (i % 3 == 0 && i % 5 == 0)
        //  {
        //      Debug.Log("Fizzbuzz");
        //  }
        //  else if (i % 5 == 0)
        //  {
        //      Debug.Log("Buzz");
        //  }
        //  else if (i % 3 == 0)
        //  {
        //      Debug.Log("Fizz");
        //  }
        //  else
        //  {
        //    Debug.Log(i);
        //  }
        //}
        // 19. IS PRIME: given int n (greater than 1), print whether it is
        //     prime. Loop from 2 to n - 1; if any value divides n evenly it is
        //     not prime; use break to stop early.
        //int n = 7;
        //int i = 2;
        //while (i <n)
        //{
        //    
        //    if (n%i==0)
        //    {
        //        Debug.Log(n + " is not prime");
        //        break;
        //    }

            //    Debug.Log(n + " is prime");
            //    i++;
            //}

            // 20. COUNTDOWN: use a for loop to print a countdown from 5 down to 1,
            //     then print "Go!".

            //for(int i = 5; i >=0; i--)
            //{
            //    
            //    if(i < 1)
            //    {
            //       Debug.Log("Go!");
            //    }
            //    else
            //    {
            //        Debug.Log(i);
            //    }
            //}




    }
}
