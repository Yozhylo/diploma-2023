using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VariablesPassingToGame : MonoBehaviour
{
    public static float tankSize;
    public static float temperature;
    public static float acidity;
    public static float ammonia;
    public static float nitrite;
    public static float nitrate;

    public static UnityEvent<float[]> submitEnviromentVariables;

    public static void SubmitEnviromentVariables()
    {
        float[] enviromentVariables = new float[5];
        enviromentVariables[0] = tankSize;
        enviromentVariables[1] = temperature;
        enviromentVariables[2] = acidity;
        enviromentVariables[3] = ammonia;
        enviromentVariables[4] = nitrite;
        enviromentVariables[5] = nitrate;
        submitEnviromentVariables.Invoke(enviromentVariables);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
