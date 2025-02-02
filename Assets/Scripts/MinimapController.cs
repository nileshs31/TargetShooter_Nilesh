using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapController : MonoBehaviour
{
	public Transform player;

	public RectTransform miniMapRect;
	public Camera miniMapCamera;

	private bool isExpanded = false;

	// Default values
	private Vector2 defaultSize = new Vector2(190, 190);
	private float defaultProjectionSize = 1.85f;

	// Expanded values
	private Vector2 expandedSize = new Vector2(256, 256);
	private float expandedProjectionSize = 2.5f;



	void Update()
	{
		if (Input.GetKeyDown(KeyCode.N))
		{
			ToggleMiniMap();
		}
	}

	void ToggleMiniMap()
	{
		isExpanded = !isExpanded;

		if (isExpanded)
		{
			miniMapRect.sizeDelta = expandedSize;
			miniMapCamera.orthographicSize = expandedProjectionSize;
		}
		else
		{
			miniMapRect.sizeDelta = defaultSize;
			miniMapCamera.orthographicSize = defaultProjectionSize;
		}
	}

	void LateUpdate()
	{
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;

		transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
	}
}
