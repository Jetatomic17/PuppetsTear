using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;  
using MongoDB.Driver.GridFS;  
using MongoDB.Driver.Linq;  

public class HelloMongo : MonoBehaviour {

	string connectionString = "mongodb://rorocrocky:A1$wersdf@ds237389.mlab.com:37389/rorjetplay";
	public GameObject TextBox;

	void Start () {

		
		var client = new MongoClient(connectionString);
		var server = client.GetServer(); 
		var database = server.GetDatabase("rorjetplay");
		var playercollection= database.GetCollection<BsonDocument>("rorjetsentence");

		TextBox.GetComponent<Text> ().text = playercollection.FindOne ().ToString();

	}
}


	
		