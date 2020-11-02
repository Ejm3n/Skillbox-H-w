using System.Collections;
using System.Collections.Generic;
using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Superman : MonoBehaviour
{
    public Rigidbody sup;
    public float speed;
    public float Power;
    void Start()
    {       
        Vector3 Way = new Vector3(0,0,1);
        sup.AddForce(Way.normalized * speed);
    }
    private void OnCollisionExit(Collision collision)
    {        
        if (GetComponent<Rigidbody>() != null && collision.gameObject.tag == "bad") // проверка с нужным ли объектом сталкивается супермен
        {
            Vector3 direction = new Vector3(1,1,-1);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * Power);//отталкивает нужного "врага"
        }
    }
}
//