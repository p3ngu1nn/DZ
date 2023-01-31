using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PingPong : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] float speed = 5f;
    GameObject instance;

    Quaternion rotation = Quaternion.identity;
    Vector3 position = new Vector3(-5f, 0f, 0f);
    float minPoint = -5f;
    float maxPoint = 5f;
    
    
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

        position = instance.transform.position;
        position.x += speed * Time.deltaTime;
        instance.transform.position = position;

        if (position.x < minPoint)
        {
            speed = Mathf.Abs(speed);
        }

        if (position.x > maxPoint)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
