using UnityEngine;

public class PositionSender : MonoBehaviour
{
    public RemotePlayer remotePlayer;
    public bool networkOptimization;

    #region ---- Without Network Data Optimzation ----
    public void SendPosition(Vector3 pos)
    {
        Debug.Log($"[SEND] Pos:{pos} | Data Size: 96 bits");
        remotePlayer.ReceivePosition(pos);
    }
    #endregion ---- Without Network Data Optimzation ----

    #region ---- Pack Data: For Network Data Optimization ----

    public void SendOptimizedPosition(Vector3 position)
    {
        OptimizedPosition data = new OptimizedPosition
        {
            x = (short)(position.x * 10),
            y = (short)(position.y * 10),
            z = (short)(position.z * 10)
        };

        Debug.Log($"[SEND] Pos:{position} | Data Size: 48 bits");

        remotePlayer.ReceiveOptimizedPosition(data);
    }
    #endregion ---- Pack Data: For Network Data Optimization ----
}
