using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScriptForCan2 : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Text Finaltext;
    [SerializeField] private Image imageCross2;
    [SerializeField] private Sprite imageChekmark2;
    [SerializeField] private Text UrFinaltext;
    private String temp;
    private int plzWork;
    private int value = 6;
    public void onCheckClicked2()
    {
        UrFinaltext.text = inputField.text;
        if (inputField.text.Equals(value.ToString()))
        {
            temp = Finaltext.text;
            plzWork = Int32.Parse(temp);
            plzWork++;
            temp = plzWork.ToString();
            Finaltext.text = temp;
            imageCross2.sprite = imageChekmark2;
        }
    }

}
