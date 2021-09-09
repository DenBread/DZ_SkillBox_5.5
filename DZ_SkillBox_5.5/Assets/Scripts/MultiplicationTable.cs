using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplicationTable : MonoBehaviour
{
    [SerializeField] private Text[] textUI;

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
                textUI[j].text = (i * j).ToString();
            }
        }
    }
}
