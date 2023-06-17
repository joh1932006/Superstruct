using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovinPlat : MonoBehaviour
{
    public GameObject Platform;
    public float platformSpeed = 5f;
    private int test = 1;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        StartCoroutine(Go());
    }



    public IEnumerator Go()
    {
        if (test < 2400)
        {
            yield return new WaitForSeconds(0.1f);
            Vector3 position = Platform.transform.position;
            position.z += 0.005f;
            Platform.transform.position = position;
            test++;
        }
        if (test >= 2400 && test < 4800)
        {
            yield return new WaitForSeconds(0.1f);
            Vector3 position = Platform.transform.position;
            position.z -= 0.005f;
            Platform.transform.position = position;
            test++;
        }
        if (test == 4800)
        {
            test = 1;
        }
    }

}
