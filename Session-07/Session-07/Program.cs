using System;
using Session07;

Console.WriteLine("Session 07 Exercise");

ActionRequest request = new ActionRequest("Good morning!", ActionEnum.Uppercase);
ActionResponse response = new();
ActionResolver resolver = new();

response = resolver.Execute(request);


Console.ReadKey();