using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public float speed = 5f;
    public PositionSender sender;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);
        transform.position += move * speed * Time.deltaTime;

        if (!sender.networkOptimization)
            sender.SendPosition(transform.position);
        else
            sender.SendOptimizedPosition(transform.position);
    }
}
