using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;

public class DropPlank : MonoBehaviour
{
    public GameObject MainCharacter;
    public GameObject breast;
    public GameObject packet1;
    public GameObject packet2;
    public GameObject packet3;
    public GameObject packet4;
    public GameObject PlankCharacter;



    void Start()
    {

    }

    void Update()
    {
        test();
    }



    void test()
    {
        if (PlankCharacter.activeSelf)
        {
            if (Input.GetKey(KeyCode.F))
            {
                if (packet1 != packet1.activeSelf) { packet1.SetActive(true); packet1.transform.position = breast.transform.position; } 
                else if (packet2 != packet2.activeSelf) { packet2.SetActive(true); packet2.transform.position = breast.transform.position; }
                else if (packet3 != packet3.activeSelf) { packet3.SetActive(true); packet3.transform.position = breast.transform.position; }
                else if (packet4 != packet4.activeSelf) { packet4.SetActive(true); packet4.transform.position = breast.transform.position; }

                Vector3 position = PlankCharacter.transform.position;
                Quaternion rotation = PlankCharacter.transform.rotation;
                MainCharacter.transform.position = position;
                MainCharacter.transform.rotation = rotation;
                PlankCharacter.SetActive(false);
                MainCharacter.SetActive(true);
            }
        }
    }
}