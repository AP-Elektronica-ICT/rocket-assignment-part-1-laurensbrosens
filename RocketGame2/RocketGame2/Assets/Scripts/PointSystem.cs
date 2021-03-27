using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int Points;
    public Text UIPoints;
    void Start()
    {
        Points = 0;
    }

    void Update()
    {
        UIPoints.text = $"Points = {Points}";
    }
}
