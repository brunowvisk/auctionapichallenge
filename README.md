# Auction API Challenge

Web API in .Net 6.0 C#

## Technologies used in the project

- [.Net Core 6.0](https://dotnet.microsoft.com/en-us/download) - Framework
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/) - Integrated Development Environment (IDE)

## How to install

## Installation

- After download and install .Net 6.0 from their official website, create a new folder and navigate to this location
    ```
    C:\Users\'username'>cd C:\Users\'yourusername'\ (...)
    ```
- clone the repo in your new folder
    ```
    git clone https://github.com/brunowvisk/auctionapichallenge.git
    ```
- Start your application using Visual Studio

- Now, you can use Postman, Swagger, Insomnia or another API Platform to test the application. 
- If you're using Postman, you can try the following steps:
    - Select 'post' method:
        - Add this path: https://localhost:7129/api/Calculation/TotalCost
        - Click on 'Body' and then 'raw' option
        - Write a JSON Request to get a JSON response with all fees and total cost. Here is an example of JSON Request:
        ```
            {
                "basePrice": 1000,
                "type": 1
            }
        ```
        - You should get a JSON Response like the following example:
        ```
            {
                "basicFee": 50,
                "specialFee": 20.00,
                "associationFee": 10,
                "storageFee": 100,
                "totalCost": 1180.00
            }
        ```

## Tests

There are some unit tests created with xUnit.net testing tool. They were created with the following data table below:

Vehicle Price ($) | Vehicle Type | Basic Fee | Special Fee | Association Fee | Storage Fee | Total ($)
--- | --- | --- | --- |--- |--- |--- 
398.00 | Common | 39.80 | 7.96 | 5.00 | 100.00 | 550.76
501.00 | Common | 50.00 | 10.02 | 10.00 | 100.00 | 671.02
57.00 | Common | 10.00 | 1.14 | 5.00 | 100.00 | 173.14
1 800.00 | Luxury | 180.00 | 72.00 | 15.00 | 100.00 | 2 167.00
1 100.00 | Common | 50.00 | 22.00 | 15.00 | 100.00 | 1 287.00 
1 000 000.00 | Luxury | 200.00 | 40 000.00 | 20.00 | 100.00 | 1 040 320.00 

## Contact

- Bruno Rocha - https://www.linkedin.com/in/bruno-f-rocha-6770a31a2/
- Project link - https://github.com/brunowvisk/auctionapichallenge
