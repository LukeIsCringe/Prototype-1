using UnityEngine;

public class PlatformsManager : MonoBehaviour
{
    public float platformMoveSpeed = 1f;
    public float speedIncrement = 1f;

    public void speedIncrease()
    {
        platformMoveSpeed = platformMoveSpeed + speedIncrement;
    }
}
