using UnityEngine;
using System.Collections;
using MoreMountains.Tools;
using UnityEngine.PostProcessing;
using MoreMountains.CorgiEngine;

public class CameraMover : MonoBehaviour
{
    Vector3 playerpos;
    public float speed;
    public float timer = 0f;
    Vector3 newpos;
    // Start is called before the first frame update
    void Start()
    {
        playerpos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
       newpos = new Vector3(transform.position.x + speed * Time.deltaTime, playerpos.y, playerpos.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
       
        //if (timer<1f)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position,newpos,timer);
        //    timer += Time.deltaTime;
        //}
        //if(timer>=1f)
        //{
        //    timer = 0f;
        //    newpos = new Vector3(transform.position.x + speed * Time.deltaTime, playerpos.y, playerpos.z);
        //}
        //Debug.Log(LevelManager.Instance.Players[0].transform.position.x);
        //playerpos = new Vector3(LevelManager.Instance.Players[0].transform.position.x, transform.position.y, transform.position.z);
        //transform.position = playerpos;
    }
}
