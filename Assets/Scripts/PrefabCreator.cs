using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    [SerializeField] List<GameObject> prefab;
    GameObject instance;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (prefab == null)
            {
                Debug.LogError("Prefab is null");
                return;
            }

            if (instance != null)
            {
                Destroy(instance);
            }

            var rotation = Quaternion.identity;
            var position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));

            instance = Instantiate(prefab[Random.Range(0,prefab.Count)],position, rotation);
        }
    }
}
