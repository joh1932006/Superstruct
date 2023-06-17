using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSackerl : MonoBehaviour
{
    public GameObject SackerlCharacter;
    public GameObject MainCharacter;
    public GameObject Beton;
    public bool check = false;


    void Update()
    {
        Water();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && MainCharacter.activeSelf)
        {
            check = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && MainCharacter.activeSelf)
        {
            check = false;
        }
    }

    private void Water()
    {
        if (check)
        {
            if (Input.GetKey(KeyCode.E))
            {
                SackerlCharacter.transform.position = MainCharacter.transform.position;
                SackerlCharacter.transform.rotation = MainCharacter.transform.rotation;
                MainCharacter.SetActive(false);
                SackerlCharacter.SetActive(true);
                check = false;
            }
        }
    }
}
