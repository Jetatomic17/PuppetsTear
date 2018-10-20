#pragma strict

var timer = 0.0;

function Start () {

}

function Update() {
	timer += Time.deltaTime;
	if(timer>4.0)
	{
	Application.LoadLevel(1);
	}

}