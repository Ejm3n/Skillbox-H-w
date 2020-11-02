using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class WrongButtonScript : MonoBehaviour
{
    [SerializeField] private Text UrFinaltext;
    [SerializeField] private Text Buttontext;
    public void onCheckClicked5()
    {
        UrFinaltext.text = Buttontext.text;
    }
}