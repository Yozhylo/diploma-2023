using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour {
  // Start is called before the first frame update
  // public List<Transform> Waypoints = new List<Transform>();
  //[SerializeField]
  public GameObject FishPrefab;
  void Start() {
    createFish(FishPrefab, new Vector3(Random.value*2, Random.value*2));
    createFish(FishPrefab, new Vector3(Random.value*2, Random.value*2));
    createFish(FishPrefab, new Vector3(Random.value*2, Random.value*2));
  }
  public static void createFish(GameObject prefab, Vector3 position) {
    Instantiate(prefab, position, new Quaternion(0, 0, 0, 0));
	}
}