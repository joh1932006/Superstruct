using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSackerlFloor : MonoBehaviour
{
    public GameObject characterSackerl;
    public GameObject mainCharacter;
    public GameObject sackerl;
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
                    characterSackerl.transform.position = mainCharacter.transform.position;
                    characterSackerl.transform.rotation = mainCharacter.transform.rotation;
                    mainCharacter.SetActive(false);
                    characterSackerl.SetActive(true);
                    sackerl.SetActive(false);
                }
            }
        }
    }
}
