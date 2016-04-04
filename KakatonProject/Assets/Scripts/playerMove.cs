using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour
{
    [SerializeField]
    private int jumpSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -2f * Time.deltaTime, 0f);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-2f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(2f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpSpeed), ForceMode2D.Impulse);
        }
    }
}
