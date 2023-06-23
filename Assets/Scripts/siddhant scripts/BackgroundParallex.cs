using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallex : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallexEffect;
    void Start()
    {
        transform.position = new Vector3(Camera.main.transform.position.x, transform.position.y,20f);
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void LateUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallexEffect));
        float dist = (cam.transform.position.x * parallexEffect);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        if (temp > (startpos + length/2))
        { startpos += length;
            
        }
        else if (temp < startpos - length/2)
        { startpos -= length;
          
        }

    }
}