using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{

    public float speed;
    public float endY;
    public float startY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if(transform.position.y <= endY)
        {
            Vector3 pos = new Vector3(transform.position.x, startY, transform.position.z);
            transform.position = pos;
        }
    }
}
