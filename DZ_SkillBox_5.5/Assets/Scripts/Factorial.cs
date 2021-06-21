using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Fact(5));
    }

    public static long Fact(long n)
    {
        if (n == 0)
            return 1;
        else
            return n * Fact(n - 1);
    }
}
