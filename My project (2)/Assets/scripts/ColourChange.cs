using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColourChange : MonoBehaviour

{
    public GameObject cube;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ball02")
        {
            Destroy(cube,0.5f);
            Debug.Log("t22222");
        }


       
    }

}
