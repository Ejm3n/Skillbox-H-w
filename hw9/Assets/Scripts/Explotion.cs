using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{
    public float TimeToExplotion;
    public float Power;
    public float Radius;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        TimeToExplotion -= Time.deltaTime;
        if (TimeToExplotion <= 0)
        {
            boom();
        }
    }
    void boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody B in blocks)
        {
            if(Vector3.Distance(transform.position,B.transform.position)<Radius)
            {
                Vector3 direction = B.transform.position - transform.position;
                B.AddForce(direction.normalized * Power * (Radius - Vector3.Distance(transform.position, B.transform.position)),ForceMode.Impulse);
            }
        }
        TimeToExplotion = 3;
    }
}
