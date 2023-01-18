﻿using System;
using Session07;

Console.WriteLine("Session 07 Exercise");

ActionRequest request = new ActionRequest("80", ActionEnum.Convert);
ActionResponse response = new();
ActionResolver resolver = new();

response = resolver.Execute(request);

// 2nd request: Uppercase

// 3rd request: Reverse

// 4th request: an invalid request

// log all the messages

Console.ReadKey();