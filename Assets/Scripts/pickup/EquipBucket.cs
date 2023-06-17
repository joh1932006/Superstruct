using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipBucket : MonoBehaviour
{
    public GameObject character_bucket;
    public GameObject mainCharacter;
    public GameObject Plane;
    public GameObject Bucket;
    public Vector3 position;



    void Start()
    {

    }
    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (mainCharacter.activeSelf)
                {
                    character_bucket.transform.position = mainCharacter.transform.position;
                    character_bucket.transform.rotation = mainCharacter.transform.rotation;
                    mainCharacter.SetActive(false);
                    Bucket.SetActive(false);
                    character_bucket.SetActive(true);
                }
               


                




            }
        }
    }

}
