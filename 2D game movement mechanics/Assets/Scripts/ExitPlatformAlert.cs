using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitPlatformAlert : MonoBehaviour
{
    public UnityEvent Alert;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Alert.Invoke();
    }
}
