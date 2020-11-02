using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballkick : MonoBehaviour
{
    public float Power;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = new Vector3(0, 0, 1);
        GetComponent<Rigidbody>().AddForce(direction.normalized * Power);
    }

    // Update is called once per frame
}
