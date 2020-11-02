using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerScript : MonoBehaviour
{
    float kek = 30f;
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private Text pin1;
    [SerializeField] private Text pin2;
    [SerializeField] private Text pin3;
    [SerializeField] private Text FinalText;
    [SerializeField] private Text TimerText;
    [SerializeField] private Text secret;
    private GameObject currentScreen;
    private int pin1int;
    private int pin2int;
    private int pin3int;
    private float a; 
    private void Start()
    {
        firstScreen.SetActive(true);
        currentScreen = firstScreen;
    }
    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }

    // Update is called once per frame
    void Update()
    {
        kek = kek - (Time.deltaTime);
        a = Mathf.Round(kek);
        TimerText.text = a.ToString();
        pin1int = Int32.Parse(pin1.text);
        pin2int = Int32.Parse(pin2.text);
        pin3int = Int32.Parse(pin3.text);
        if (kek<=0)
        {
            ChangeState(secondScreen);
            FinalText.text = "Вы проиграли";
            kek = 30f;
        }

        else if ((pin1int == pin2int)&&(pin1int== pin3int))
        {
            ChangeState(secondScreen);
            FinalText.text = "Вы победили!";
            kek = 30f;
        }
    }
}
