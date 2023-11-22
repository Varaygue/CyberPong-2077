using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Scoring : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Score1"))
        {
            onTriggerEnter.Invoke();
        }
    }
}
