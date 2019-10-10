# WeatherAPI
## NuGet Packages used
- RestSharp
- NUnit
- NUnitTestAdapter
- Newtonsoft.Json
 To be able to test if the information received from the API found on https://api.openweathermap.org was correct, a DTO(Data Tranfer Object) framework was build to help with manipulating the data.
 The framework is composed of:
 - The DTO class that helps with deserialization of objects,
 - The Model class which handles the properties of the API items,
 - The Call Manager class which hadles the information request,
 - The Service class which combines the previous three classes together,
 - The Config class which send the BaseUrl, ApiKey and ApiUrlMod to the App.config file so that the connection can be established,
 - The Program class which is used for trobleshooting purposes,
 - The Test class which contains 30 different tests which are checking to see if the data received from the API has the correct structure.
 ## Description of Test Class
 The Test Class has test for every different element type. It is worth mentioning that since all the elements in list have the same structure, testing every single one of them is not required because of the Equivalence Partitioning principle.
### Three of the tests fail on purpose. 
- The first one that fails checks to see if at a particular point in time is day or night. The value that the API can return is a char and it can take only two values: 'd' for day and 'n' for night.
- The second test that fails is related to the first one, but it checks for any possible outcome, not just 'd' or 'n'. Its main purpose is to make sure that the values returned are only 'd' or 'n'; Anything else would be an anomaly.
- The last test that fails checks if an element inside the list contains or not "rain".
