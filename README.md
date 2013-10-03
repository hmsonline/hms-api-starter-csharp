hms-api-starter-csharp
======================

Starter Kit for HMS API in C Sharp
=======

This provides a sample approach for interacting with the HMS API using C# .NET

### Project Location
http://github.com/hmsonline/hms-api-starter-csharp

### Building from Source
Download and open/build the project with Visual Studio.

### Usage for testing/educational purposes
You will need a key to successfully run the unit test which will use the HMS Search API to return a set of practitioners.  This key can be obtained by contacting the appropriate personnel (see http://developer.hmsonline.com/Home for more information).
Once you have the key, secret, and client for the URL (e.g. masterfile) you can then update the TestConstants class in the test project and run the test.

### Usage for integration into a production environment
With either approach you should take a look and revise as needed the default values in the Core.HmsApiConfig class.  These connection values (key, secret, etc.) will be used as defaults throughout the code.  They can be overwritten by passing in parameters into the API calls.

It's recommended that this serve only as a sample.  The code be should be migrated (copy/paste) into your production project and then revised.

If you want to do some quick testing/development you can add a reference to the starter kit project and then call the public methods.
For example: com.healthmarketscience.api.samples.dotnet.Search.findAll();


