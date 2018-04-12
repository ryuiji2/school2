using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrops : MonoBehaviour {
    
    public GameObject[] cubes;
	
	public void SpawnCube () {

        GameObject cube =  Instantiate(cubes[Random.Range(0,5)], new Vector3(Random.Range(-9, 9), 1, Random.Range(-9, 9)), Quaternion.identity);
	}
}