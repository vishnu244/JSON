﻿using Json;
using System.Text.Json;
using System.Text.Json.Serialization;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to JSON!");

string file = @"C:\Users\Admin\Desktop\Vishnu\JSON\Json\Inventorydata.json";
List<inventory> files = JsonSerializer.Deserialize<List<inventory>>(File.ReadAllText(file));
foreach (var data in files)
{
    Console.WriteLine("name: " + data.Name + " weight: " + data.Weight + " price: "+ data.Price);
}

string json = JsonSerializer.Serialize(files);
Console.WriteLine("Serialized Json Object ");
Console.WriteLine(json + "\n");



