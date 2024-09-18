using System;
using UnityEngine;

public class CleanUp : MonoBehaviour
{
    [SerializeField] private GameObject tmp;
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < tmp.transform.childCount; i++)
        {
            Destroy(tmp.transform.GetChild(0).gameObject);
        }
    }
}
