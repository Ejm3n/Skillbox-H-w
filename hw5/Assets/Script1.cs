using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Onclick()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }

        }
    }
}
