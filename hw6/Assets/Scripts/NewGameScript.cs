using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class NewGameScript : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private Text pin1Text;
    [SerializeField] private Text pin2Text;
    [SerializeField] private Text pin3Text;
    [SerializeField] private Text TimerText;
    [SerializeField] private Text secret;
    public float a = 0f;
    private GameObject currentScreen;
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
            pin1Text.text = "2";
            pin2Text.text = "5";
            pin3Text.text = "6";
            a = Mathf.Round(Time.time);
            secret.text = a.ToString();
        }
    }
}
