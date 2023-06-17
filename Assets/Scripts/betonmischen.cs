using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class betonmischen : MonoBehaviour
{

    public GameObject WaterBucketCharacter;
    public GameObject bucket_full;
    public GameObject SCharacter;
    private GameObject character;
    public GameObject MainCharacter;
    public GameObject BetonCharacter;
    public GameObject bucket;
    public int counterW;
    public int counterS;
    public bool check;

    // Update is called once per frame
    void Update()
    {
        Beton();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && SCharacter.activeSelf)
        {
            check = true;
            character = collision.gameObject;
        }
        if (collision.gameObject.tag == "Player" && bucket_full.activeSelf)
        {
            check = true;
            character = collision.gameObject;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && (SCharacter.activeSelf || WaterBucketCharacter.activeSelf))
        {
            check = false;
        }
    }

    private void Beton()
    {
        if (check)
        {
            if (Input.GetKey(KeyCode.E) && character == WaterBucketCharacter && counterW <= 1)
            {
                //bucket.transform.position = WaterBucketCharacter.transform.position;
                //bucket.transform.rotation = WaterBucketCharacter.transform.rotation;


                counterW++;
                MainCharacter.transform.position = WaterBucketCharacter.transform.position;
                MainCharacter.transform.rotation = WaterBucketCharacter.transform.rotation;
                MainCharacter.SetActive(true);
                WaterBucketCharacter.SetActive(false);
                bucket.SetActive(true);

                if (counterS == 2)
                {
                    BetonCharacter.transform.position = MainCharacter.transform.position;
                    BetonCharacter.transform.rotation = MainCharacter.transform.rotation;
                    MainCharacter.SetActive(false);
                    BetonCharacter.SetActive(true);
                }
            }
            if (Input.GetKey(KeyCode.E) && character == SCharacter && counterS <= 1)
            {
                counterS++;
                MainCharacter.transform.position = SCharacter.transform.position;
                MainCharacter.transform.rotation = SCharacter.transform.rotation;
                MainCharacter.SetActive(true);
                SCharacter.SetActive(false);
                if (counterW == 2)
                {
                    BetonCharacter.transform.position = MainCharacter.transform.position;
                    BetonCharacter.transform.rotation = MainCharacter.transform.rotation;
                    MainCharacter.SetActive(false);
                    BetonCharacter.SetActive(true);
                }
            }
        }
    }
}
