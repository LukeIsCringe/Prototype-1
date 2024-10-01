using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class ControllerRotation : MonoBehaviour
{
	public GameObject Object;
	[SerializeField] Vector2 GameobjectRotation;
	[SerializeField] private float GameobjectRotation2;
	[SerializeField] private float GameobjectRotation3;

	public bool FacingRight = true;

	public GameObject crosshair;
	private PlayerInput playerInput;
	private InputActionAsset inputAction;
	private InputAction testAction;

	public bool controlSwap = false;


    private void Awake()
    {
		playerInput = GetComponent<PlayerInput>();
		
    }

    private void OnEnable()
    {
		playerInput.actions["SwitchActionMapMnK"].performed += SwitchActionMapMnK;
		playerInput.actions["SwitchActionMapGamepad"].performed += SwitchActionMapGamepad;
	}

	private void OnDisable()
	{
		playerInput.actions["SwitchActionMapMnK"].performed -= SwitchActionMapMnK;
		playerInput.actions["SwitchActionMapGamepad"].performed -= SwitchActionMapGamepad;
	}


	private void SwitchActionMapMnK(InputAction.CallbackContext context)
    {
		playerInput.SwitchCurrentActionMap("GamePad");
    }

	private void SwitchActionMapGamepad(InputAction.CallbackContext context)
	{
		playerInput.SwitchCurrentActionMap("MnK");
	}

	void Update()
	{
		ControllerAim();
		crosshair.transform.position = gameObject.transform.position;
	}
	public void Flip()
	{
		// Flips the player.
		FacingRight = !FacingRight;

		transform.Rotate(0, 180, 0);
	}

	void ControllerAim()
    {
		GameobjectRotation3 = GameobjectRotation.x;

		if (FacingRight)
		{
			//Rotates the object if the player is facing right
			GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * 90;
			Object.transform.rotation = Quaternion.Euler(0f, 0f, GameobjectRotation2);
		}
		else
		{
			//Rotates the object if the player is facing left
			GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * -90;
			Object.transform.rotation = Quaternion.Euler(0f, 180f, -GameobjectRotation2);
		}
		if (GameobjectRotation3 < 0 && FacingRight)
		{
			// Executes the void: Flip()
			Flip();
		}
		else if (GameobjectRotation3 > 0 && !FacingRight)
		{
			// Executes the void: Flip()
			Flip();
		}
	}

	public void StickRotate(InputAction.CallbackContext RotationValue)
    {
		GameobjectRotation = RotationValue.ReadValue<Vector2>();
	}

	public void Rotate(InputValue RotationValue)
	{
		GameobjectRotation = RotationValue.Get<Vector2>();
	}
}