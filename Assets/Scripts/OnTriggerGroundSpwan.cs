using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerGroundSpwan : MonoBehaviour
{

    [SerializeField] GameObject tempcube;
    [SerializeField] GameObject Ground;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject ground = GroundSpwaner.inst.GetPooledObject();
            if (ground != null)
            {
                ground.transform.position = tempcube.transform.position;
                ground.transform.rotation = tempcube.transform.rotation;
                ground.SetActive(true);
            }

            Debug.Log("Triggered");

            Invoke(nameof(DeletGround), 25f);
        }
    }

    void DeletGround()
    {
        Ground.SetActive(false);
    }
}
