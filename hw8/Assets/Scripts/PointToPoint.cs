using UnityEngine;

public class PointToPoint : MonoBehaviour
{
    public Vector3[] target = new Vector3[5];
    //public Transform transform;
    public int index;
    public bool forward;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        forward = true;
        index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 4) 
        {
            forward = false;
           
        }
        else if (transform.position != target[index + 1] && forward)
        {
            transform.position = Vector3.MoveTowards(transform.position, target[index + 1], speed * Time.deltaTime);
        }
        else if (transform.position == target[index+1])
        {
            index++;
        }
        if (index == 0) 
        {
            forward = true;
        }
        else if (transform.position != target[index - 1] && !forward)
        {
            transform.position = Vector3.MoveTowards(transform.position, target[index - 1], speed * Time.deltaTime);
        }
        else if (transform.position == target[index -1])
        {
            index--;
        }
    }
}
