using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockinstantiate : MonoBehaviour
{
    public GameObject[] platforms;
    float randomizetime;
    float xmax;
    float ymin;
    float ymax;
    // Start is called before the first frame update
    void Start()
    {
        //insatntiae coins
        InvokeRepeating("blocksinstantiating",5f,Random.Range(8f,15f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void blocksinstantiating()
    {
        
        Vector3 inspos = Camera.main.ViewportToWorldPoint(new Vector3(1.3f,Random.Range(0.2f,0.5f),10f));
        GameObject platformins = Instantiate(platforms[Random.Range(0,platforms.Length)], inspos, Quaternion.identity);
    }
}
