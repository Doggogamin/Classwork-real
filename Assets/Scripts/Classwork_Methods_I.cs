using System.Xml.Linq;
using UnityEngine;
// Methods I
// Work through the TODOs. Attach this to an empty GameObject and press Play to test
// (For "write a method" tasks, add the method to THIS class, below Start.)
public class Classwork_Methods_I : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Does this method take input? Does it return a value?
        // TODO     1. void ShowTitle()
        // Answer:  //Input: No // Value: No
        // TODO     2. int Add(int a, int b)
        // Answer:  //Input: Yes // Value: Yes
        // TODO     3. bool IsEven(int n)
        // Answer:  //Input: Yes // Value: Yes
        // TODO     4. void Heal(int amount)
        // Answer:  //Input: Yes // Value: No

        // TODO A2. Write the CALL for each:
        // TODO     5. call ShowTitle()
        // ShowTitle();
        // TODO     6. call Add with 4 and 9
        // Add(4,9);
        // TODO     7. call Heal with 25
        //Heal(25);
        // TODO     8. store the result of Add(2, 2) in an int called sum
        //int sum = Add(2,2);

        // TODO A3. Predict the output (write your prediction, then test):
        // TODO     9.  void Say() { Debug.Log("hi"); }
        //              then Say(); Say();
        // Answer:  <hi hi>
        // TODO     10. int Twice(int n) { return n * 2; }
        //              Debug.Log(Twice(6));
        // Answer:  <12>

        // TODO A4. Fix the bug, then write the corrected version:
        // TODO     11. int Add(int a, int b) { a + b; }       // missing something
        //int Add(int a, int b) { return a + b; }
        // TODO     12. void Greet(name) { Debug.Log(name); }  // missing something
        // void Greet(string name) { Debug.Log(name); }
        // TODO     13. ShowTitle();                             // how do you call it?
        //ShowTitle();

        // TODO     14. Write  void PrintExits(string exits)  that prints
        //              "Exits: " + exits.
        PrintExits("room");
        // TODO     15. Write  int Square(int n)  that returns n * n.
        Square(5);
        // TODO     16. Write  bool IsLowHealth(int hp)  that returns true when hp < 30.
        IsLowHealth(20);
        // TODO     17. MAX OF TWO: int Max(int a, int b) returns the larger.
        Max(40, 50);
        // TODO     18. GREETER: string Greeting(string name) RETURNS
        //              "Hello, <name>!" (returns it, does not print it).
        Greeting("Flip");
        // TODO     19. IS EVEN: bool IsEven(int n) returns true when n is even.
        IsEven(2);
    }

    // Write your methods for tasks 14-19 here.
    void PrintExits(string exits)
    {
        Debug.Log("Exits: " + exits);
    }
    int Square(int n)
    {
        return n * n;
    }

    bool IsLowHealth(int hp)
    {
        if (hp < 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    string Greeting(string name)
    {
        return "Hello, " + name + "!";
    }
    bool IsEven(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}
