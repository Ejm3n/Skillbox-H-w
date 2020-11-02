using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estafeta : MonoBehaviour
{
    public Transform[] ppl = new Transform[7];
    public Transform Stick;
    public Transform[] Hand = new Transform[7];
    public bool go;
    public bool forward;
    private Vector3[] target = new Vector3[8];
    public float speed;
    public int i;
    void Start()
    {
        i = 0;
        for(i=1;i<6;i++)
        {
            target[i] = ppl[i].transform.position + new Vector3(0, 0, -9);
        }
        forward = true;
        target[0] = ppl[0].transform.position;
        target[6] = new Vector3(1.2f, 7.82f, 280.1f);
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (go && forward)
        {
            ppl[i].transform.position = Vector3.MoveTowards(ppl[i].transform.position, target[i+1], Time.deltaTime * speed);
            Stick.transform.position = Vector3.MoveTowards(Hand[i].transform.position, target[i+1], Time.deltaTime * speed);
            transform.position = Vector3.MoveTowards(transform.position, target[i+1], Time.deltaTime * speed);
        }
        if (go && !forward)
        {       
            ppl[i].transform.position = Vector3.MoveTowards(ppl[i].transform.position, target[i] + new Vector3(0,0,9), Time.deltaTime * speed);
            Stick.transform.position = Vector3.MoveTowards(Hand[i].transform.position, target[i] + new Vector3(0, 0, 9), Time.deltaTime * speed);
            transform.position = Vector3.MoveTowards(transform.position, target[i] + new Vector3(0, 0, 9), Time.deltaTime * speed);
        }
        if(forward && ppl[i].transform.position == target[i+1])
        {
            Debug.Log("ДОШЛО");
            if(i!=6)
                i++;
            else
            {
                forward = false;
            }
        }
        if (!forward && ppl[i].transform.position == target[i] + new Vector3(0, 0, 9))
        {
            Debug.Log("sdfhgsgstegesgesgseg");
            if (i!= 0)
                i--;
            else
            {
                forward = true;
            }
        }
    }

    
}
