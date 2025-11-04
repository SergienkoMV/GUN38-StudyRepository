using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Netologia.Homework
{
	public class Player : MonoBehaviour
	{
		private bool _ready;
		private Rigidbody _ball;
		
		[SerializeField]
		private Rigidbody _ballPrefab;
		[SerializeField]
		private float _startVelocity;
		[SerializeField]
		private float _lifetime;

		[SerializeField]
		private float _respawnDelay;

		[SerializeField]
		private Transform _firePoint;

		private void Update()
		{
			if (!_ready) return;
			if (Input.GetKeyDown(KeyCode.Space))
			{
				StartCoroutine(Reloader());
				_ball.isKinematic = false;
				_ball.transform.parent = null;
				_ball.velocity = transform.forward * _startVelocity;
				Destroy(_ball.gameObject, _lifetime);
			}
		}

		private IEnumerator Reloader()
		{
			_ready = false;
			yield return new WaitForSeconds(_respawnDelay);
			Spawn();
		}

		private void Spawn()
		{
			_ball = Instantiate(_ballPrefab, _firePoint);
			_ball.transform.localScale = Vector3.one;
			_ball.isKinematic = true;
			_ready = true;
		}

		private void Start()
		{
			Spawn();
		}
	}
}