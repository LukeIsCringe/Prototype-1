using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject player;

    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    
    void Update()
    {
        gameObject.transform.position = player.transform.position;

        ControllerRotation controllerRotation = new ControllerRotation();

        if (!controllerRotation.gamepadActive)
        {
            Aim();
        }
    }

    void Aim()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
