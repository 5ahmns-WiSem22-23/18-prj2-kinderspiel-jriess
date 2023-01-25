using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> plates;
    public bool readyToSpawn;

    private void Start()
    {
        ResetSpawnManager();
    }

    private void Update()
    {
        CheckInput();
    }

    void ResetSpawnManager()
    {
        readyToSpawn = true;
    }
    
    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && readyToSpawn)
        {
            SpawnPlate();
            readyToSpawn = false;
        }
    }

    public void SpawnPlate()
    {
        GameObject plateToSpawn = plates[Random.Range(0, plates.Count)];
        plates.Remove(plateToSpawn);
        plateToSpawn.transform.position = new Vector2(0, 0);
    }
}
