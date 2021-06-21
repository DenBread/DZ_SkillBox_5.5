using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    private void Start()
    {
        Multiplication_table();

    }

    private void Multiplication_table()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log(i * j);
            }
        }
    }
}
