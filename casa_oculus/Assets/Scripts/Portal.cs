using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject world1;
    public GameObject world2;
    public GameObject world3;
    public GameObject world4;

    public GameObject player;
    // public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        world1 = GameObject.Find("peye_dummy_2");
        world2 = GameObject.Find("Hyerin");
        world3 = GameObject.Find("sooyun");
        world4 = GameObject.Find("_인류세 절벽 최종");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        // Debug.Log("distance" + distance);

        if (distance < 1f)
        {
            // obj.SetActive(false);
        }
        else
        {
            // obj.SetActive(true);
        }


    }
}
