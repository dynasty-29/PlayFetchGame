using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogDelay = 1f;
    public float lastDog = 0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastDog>= dogDelay)
            {
                GameObject dog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dog.transform.parent = transform;

                lastDog = Time.time;
            }
        }
    }
}
