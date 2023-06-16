using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {
  // Start is called before the first frame update
  protected float Stress {
    set; get;
  } = 0;
  protected float Health {
    set; get;
  } = 100;
  protected (float max, float min) TemperatureConditions {
    set; get;
  }
  protected (float max, float min) AcidityConditions {
    set; get;
  }
  protected (float max, float min) HardnessConditions {
    set; get;
  }
  protected void Decay() {
    Debug.Log("Decay called");
    // Stress = 1 * (Environment.SharedInstance.Acidity - AcidityConditions);
    


    Debug.Log(Health);
    if (Health < 0) Die();
  }
  protected virtual void OnDestroy() {

  }
  protected void Die() {
    Destroy(gameObject);
	}
  private float GetStandardDeviation(float average, float value) {
    return Math.Abs(value - average);
	}
}
