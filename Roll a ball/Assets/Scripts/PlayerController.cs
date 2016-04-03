using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    private Rigidbody _rb;
    private int _count;
    public Text CountText;
    public Text WinText;


    // Use this for initialization
    void Start()
    {
        _count = 0;
        _rb = GetComponent<Rigidbody>();
        SetCountText();
        WinText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    }

    //phyiscsCode
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        _rb.AddForce(movement * _speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            _count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        CountText.text = "Count:" + _count.ToString();
        if (_count >= 12)
        {
            WinText.text = "You Win!";
        }
    }
}
