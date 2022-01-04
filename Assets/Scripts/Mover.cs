using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    public AudioSource m_MyAudioSource;
    Vector3 PrevPos;
    Vector3 NewPos;
    Vector3 ObjVelocity;
    public GameObject text;

    bool isAudioPlaying;

    void Start()
    {
        PrevPos = transform.position;
        NewPos = transform.position;
        m_MyAudioSource = GetComponent<AudioSource>();
    }


    private void FixedUpdate()
    {
        MovePlayer();
        NewPos = transform.position;
        ObjVelocity = (NewPos - PrevPos) / Time.fixedDeltaTime;
        PrevPos = NewPos;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Finish")
        {
            text.SetActive(true);
        }
    }



    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);

        if (ObjVelocity.x != 0 || ObjVelocity.z != 0)
        {
            if (!isAudioPlaying)
            {
                m_MyAudioSource.Play();
                isAudioPlaying = true;
            }

        } else {
            m_MyAudioSource.Stop();
            isAudioPlaying = false;
        }
    }
}
