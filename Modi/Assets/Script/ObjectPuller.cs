using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPuller : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;

    }
    public List<Pool> pools;

    public Dictionary<string, Queue<GameObject>> poolDictinary;

    #region Singleton
    public static ObjectPuller Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion;




    // Start is called before the first frame update
    void Start()
    {
        poolDictinary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            
            for (int i =0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDictinary.Add(pool.tag, objectPool);
        }

    }


    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if(!poolDictinary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag" + tag + "doesn not exit.");
            return  null;
        }



        GameObject objectToSpawn = poolDictinary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictinary[tag].Enqueue(objectToSpawn);
        return objectToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
