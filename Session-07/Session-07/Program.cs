using System;
using Session07;

Console.WriteLine("Session 07 Exercise");

ActionResolver resolver = new();

// 1. Convert request
ActionRequest request1 = new ActionRequest("80", ActionEnum.Convert);
ActionResponse response1 = new();
response1 = resolver.Execute(request1);

// 2. Uppercase request
ActionRequest request2 = new ActionRequest("There are long words in this string and some are longer than others !", ActionEnum.Uppercase);
ActionResponse response2 = new();
response2 = resolver.Execute(request2);

// 3. Reverse request
ActionRequest request3 = new ActionRequest("Hello, I can speak backwards!", ActionEnum.Reverse);
ActionResponse response3 = new();
response3 = resolver.Execute(request3);

// 4. Invalid request
ActionRequest request4 = new ActionRequest("Tell me my fortune", ActionEnum.Convert);
ActionResponse response4 = new();
response4 = resolver.Execute(request4);

// Log all the messages
resolver.Logger.ReadAll();

Console.ReadKey();