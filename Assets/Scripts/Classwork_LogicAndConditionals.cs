using UnityEngine;

// L7 - Comparison, Logic & Conditionals (In-Class Reps)
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
public class L7_Logic_Conditionals_Reps_FDVORSKY : MonoBehaviour
{
    void Start()
    {
        // ============================================================
        // A1: True or False (answer in a comment)
        // ============================================================
        // 1. 5 == 5
        // Answer: <True>
        // 2. 5 != 5
        // Answer: <False>
        // 3. 7 > 3
        // Answer: <True>
        // 4. 7 < 3
        // Answer: <False>
        // 5. 4 >= 4
        // Answer: <True>
        // 6. 6 <= 2
        // Answer: <False>

        // ============================================================
        // A2: Evaluate the Logic (write the result)
        // ============================================================
        // 7. true && false
        // Answer: <False>
        // 8. false || true
        // Answer: <True>
        // 9. !true
        // Answer: <False>
        // 10. (2 > 1) && (3 > 2)
        // Answer: <True>

        // These values are shared by A3, A5 and A6 below.
        int health = 20;
        int gold = 100;
        bool hasKey = true;

        // ============================================================
        // A3: Scenario - True or False (health = 20, gold = 100, hasKey = true)
        // ============================================================
        // 11. health < 30
        // Answer: <True>
        // 12. hasKey && health > 50
        // Answer: <False>
        // 13. !hasKey
        // Answer: <False>
        // 14. gold >= 100 || hasKey
        // Answer: <True>

        // ============================================================
        // A4: Predict What Prints (write your prediction, then test)
        // ============================================================
        // 15.
        //     int h = 0;
        //     if (h <= 0)
        //     {
        //         Debug.Log("dead");
        //     }
        //     else
        //     {
        //         Debug.Log("alive");
        //     }
        // Answer: <dead>
        //
        // 16.
        //     int s = 75;
        //     if (s >= 90)
        //     {
        //         Debug.Log("A");
        //     }
        //     else if (s >= 70)
        //     {
        //         Debug.Log("C");
        //     }
        //     else
        //     {
        //         Debug.Log("F");
        //     }
        // Answer: <C>

        // ============================================================
        // A5: Fix the Bug (write the corrected code)
        // ============================================================
        // 17. This should print "dead" when health is 0, but it has a bug:
        //     if (health == 0) //Changed Health = 0 to Health == 0
        //     {
        //         Debug.Log("dead");
        //     }

        // 18. Both calls are meant to run only when hasKey is true,
        //     but right now only the first one is:
        //     if (hasKey) //Added "{}"
        // {
        //    Open();
        //    Enter();
        //}


        // ============================================================
        // A6: Problem Solving (write the code)
        // ============================================================
        // 19. Make ONE boolean called canOpenVault that is true only when
        //     hasKey is true AND health is greater than 0.
        //if (hasKey && health > 0)
        //{
        //    bool canOpenVault = true;
        //    Debug.Log(canOpenVault);
        //}
        // 20. Using the health above, write an if / else-if / else that prints
        //     "Dead" when health <= 0, "Low" when health < 30, otherwise "Fine".
        //if (health <= 0)
        //{
        //    Debug.Log("Dead");
        //}
        //else if (health < 30)
        //{
        //    Debug.Log("Low");
        //}

        //else
        //{
        //    Debug.Log("Fine");
        //}







        // 21. Apply a trap (health -= 50), then clamp health so it never goes
        //     below 0.
        //if(health > 50)
        //{
        //    health -= 50;
        //    Debug.Log("You took 50 damage from a trap you now have " + health + " health remaining");
        //}
        //else
        //{
        //    int trap = health - 1;
        //    health -= trap;

        //    Debug.Log("You took " + trap +  " damage from a trap you now have " + health + " health remaining");
        //}
        // 22. LETTER GRADE: given int score (for example 75), print A, B, C, D
        //     or F using the 90 / 80 / 70 / 60 cutoffs.
        //int score = 50;
        //if (score >= 90)
        //{
        //    Debug.Log("A");
        //}
        //else if (score >= 80)
        //{
        //    Debug.Log("B");
        //}
        //else if (score >= 70)
        //{
        //    Debug.Log("C");
        //}
        //else if (score >= 60)
        //{
        //    Debug.Log("D");
        //}
        //else
        //{
        //    Debug.Log("F");
        //}
        // 23. LEAP YEAR: given int year, print whether it is a leap year.
        //     A year is a leap year when it is divisible by 4, except that
        //     century years must also be divisible by 400.
        //int year = 2001;
        //if (year % 4 == 0 || (year % 4 == 0 && year % 400 == 0))
        //{
        //    Debug.Log("Leap Year");
        //}
        //else
        //{
        //    Debug.Log("Normal Year");
        //}

        // 24. FIZZBUZZ (one number): given int n, print "Fizz" if it is
        //     divisible by 3, print "Buzz" if it is divisible by 5, print
        //     "FizzBuzz" if it is divisible by both 3 and 5, otherwise print
        //     the number itself.


        //int n = 30;
        //  if (n % 3 == 0 && n % 5 == 0)
        //  {
        //      Debug.Log("Fizzbuzz");
        //  }
        //  else if (n % 5 == 0)
        //  {
        //      Debug.Log("Buzz");
        //  }
        //  else if (n % 3 == 0)
        //  {
        //      Debug.Log("Fizz");
        //  }
        //  else
        //  {
        //    Debug.Log(n);
        //  }
      




    }
}
