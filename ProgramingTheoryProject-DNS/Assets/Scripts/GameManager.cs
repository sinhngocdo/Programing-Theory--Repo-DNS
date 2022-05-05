using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Khai bao danh sach spawn object
    [SerializeField]
    GameObject[] gameObjectsPreFabs;

    //spawn pos
    [SerializeField]
    private float maxPosSpawn;

    public float MaxPosSpawn { get => maxPosSpawn; set => maxPosSpawn = value; }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObject()
    {
        Vector3 spawnPos = new Vector3(-68, 4, Random.Range(-MaxPosSpawn, MaxPosSpawn));
        Instantiate(gameObjectsPreFabs[Random.Range(0, gameObjectsPreFabs.Length)], spawnPos, Quaternion.identity);
    }
}
