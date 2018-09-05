using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpForce = 10.0f;
    public Rigidbody2D circle;
    public string currentColor;
    public SpriteRenderer sr;
    public Color blue;
    public Color yellow;
    public Color pink;
    public Color purple;

    void Start() {
        setRandomColor();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            circle.velocity = Vector2.up * jumpForce;
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
    }

    void setRandomColor()
    {
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                currentColor = "Blue";
                sr.color = blue;    
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = yellow;
                break;
            case 2:
                currentColor = "Pink";
                sr.color = pink;
                break;
            case 3:
                currentColor = "Purple";
                sr.color = purple;
                break;
            default:
                break;
        }
    }
}
 