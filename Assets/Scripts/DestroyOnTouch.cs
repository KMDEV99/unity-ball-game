using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    public Rigidbody roller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Roller"))
        {
            Destroy(other.gameObject);
            Rigidbody rollerClone = Instantiate(roller, new Vector3(-12.2f, 1.7f, -4.5f), Quaternion.identity);
            Destroy(rollerClone, 10f);
        }
    }
}
