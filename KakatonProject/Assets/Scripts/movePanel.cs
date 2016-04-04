using UnityEngine;
using System.Collections;

public class movePanel : MonoBehaviour
{

    [SerializeField]
    private float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(-(Time.deltaTime * speed), 0f, 0f);
        if (transform.position.x < -12f)
            Destroy(gameObject);
    }
}
