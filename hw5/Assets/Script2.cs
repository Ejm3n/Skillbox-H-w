using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    int[,] tablica = new int[10, 10];
    int count = 0;
    int a = 0;
    int b = 0;
    public void OnMegaClick()
    {
        for(int i = 1; i<=10; i++)
        {
            for(int k = 1; k<=10;k++)
            {
                count = i * k;
                Debug.Log($"{i} * {k} = {count}");
            }
        }
    }
}
