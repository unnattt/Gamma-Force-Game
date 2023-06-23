using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroller : MonoBehaviour
{
    public Renderer bgRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(Time.deltaTime*0.2f,0f);
    }
}
