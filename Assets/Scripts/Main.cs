using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;
    [SerializeField] private ObjectPool objectPool = null;


    void Start()
    {
        Debug.Log(GameManager.Instance.a);
        StartCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {
        int counter = 0;
        while(true)
        {

            GameObject obj = null;
            if(counter%2==0)
            {
              obj = objectPool.GetPooledObject(0);
                counter++;
            }
            else
            {
                obj = objectPool.GetPooledObject(1);
                counter++;
            }

            obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
