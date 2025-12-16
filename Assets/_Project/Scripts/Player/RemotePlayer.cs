using UnityEngine;

public class RemotePlayer : MonoBehaviour
{
    [SerializeField] private Vector3 remotePlayerOffset;
    public void ReceivePosition(Vector3 pos)
    {
        //transform.position = pos;

        // Apply movement using its own starting position
        transform.position = pos + remotePlayerOffset;
    }
}
