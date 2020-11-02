using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class ForTool : MonoBehaviour
{
    
        [SerializeField] private int ChangePin1;
        [SerializeField] private int ChangePin2;
        [SerializeField] private int ChangePin3;
        [SerializeField] private Text pin1Text;
        [SerializeField] private Text pin2Text;
        [SerializeField] private Text pin3Text;
        private int pin1;
        private int pin2;
        private int pin3;
        public void OnClick()
        {
            //ChangePin1 = 2;
            //ChangePin2 = -1;
            //ChangePin3 = -1;
            pin1 = Int32.Parse(pin1Text.text);
            pin2 = Int32.Parse(pin2Text.text);
            pin3 = Int32.Parse(pin3Text.text);
            pin1 += ChangePin1;
            pin2 += ChangePin2;
            pin3 += ChangePin3;
            float a = Mathf.Clamp(pin1, 0, 10);
            float b = Mathf.Clamp(pin2, 0, 10);
            float c = Mathf.Clamp(pin3, 0, 10);
            pin1Text.text = a.ToString();
            pin2Text.text = b.ToString();
            pin3Text.text = c.ToString();
        }
    }
