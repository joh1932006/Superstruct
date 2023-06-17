using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject character_AxeOn;
    public GameObject mainCharacter;
    public GameObject Axe;
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
                    character_AxeOn.transform.position = mainCharacter.transform.position;
                    character_AxeOn.transform.rotation = mainCharacter.transform.rotation;
                    mainCharacter.SetActive(false);
                    character_AxeOn.SetActive(true);
                    Axe.SetActive(false);
                }





                
            }
        }
    }

}
