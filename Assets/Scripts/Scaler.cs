using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    GameObject instance;

    Vector3 position = new Vector3(0f, 0f, 0f);
    Quaternion rotation = Quaternion.identity;

    [SerializeField] float speed = 0.5f;
    [SerializeField] Vector3 currentScale = new Vector3(2f, 2f, 2f);
    [SerializeField] float targetScale = 4f;



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

        instance.transform.localScale += currentScale * speed * Time.deltaTime;

        if (instance.transform.localScale.x < targetScale)      
        {
            speed = Mathf.Abs(speed);
        }

        if (instance.transform.localScale.x > targetScale)    //не получилось уменшить сферу обратно
        {
            speed = -Mathf.Abs(speed);
        }

    }
}

