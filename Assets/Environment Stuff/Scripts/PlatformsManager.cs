using UnityEngine;

public class PlatformsManager : MonoBehaviour
{
    public float platformMoveSpeed = 1f;
    public float speedIncrement;

    public void Update()
    {
        speedIncrease();
        Debug.Log(platformMoveSpeed);
    }

    public void speedIncrease()
    {
        platformMoveSpeed = platformMoveSpeed + speedIncrement;
    }
}
