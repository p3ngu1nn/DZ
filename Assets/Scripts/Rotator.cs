using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    GameObject instance;

    Vector3 position = new Vector3(0f, 0f, 0f);
    Quaternion rotation = Quaternion.identity;

    [SerializeField] Vector3 direction = new Vector3(0f, 45f, 0f);
    [SerializeField] float speed = 1f;

   
    void Start()
    {

    }


    void Update()
    {
        if (prefab == null)
        {
            Debug.LogError("Prefab is null");
            return;
        }

        if (instance == null)
        {
            instance = Instantiate(prefab, position, rotation);
        }

        instance.transform.Rotate(direction * speed * Time.deltaTime);

    }
}

