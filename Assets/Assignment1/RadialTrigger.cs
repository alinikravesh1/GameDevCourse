using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public Transform playerObj;
    public Transform triggerObj;

    float triggerRadius = 2f;

    private void OnDrawGizmos()
    {
        Vector2 playerPos = playerObj.position;
        Vector2 triggerOrigin = triggerObj.position;

        // Draw the player blue at the player position
        Gizmos.color = Color.blue;
        Gizmoa.DrawSphere(playerPos, 0.1f);

        // Check if player is inside. Set the color to red if outside and green if inside.
        Gizmos.color = Vector2.Distance(playerPos, triggerOrigin) > triggerRadius ? Color.red : Color.green;
        Gizmos.DrawWireSphere(triggerOrigin, triggerRadius);
    }
}
