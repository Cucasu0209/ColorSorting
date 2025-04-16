using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAreaAdjuster : MonoBehaviour
{
    public RectTransform Panel;

    private void Start()
    {
        ApplySafeArea();
    }

    private void ApplySafeArea()
    {
        Rect safeArea = Screen.safeArea;

        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        Panel.anchorMin = anchorMin;
        Panel.anchorMax = anchorMax;
    }
}
