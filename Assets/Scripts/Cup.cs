using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public List<Transform> WaterLayers;

    private void Update()
    {
        RotateWaterLayers();
    }


    private void RotateWaterLayers()
    {
        for (int i = 0; i < WaterLayers.Count; i++)
        {
            WaterLayers[i].localRotation = Quaternion.Euler(0, 0, -transform.rotation.eulerAngles.z);
        }
    }
}
