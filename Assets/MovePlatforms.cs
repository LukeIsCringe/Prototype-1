using UnityEngine;
using UnityEngine.UIElements;

public class MovePlatforms : MonoBehaviour
{
    public void Update()
    {
        PlatformsManager platManager = new PlatformsManager();

        platManager.speedIncrease();

        Vector3 movement = Quaternion.Euler(5, 0, 0) * Vector3.left;

        gameObject.transform.position += movement * (platManager.platformMoveSpeed * Time.deltaTime);

        Debug.Log(platManager.platformMoveSpeed);
    }
}
