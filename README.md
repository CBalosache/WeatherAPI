# WeatherAPI
 To be able to test if the information received from the API found on https://api.openweathermap.org was correct, a DTO(Data Tranfer Object) framework was build to help with manipulating the data.
 The framework is composed of:
 - The DTO class that helps with deserialization of objects,
 - The Model class which handles the properties of the API items,
 - The Call Manager class which hadles the information request,
 - The Service class which combines the previous three classes together,
 - The Config class which send the BaseUrl, ApiKey and ApiUrlMod to the App.config file so that the connection can be established,
 - The Program class which is used for trobleshooting purposes,
 - The Test class which contains 29 different tests which are checking to see if the data received from the API has the correct structure.
 ## Description of Test Class
 The Test Class has test for every different element type. It is worth mentioning that since all the elements in list have the same structure, testing every single one of them is not required because of the Equivalence Partitioning principle.
