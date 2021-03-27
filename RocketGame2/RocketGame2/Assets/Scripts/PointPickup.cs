using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPickup : MonoBehaviour
{
    public GameObject PointManager;
    public PointSystem PointSystem;
    void Start()
    {
        if (PointManager == null)
        {
            PointManager = GameObject.Find("PointManager");
        }
        if (PointSystem == null)
        {
            PointSystem = PointManager.GetComponent<PointSystem>();
        }
    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("bots");
            PointSystem.Points++;
            Destroy(gameObject);
        }
    }
}
