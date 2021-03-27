using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorImpact : MonoBehaviour
{
    public GameObject Meteor;
    private void Start()
    {
        Spawn();
    }
    void OnCollisionEnter(Collision collision)
    {
        Spawn();
        GetComponent<TrailRenderer>().Clear();
    }
    private void Spawn()
    {
        Meteor.transform.position = new Vector3(0, Random.Range(100.0f, 200.0f), Random.Range(-200.0f, 200.0f));
    }
}
