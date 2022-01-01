using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRoller : MonoBehaviour
{

    public Rigidbody roller;
    private Vector3 currentPosition;

    void Start()
    {
        currentPosition = transform.position;
        InvokeRepeating("Shoot", 3f, 3f);
    }

    void Shoot()
    {
        Rigidbody rollerClone = Instantiate(roller, new Vector3(currentPosition.x + 1f, currentPosition.y, currentPosition.z), Quaternion.identity);
        rollerClone.AddForce(new Vector3(10f, 0f), ForceMode.Impulse);
        Destroy(rollerClone.gameObject, 5f);
    }
}
