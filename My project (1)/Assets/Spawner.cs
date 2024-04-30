using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnGameObject), 1, 1) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SpawnGameObject();
    }

    void SpawnGameObject()
    {
        //TO SPAWN
        GameObject capsule = Instantiate(toSpawn, spawnPos.position, spawnPos.rotation);
        Destroy(capsule, 5);
    }
}
