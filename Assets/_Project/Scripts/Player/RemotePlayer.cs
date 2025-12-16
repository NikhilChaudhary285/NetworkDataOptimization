using UnityEngine;

public class RemotePlayer : MonoBehaviour
{
    Vector3 targetPosition;
    Vector3 finalTarget;
    [SerializeField] private Vector3 remotePlayerOffset;

    #region ---- Without Network Data Optimzation ----

    public void ReceivePosition(Vector3 position)
    {
        //transform.position = position;

        // Apply movement using its own starting position
        Debug.Log($"[RECEIVE]:{position}");
        transform.position = position + remotePlayerOffset;
    }
    #endregion ---- Without Network Data Optimzation ----

    #region ---- Unpack Data: For Network Data Optimization ----

    /*public void ReceiveOptimizedPosition(OptimizedPosition data)
    {
        Vector3 reconstructed = new Vector3(
            data.x / 10f,
            data.y / 10f,
            data.z / 10f
        );

        Debug.Log($"[RECEIVE] Reconstructed:{reconstructed}");

        transform.position = reconstructed + remotePlayerOffset;
    }*/
    #endregion ---- Unpack Data: For Network Data Optimization ----

    #region ---- Unpack Data With Interpolation Concept To Smooth Movement With Network Data Optimization ----
    public void ReceiveOptimizedPosition(OptimizedPosition data)
    {
        targetPosition = new Vector3(
            data.x / 10f,
            data.y / 10f,
            data.z / 10f
        );

        Debug.Log($"[NETWORK][RECEIVE] Reconstructed Position (No Offset): {targetPosition}");
    }

    void Update()
    {
        finalTarget = targetPosition + remotePlayerOffset;

        Debug.Log($"[REMOTE][APPLY] Base:{targetPosition} | Offset:{remotePlayerOffset} | Final:{finalTarget}");

        transform.position = Vector3.Lerp(
            transform.position,
            finalTarget,
            Time.deltaTime * 10f // Time.deltaTime * variable such as for: High value (e.g. 15–20): Fast catch-up || Medium value (e.g. 8–12): Balanced smoothing || Low value (e.g. 3–6): Very smooth
        );
    }
    #endregion ---- Unpack Data With Interpolation Concept To Smooth Movement With Network Data Optimization ----
}
