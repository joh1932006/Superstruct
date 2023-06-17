using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupBeton : MonoBehaviour
{
    public GameObject characterBeton;
    public GameObject mainCharacter;
    public GameObject beton;
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
                    characterBeton.transform.position = mainCharacter.transform.position;
                    characterBeton.transform.rotation = mainCharacter.transform.rotation;
                    mainCharacter.SetActive(false);
                    characterBeton.SetActive(true);
                    beton.SetActive(false);
                }
            }
        }
    }
}
