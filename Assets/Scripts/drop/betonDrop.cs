using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betonDrop : MonoBehaviour
{
    public GameObject mainCharacter;
    public GameObject betonCharacter;
    public GameObject beton;

    void Start()
    {

    }

    void Update()
    {
        test();
    }



    void test()
    {
        if (betonCharacter.activeSelf)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Vector3 position = betonCharacter.transform.position;
                mainCharacter.transform.position = position;
                beton.transform.position = betonCharacter.transform.position;
                mainCharacter.SetActive(true);
                betonCharacter.SetActive(false);
                beton.SetActive(true);
            }
        }

    }
}
