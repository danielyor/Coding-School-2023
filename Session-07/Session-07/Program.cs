using System;
using ActionRequestNS;
using ActionResponseNS;
using ActionResolverNS;

Console.WriteLine("Session 07 Exercise");

ActionRequest request = new ActionRequest(Guid.NewGuid(), "Good morning!", ActionEnum.Uppercase);
ActionResponse response = new();
ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);


Console.ReadKey();