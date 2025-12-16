using UnityEngine;

public class PositionSender : MonoBehaviour
{
    public RemotePlayer remotePlayer;

    public void SendOptimizedPosition(Vector3 pos)
    {
        remotePlayer.ReceivePosition(pos);
    }
}
