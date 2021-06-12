using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour
{

    public float speed = 0.18f;
    public float jumph = 4.01f;

    void Start() { print("Start"); }

    void Update()
    {

        Vector3 dp = new Vector3();

        if (Input.GetKey(KeyCode.Q))
        {
            dp.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
        }

        transform.position += dp;
    }
}
