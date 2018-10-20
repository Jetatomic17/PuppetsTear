using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;  
using MongoDB.Driver.GridFS;  
using MongoDB.Driver.Linq;  



public class acht_001 : MonoBehaviour {

	public GameObject TextBox;
	string connectionString = "mongodb://rorocrocky:A1$wersdf@ds237389.mlab.com:37389/rorjetplay";

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{

			TextBox.GetComponent<Text> ().text = "Achievement earned : Find way out from the first room.";
			var client = new MongoClient(connectionString);
			var server = client.GetServer(); 
			var database = server.GetDatabase("rorjetplay");
			var playercollection= database.GetCollection<BsonDocument>("rorjetsave_001");

			playercollection.Insert(new BsonDocument{
			{ "achievementearned", 001 },
			{ "email", "rockkyme@gmail.com" }
		});

		


		}
	}
}
