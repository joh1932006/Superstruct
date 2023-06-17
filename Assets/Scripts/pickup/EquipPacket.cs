using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EquipPacket : MonoBehaviour
{

    public GameObject mainCharacter;
    
   
    public GameObject packet;
    public int counter;

    public GameObject Plankcharacter1;
    public GameObject Plankcharacter2;
    public GameObject Plankcharacter3;

    

    void Start()
    {
        
    }
    void Update()
    {
        counter = packet.transform.childCount;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (counter == 1)
                {
                    if (mainCharacter.activeSelf)
                    {
                        Plankcharacter1.transform.position = mainCharacter.transform.position;
                        Plankcharacter1.transform.rotation = mainCharacter.transform.rotation;
                        mainCharacter.SetActive(false);
                        Plankcharacter1.SetActive(true);
                        packet.SetActive(false);
                    }
                }
                if (counter == 2)
                {
                    if (mainCharacter.activeSelf)
                    {
                        Plankcharacter2.transform.position = mainCharacter.transform.position;
                        Plankcharacter2.transform.rotation = mainCharacter.transform.rotation;
                        mainCharacter.SetActive(false);
                        Plankcharacter2.SetActive(true);
                        packet.SetActive(false);
                    }
                }
                else if (counter == 3)
                {
                    if (mainCharacter.activeSelf)
                    {
                        Plankcharacter3.transform.position = mainCharacter.transform.position;
                        Plankcharacter3.transform.rotation = mainCharacter.transform.rotation;
                        mainCharacter.SetActive(false);
                        Plankcharacter3.SetActive(true);
                        packet.SetActive(false);
                    }
                }
            }
        }
    }
}
