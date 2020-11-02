using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScriptForCan5 : MonoBehaviour
{
    [SerializeField] private Text Finaltext;
    [SerializeField] private Image imageCross5;
    [SerializeField] private Sprite imageChekmark5;
    [SerializeField] private Text UrFinaltext;
    [SerializeField] private Text Buttontext;
    private String temp;
    private int plzWork;
    public void onCheckClicked5()
    {
        UrFinaltext.text = Buttontext.text;
        temp = Finaltext.text;
        plzWork = Int32.Parse(temp);
        plzWork++;
        temp = plzWork.ToString();
        Finaltext.text = temp;
        imageCross5.sprite = imageChekmark5;
    }
}
