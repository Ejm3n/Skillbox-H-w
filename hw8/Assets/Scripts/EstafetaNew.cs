using UnityEngine;

public class EstafetaNew : MonoBehaviour
{
    public Transform[] ppl = new Transform[6];
    public Transform[] Hand = new Transform[6];
    public Transform Stick;
    public int currentindex;
    public bool forward = true;
    public float speed;
    void Start()
    {
        currentindex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentindex == 5 && forward)//проверка дошел ли цикл до конца чтоб развернуть бегунов
        {
            forward = false;
            currentindex--;
        }
        if(currentindex == 0 && !forward)//проверка дошел ли цикл до конца чтоб развернуть бегунов
        {
            forward = true;
        }
        if (ppl[currentindex].transform.position != ppl[currentindex + 1].transform.position && forward)//движение бегунов
        {
            ppl[currentindex].transform.position = Vector3.MoveTowards(ppl[currentindex].transform.position, ppl[currentindex + 1].transform.position, Time.deltaTime * speed);
            Stick.transform.position = Vector3.MoveTowards(Hand[currentindex].transform.position, ppl[currentindex + 1].transform.position, Time.deltaTime * speed);
        }
        else if (ppl[currentindex].transform.position == ppl[currentindex + 1].transform.position && forward)
            currentindex++;
        if(!forward)
        {
            if (ppl[currentindex].transform.position != ppl[currentindex - 1].transform.position)
            {
                ppl[currentindex].transform.position = Vector3.MoveTowards(ppl[currentindex].transform.position, ppl[currentindex - 1].transform.position, Time.deltaTime * speed);
                Stick.transform.position = Vector3.MoveTowards(Hand[currentindex].transform.position, ppl[currentindex - 1].transform.position, Time.deltaTime * speed);
            }
            else if (ppl[currentindex].transform.position == ppl[currentindex - 1].transform.position)
                currentindex--;
        }
        
    }
}
