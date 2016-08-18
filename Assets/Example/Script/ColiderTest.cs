using UnityEngine;
using System.Collections;
using UnityEngine.Networking.Types;

public class ColiderTest : MonoBehaviour {

	// Use this for initialization

    public GameObject cube_1;
    public GameObject cube_2;
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
	        Debug.Log("KeyCode.UpArrow");
            cube_2.transform.position += Vector3.left * 0.1f;
	    }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("KeyCode.UpArrow");
            cube_2.transform.position += Vector3.right * 0.1f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("KeyCode.UpArrow");
            cube_2.transform.position += Vector3.forward * 0.1f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("KeyCode.UpArrow");
            cube_2.transform.position += Vector3.back * 0.1f;
        }
    }
}
