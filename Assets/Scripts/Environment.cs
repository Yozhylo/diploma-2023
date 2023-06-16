using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Environment {
  private static Environment instance = null;
  public static Environment SharedInstance {
		get {
          if (instance == null) instance = new Environment();
          return instance;
		}
	}
  public float Temperature {
    set; get;
  }
  public float Ammonia {
    set; get;
  }
  public float Nitrite {
    set; get;
  }
  public float Nitrate {
    set; get;
  }
  public float GeneralHardness {
    set; get;
  }
  public float? CarbonateHardness {
    set; get;
  }
  public float Acidity {
    set; get;
  }
  public float? Salinity {
    set; get;
  }
  public float Size {
    set; get;
	}
  Environment() {
    Temperature = 18.0f;
    Ammonia = 0.0f;
    Nitrite = 0.0f;
    Nitrate = 0.0f;
    GeneralHardness = 0.0f;
    Acidity = 7.0f;
	}
}