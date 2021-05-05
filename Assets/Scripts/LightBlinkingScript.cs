using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlinkingScript : MonoBehaviour
{
	public Light roomLight;
	public float minWaitTime;
	public float maxWaitTime;
	public float time = 1;

	public bool asd = true;

	public int EnterCounter = 0;

	void Start()
	{
		roomLight = GetComponent<Light>();
	}

	private void OnTriggerEnter(Collider other)
	{
		StartCoroutine(Counter());

		if (EnterCounter < 1)
        {
			StartCoroutine(Flashing());
		}

		EnterCounter += 1;
	}

    IEnumerator Flashing()
	{
		while (asd)
		{
			yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
			roomLight.enabled = !roomLight.enabled;

		}
	}

    IEnumerator Counter()
    {
        while (time > 0)
        {
			if (time > 0)
			{
				time -= Time.deltaTime;
				Debug.Log($"Time -1, erteke: {time}");

				yield return asd;
			}
		}

		if (time < 0)
		{
			Debug.Log("TIme eq 0");

			asd = false;
			roomLight.enabled = enabled;
		}
	}
}
