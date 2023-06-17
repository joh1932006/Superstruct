using System;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class ProduceWood : MonoBehaviour
{
    public GameObject Plank;
    public float radius = 3f;
    public int i;
    public GameObject mainCharacter;
    public GameObject Pallet;
    public int Packetcounter;
    public GameObject Bucketcharacter;
    public GameObject axe;
    public GameObject bucket;
    public int clonedPlankcounter = 1;
    public GameObject Plankcharacter;
    public GameObject Axecharacter;

    //Palettenteile
    public GameObject PlankTeil1;
    public GameObject PlankTeil2;
    public GameObject PlankTeil3;

    public GameObject Packet1; //Palette1
    public GameObject Packet2; //Palette1
    public GameObject Packet3; //Palette2
    public GameObject Packet4; //Palette2

    private ProduceWood clonedPlanks;
    public int GetSharedVariable()
    {
        return clonedPlankcounter;
    }

    public void SetSharedVariable(int value)
    {
        clonedPlankcounter = value;
    }

    void Start()
    {
        clonedPlanks = FindObjectOfType<ProduceWood>();
        InvokeRepeating("Spawn", 3f, 3f);
    }

    void Update()
    {
        int value = clonedPlanks.GetSharedVariable();
        clonedPlanks.SetSharedVariable(clonedPlankcounter);
        if (mainCharacter.activeSelf)
        {
            Plankcharacter.transform.position = mainCharacter.transform.position;
            Plankcharacter.transform.rotation = mainCharacter.transform.rotation;
        }
    }


    public void Spawn()
    {
        float distance = Vector3.Distance(transform.position, Axecharacter.transform.position);

        if (gameObject == Axecharacter.activeInHierarchy)
        {
            if (distance <= radius && Pallet.activeSelf)
            {
                AddPartToPacket();
            }
        }
    }

    public void AddPartToPacket()
    {
        if (clonedPlankcounter <= 3)
        {
            GameObject newPart = Instantiate(Plank, Packet1.transform); // Instanziere ein neues Teil und setze es als Kind des aktuellen Empty Objects
            newPart.SetActive(true); //clonedPlan spawnt

            newPart.transform.position = Plank.transform.position;
            newPart.transform.rotation = Plank.transform.rotation;


            Plank.transform.position += new Vector3(0f, 0.2f, 0f); //Plank jedes mal wenn eine abgebaut wird um 0.1f nach oben

            clonedPlankcounter++; // Erhöhe den Zähler für die Teile
            newPart.name = Plank.name + " (" + i + ")";
        }
        else if (clonedPlankcounter > 3 && clonedPlankcounter < 6)
        {
            GameObject newPart = Instantiate(Plank, Packet2.transform); // Instanziere ein neues Teil und setze es als Kind des aktuellen Empty Objects
            newPart.SetActive(true); //clonedPlan spawnt

            newPart.transform.position = Plank.transform.position;
            newPart.transform.rotation = Plank.transform.rotation;


            Plank.transform.position += new Vector3(0f, 0.2f, 0f); //Plank jedes mal wenn eine abgebaut wird um 0.1f nach oben

            clonedPlankcounter++; // Erhöhe den Zähler für die Teile
            newPart.name = Plank.name + " (" + i + ")";
        }
        else if (clonedPlankcounter >= 6)
        {
            GameObject newPart = Instantiate(Plank, Packet3.transform); // Instanziere ein neues Teil und setze es als Kind des aktuellen Empty Objects
            newPart.SetActive(true); //clonedPlan spawnt

            newPart.transform.rotation = Plank.transform.rotation;
            newPart.transform.position = Plank.transform.position;

            Plank.transform.position += new Vector3(0f, 0.2f, 0f); //Plank jedes mal wenn eine abgebaut wird um 0.1f nach oben

            clonedPlankcounter++; // Erhöhe den Zähler für die Teile
            newPart.name = Plank.name + " (" + i + ")";
        }
        else if (clonedPlankcounter >= 9)
        {
            GameObject newPart = Instantiate(Plank, Packet4.transform); // Instanziere ein neues Teil und setze es als Kind des aktuellen Empty Objects
            newPart.SetActive(true); //clonedPlan spawnt

            newPart.transform.rotation = Plank.transform.rotation;
            newPart.transform.position = Plank.transform.position;

            Plank.transform.position += new Vector3(0f, 0.2f, 0f); //Plank jedes mal wenn eine abgebaut wird um 0.1f nach oben

            clonedPlankcounter++; // Erhöhe den Zähler für die Teile
            newPart.name = Plank.name + " (" + i + ")";
        }
        #region Palette abbauen
        if (i == 1)
        {
            PlankTeil1.SetActive(false);
        }
        else if (i == 2)
        {
            PlankTeil2.SetActive(false);
        }
        else if (i == 3)
        {
            PlankTeil3.SetActive(false);
        }

        else if (i == 4)
        {
            Pallet.SetActive(false);
        }
        i++;
        #endregion
    }
}