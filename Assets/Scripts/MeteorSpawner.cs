using System.Collections;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

	public GameObject meteorPrefab;
	public float distance = 20f;


	void Start ()
	{
		StartCoroutine(SpawnMeteor());
	}
    public void StartSpawnMeteorAfter (float delay)
	{
		Invoke("ResumeSpawnMeteor", delay);
	}
	private void ResumeSpawnMeteor ()
	{
		StartCoroutine(SpawnMeteor());
	}

	IEnumerator SpawnMeteor()
	{
		Vector3 pos = Random.onUnitSphere * 20f;
		Instantiate(meteorPrefab, pos, Quaternion.identity);

		yield return new WaitForSeconds(1f);

		if (!GameManager.pause) StartCoroutine(SpawnMeteor());
		else StopCoroutine(SpawnMeteor());
	}

}
