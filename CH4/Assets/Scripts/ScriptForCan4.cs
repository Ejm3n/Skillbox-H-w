﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScriptForCan4 : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Text Finaltext;
    [SerializeField] private Image imageCross4;
    [SerializeField] private Sprite imageChekmark4;
    [SerializeField] private Text UrFinaltext;
    private String temp;
    private int plzWork;
    private int value = 36;
    public void onCheckClicked4()
    {
        UrFinaltext.text = inputField.text;
        if (inputField.text.Equals(value.ToString()))
        {
            temp = Finaltext.text;
            plzWork = Int32.Parse(temp);
            plzWork++;
            temp = plzWork.ToString();
            Finaltext.text = temp;
            imageCross4.sprite = imageChekmark4;
        }
    }

}
