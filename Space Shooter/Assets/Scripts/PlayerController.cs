using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;


}
public class PlayerController : MonoBehaviour
{

    private Rigidbody _rb;
    public float speed;
    public Boundary boundary;
    
	// Use this for initialization
	void Start ()
	{

	    _rb = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rb.velocity = movement * speed;

        _rb.position = new Vector3
            (
            Mathf.Clamp(_rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(_rb.position.z, boundary.zMin, boundary.zMax)
            );
    }
	// Update is called once per frame
	void Update () {
	
	}
}
