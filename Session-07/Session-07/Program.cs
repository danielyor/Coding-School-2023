using System;
using Session07;

Console.WriteLine("Session 07 Exercise");

// request = new ActionRequest("80", ActionEnum.Convert);
ActionRequest request = new ActionRequest("There are long words in this string and some are longer than others !", ActionEnum.Uppercase);
//ActionRequest request = new ActionRequest("Hello, I can speak backwards!", ActionEnum.Reverse);

ActionResponse response = new();
ActionResolver resolver = new();

response = resolver.Execute(request);

// 2nd request: Uppercase

// 3rd request: Reverse

// 4th request: an invalid request

// log all the messages

Console.ReadKey();