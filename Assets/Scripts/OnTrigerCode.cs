using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigerCode : MonoBehaviour
{

    private CharacterController cc;
    public GameObject canvas;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals( "Player"))
        {
            Debug.Log("Collided");
            canvas.SetActive(true);

        }

    }
}
