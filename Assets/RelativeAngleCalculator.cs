using UnityEngine;

public class RelativeAngleCalculator : MonoBehaviour
{
    public Transform playerTransform;
    public Transform enemyTransform;

    void Update()
    {
        Vector3 playerToEnemy = enemyTransform.position - playerTransform.position;
        float angle = Mathf.Atan2(playerToEnemy.y, playerToEnemy.x) * Mathf.Rad2Deg;
        if (angle < 0)
        {
            angle += 360;
        }
        float relativeAngle = angle - playerTransform.eulerAngles.z;
        if (relativeAngle < 0)
        {
            relativeAngle += 360;
        }
        Debug.Log("相対角度: " + relativeAngle);
    }
}
