using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    GameObject instance;

    Vector3 position = new Vector3(0f,0f,0f);
    Quaternion rotation = Quaternion.identity;

    [SerializeField] float periodicity = 1f;
    float updateTime;

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

        updateTime += Time.deltaTime;
 
        if (updateTime >= periodicity)
        {
            position = instance.transform.position;
            position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            instance.transform.position = position;

            updateTime = 0;
        }
        
    }
}
