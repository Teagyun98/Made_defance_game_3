using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
	//ī�޶��� �����ӿ� ���� ���ٰ��� ���� �� �ֵ��� ��� ������Ʈ���� ����� �� �ְ� �ϱ� ���� ��ũ��Ʈ
	public float parallaxSpeed; //����� ���� 0, �ּ��� 1�� ������ �����Ѵ�.
	private void LateUpdate()
	{
		transform.position = new Vector3(GameManager.instance.Camera.transform.position.x*parallaxSpeed, transform.position.y, transform.position.z);
	}
}
