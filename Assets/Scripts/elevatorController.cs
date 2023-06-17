using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elevatorController : MonoBehaviour
{
    public float speed = 0.1f; // Geschwindigkeit, mit der sich der Aufzug bewegt

    public int requiredBeton = 1; // Die Anzahl der erforderlichen Ressourcen zum Auslösen des Aufzugs
    public int requiredPlanks = 1;
    private int collectedBeton = 0; // Die Anzahl der gesammelten Ressourcen
    private int collectedPlanks = 0;
    private bool isMoving = false; // Überprüfung, ob der Aufzug sich gerade bewegt
    private Vector3 targetPosition; // Zielposition des Aufzugs
    private bool isInsideElevator = false;
    public GameObject BetonCharacter;
    public GameObject Packet1;
    public GameObject Packet2;
    public GameObject Packet3;
    public GameObject Packet4;
    public GameObject Beton;
    public float radius = 3f;
    private Vector3 hoch;
    public GameObject elevator;

    private void Update()
    {
        if (isMoving)
        {
            Vector3 moveDirection = targetPosition - transform.position;
            if (moveDirection.magnitude > 0.01f)
            {
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            else
            {
                isMoving = false;
            }
        }

        if (isInsideElevator)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                MoveUp();
            }
        }



        float distance = Vector3.Distance(Beton.transform.position, elevator.transform.position);
        if (distance <= radius && collectedBeton < requiredBeton)
        {
            collectedBeton++;
        }

        float distance1 = Vector3.Distance(Packet1.transform.position, elevator.transform.position);
        float distance2 = Vector3.Distance(Packet2.transform.position, elevator.transform.position);
        float distance3 = Vector3.Distance(Packet3.transform.position, elevator.transform.position);
        float distance4 = Vector3.Distance(Packet4.transform.position, elevator.transform.position);

        if (distance1 <= radius && collectedPlanks < requiredPlanks)
        {
            collectedPlanks += Packet1.transform.childCount;
        }
        else if (distance2 <= radius && collectedPlanks < requiredPlanks)
        {
            collectedPlanks += Packet2.transform.childCount;
        }
        else if (distance3 <= radius && collectedPlanks < requiredPlanks)
        {
            collectedPlanks += Packet3.transform.childCount;
        }
        else if (distance4 <= radius && collectedPlanks < requiredPlanks)
        {
            collectedPlanks += Packet4.transform.childCount;
        }
        Debug.Log(collectedPlanks + " " + collectedBeton);
    }

   
        
            
        

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collectedPlanks >= requiredPlanks && collectedBeton >= requiredBeton)
            {
                isInsideElevator = true;
                Debug.Log("Du bist in den Aufzug eingestiegen. Drücke G, um hinaufzufahren.");
            }
            else
            {
                Debug.Log("Du hast nicht genügend Ressourcen gesammelt, um den Aufzug zu benutzen.");
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isInsideElevator = false;
        }
    }


    public void MoveUp()
    {
        hoch = new Vector3(0f, 7f, 0f);
        if (!isMoving)
        {
            isMoving = true;
            targetPosition = transform.position + hoch; // Neues Ziel der Aufzugsposition (hier eine Einheit nach oben)
           
        }
        StartCoroutine(Go());
        Beton.SetActive(false);
        Packet1.SetActive(false);
        Packet2.SetActive(false);
        Packet3.SetActive(false);
        Packet4.SetActive(false);
    }

    public IEnumerator Go()
    {
        yield return new WaitForSeconds(1f);
        if(SceneManager.GetActiveScene().name == "Superstruct")
        {
            SceneManager.LoadScene(3);
        }
    }
}