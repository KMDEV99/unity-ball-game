using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnCollision : MonoBehaviour
{

    private Vector3 startPosition;
    private string objectName;
    private bool isQuitting = false;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = gameObject.transform.position;
        objectName = "Dropper";
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 2f);
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;    
    }

    private void OnDestroy()
    {
        if (!isQuitting)
        {
            GameObject gameObjectClone = Instantiate(gameObject);
            gameObjectClone.name = objectName;
            gameObjectClone.transform.position = startPosition;
            gameObjectClone.SetActive(true);
        }
    }

}
