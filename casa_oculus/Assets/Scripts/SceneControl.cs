using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public GameObject player; // player obj for position fixing
    public GameObject world1; // obj to swap to
    public GameObject world2; // obj to swap to
    public GameObject world3; // obj to swap to
    public GameObject world4; // obj to swap to

    // Start is called before the first frame update
    void Start()
    {
        int scene = Random.Range(0, 4);
        if (scene == 0)
        {
            Instantiate(world1, transform.position, transform.rotation);
        }
        else if (scene == 1)
        {
            Instantiate(world2, transform.position, transform.rotation);
        }
        else if (scene == 2)
        {
            Instantiate(world3, transform.position, transform.rotation);
        }
        else if (scene == 3)
        {
            Instantiate(world4, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
