using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sackerlDrop : MonoBehaviour
{
    public GameObject mainCharacter;
    public GameObject sackerlCharacter;
    public GameObject sackerl;

    void Start()
    {

    }

    void Update()
    {
        test();
    }



    void test()
    {
        if (sackerlCharacter.activeSelf)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Vector3 position = sackerlCharacter.transform.position;
                mainCharacter.transform.position = position;
                sackerl.transform.position = sackerlCharacter.transform.position;
                mainCharacter.SetActive(true);
                sackerlCharacter.SetActive(false);
                sackerl.SetActive(true);
            }
        }

    }
}
