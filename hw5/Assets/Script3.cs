using System;
using System.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class Script3 : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    
    public void onSuperMegaCheckClicked()
    {
        int a = 0;
        int ans = 1;
        a = Int32.Parse(inputField.text);
        for(int i = 1; i<=a; i++)
        {
            ans = ans * i;
        }
        Debug.Log(ans);
    }
}
