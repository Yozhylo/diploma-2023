using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour {
  // Start is called before the first frame update
  // public List<Transform> Waypoints = new List<Transform>();
  //[SerializeField]
  public GameObject FishPrefab;
  public int FishAmount;
  void Start() {
		for (int i = 0; i < FishAmount; i++) createFish(FishPrefab, new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f)));
  }
  public static void createFish(GameObject prefab, Vector3 position) {
    Instantiate(prefab, position, new Quaternion());
	}
}