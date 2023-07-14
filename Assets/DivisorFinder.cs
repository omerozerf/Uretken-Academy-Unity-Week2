using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisorFinder : MonoBehaviour
{
    private void Start()
    {
        DivisorFind(5, 15);
    }


    private void DivisorFind(int numberOne, int numberTwo)
    {
        
        string output = "All list -> ";
        for (int i = numberOne; i <= numberTwo; i++)
        {
            output += i.ToString() + " ";
        }
        print(output);
        
        
        string outputTwo = "Numbers divisible by two -> ";
        for (int i = numberOne; i <= numberTwo; i++)
        {
            if (i % 2 == 0)
            {
                outputTwo += i.ToString() + " ";
            }
        }
        print(outputTwo);
        
        
        string outputThree = "Numbers divisible by three -> ";
        for (int i = numberOne; i <= numberTwo; i++)
        {
            if (i % 3 == 0)
            {
                outputThree += i.ToString() + " ";
            }
        }
        print(outputThree);
        
        
        string outputFour = "Numbers divisible by four -> ";
        for (int i = numberOne; i <= numberTwo; i++)
        {
            if (i % 4 == 0)
            {
                outputFour += i.ToString() + " ";
            }
        }
        print(outputFour);
        
        
        string outputFive = "Numbers divisible by five -> ";
        for (int i = numberOne; i <= numberTwo; i++)
        {
            if (i % 5 == 0)
            {
                outputFive += i.ToString() + " ";
            }
        }
        print(outputFive);
    }
}
