using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBounce : MonoBehaviour
{

    private Vector3 jump;
    private float jumpForce = 8.0f;

    private void Start()
    {
        jump = new Vector3(0.5f, 2.0f, 0.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Roller"))
        {
            other.attachedRigidbody.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }
}
