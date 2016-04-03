using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour
{

    public GameObject player;

    private Vector3 _offset;
	// Use this for initialization
	void Start ()
	{

	    _offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    

	}

    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}
