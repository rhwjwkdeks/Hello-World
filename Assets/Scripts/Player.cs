using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public Text scoreText;
    public int count = 0;
    //public Objective ob;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "object")
        {
            other.gameObject.SetActive(false);
            //count = count + ob.point;
            scoreText.text = "Score: " + count;
        }
    }
}
