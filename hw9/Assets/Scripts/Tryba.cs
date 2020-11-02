using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tryba : MonoBehaviour
{
    public float prozrachnost;
    // Start is called before the first frame update
    void Start()
    {

        var renderer = gameObject.GetComponent<Renderer>();
        renderer.material.shader = Shader.Find("Transparent/Diffuse");
        renderer.material.color = Color.white * prozrachnost; // меням цвет на белый с 25% не прозрачности
    }

    // Update is called once per frame
}
