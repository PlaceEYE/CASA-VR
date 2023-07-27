using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    GameObject player;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CameraOffset");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        // Debug.Log("distance" + distance);

        if (distance < 2f)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }


    }
}
