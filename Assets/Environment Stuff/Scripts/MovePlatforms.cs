using UnityEngine;
using UnityEngine.UIElements;

public class MovePlatforms : MonoBehaviour
{
    private PlatformsManager platManager;

    public void Start()
    {
        platManager = GameObject.Find("PlatformsManager").GetComponent<PlatformsManager>();
    }
    public void Update()
    {
        Vector3 movement = Quaternion.Euler(5, 0, 0) * Vector3.left;

        gameObject.transform.position += movement * platManager.platformMoveSpeed * Time.deltaTime;
    }
}
