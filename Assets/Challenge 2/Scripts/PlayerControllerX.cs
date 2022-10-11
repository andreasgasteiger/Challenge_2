using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float decaytime = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && decaytime<=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            decaytime = 1;
        }
        if (decaytime >= 0)
        {
            decaytime -= Time.deltaTime;
        }
    }
}
