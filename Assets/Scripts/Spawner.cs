using System;
using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private GameObject tmp;
    [SerializeField] private float rayDistance = 100f;
    private Camera _camera;
    private void Start()
    {
        _camera = Camera.main;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            Ray ray = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                Instantiate(obj, hit.point + Vector3.up*0.5f, Quaternion.identity, tmp.transform);
            }
            
            yield return new WaitForSeconds(5);
        }
    }
}
