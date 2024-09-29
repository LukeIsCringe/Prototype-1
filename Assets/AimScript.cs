using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class AimScript : MonoBehaviour
{
    [SerializeField] private Transform aimBall;
    [SerializeField] private float aimBallDistance = 1.5f;

    public InputAction look;
    public PlayerInput playerControls;

    public void Awake() 
    {
        playerControls = new PlayerInput();
    }

    public void OnEnable()
    {
        //look = playerControls.Player.Look;
        look.Enable();
    }

    public void OnDisable()
    {
        look.Disable(); 
    }

    void Update()
    {
        /*Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3 direction = mousePos - transform.position;

        aimBall.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg));

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        aimBall.position = transform.position + Quaternion.Euler(0, 0, angle) * new Vector3(aimBallDistance, 0, 0);
        */
        
    }

    public void Look(InputAction.CallbackContext context)
    {

    }
}
