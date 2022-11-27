//Fox Spawner Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject foxPrefab;
    // Start is called before the first frame update
    //starts with a fox to chase the player
    void Start()
    {

        Invoke("FoxSpawn", 0.5f);
        Vector3 currpos;
        currpos = transform.position;
    }


    void Update()
    {

    }
    //recursively spawns foxes
    void FoxSpawn()
    {
        //rnadomizes position and spawn time of foxes
        int rand_pos = Random.Range(0, 15);
        float rand_spawn = Random.Range(1.5f, 2.0f);
        Vector3 spawn_pos;
        GameObject fox;
        fox = Instantiate<GameObject>(foxPrefab);

        spawn_pos = this.transform.position;
        //decides on what "lane" to spawn the fox
        if (rand_pos < 5)
        {
            spawn_pos.x += 11;
            fox.transform.position = spawn_pos;
        }
        else if (rand_pos < 10)
        {
            spawn_pos.x -= 3;
            fox.transform.position = spawn_pos;
        }
        else
        {
            spawn_pos.x += 5;
            fox.transform.position = spawn_pos;
        }
        //recursively spawns at random times between 1.5-2.0 seconds
        Invoke("FoxSpawn", rand_spawn);
    }
}
