using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPickup : MonoBehaviour
{
    public GameObject BucketCharacter;
    public GameObject Bucket_empty;
    public GameObject Bucket_full;
    public GameObject BarrelWater;
    public bool check = false;


    void Update()
    {
        Water();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = false;
        }
    }

    private void Water()
    {
        if (check)
        {
            if (Bucket_empty.activeSelf)
            {
                Bucket_empty.SetActive(false);
                Bucket_full.SetActive(true);
                check = false;
            }
        }
    }
}
