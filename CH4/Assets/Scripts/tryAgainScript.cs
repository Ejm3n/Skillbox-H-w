using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class tryAgainScript : MonoBehaviour
{
    [SerializeField] private Text Finaltext;
    [SerializeField] private Image imageCheckmark;
    [SerializeField] private Sprite SpriteCross;
    [SerializeField] private Image imageCheckmark1;    
    [SerializeField] private Image imageCheckmark2;    
    [SerializeField] private Image imageCheckmark3;    
    [SerializeField] private Image imageCheckmark4;   
    [SerializeField] private Image imageCheckmark5;    
    [SerializeField] private Image imageCheckmark6;    
    [SerializeField] private Image imageCheckmark7;    
    [SerializeField] private Image imageCheckmark8;
    [SerializeField] private Image imageCheckmark9;
    private String temp = "0";
    private int plzWork;
    public void onClickAgain()
    {
        Finaltext.text = temp;
        imageCheckmark.sprite = SpriteCross;
        imageCheckmark1.sprite = SpriteCross;
        imageCheckmark2.sprite = SpriteCross;
        imageCheckmark3.sprite = SpriteCross;
        imageCheckmark4.sprite = SpriteCross;
        imageCheckmark5.sprite = SpriteCross;
        imageCheckmark6.sprite = SpriteCross;
        imageCheckmark7.sprite = SpriteCross;
        imageCheckmark8.sprite = SpriteCross;
        imageCheckmark9.sprite = SpriteCross;
    }
}
