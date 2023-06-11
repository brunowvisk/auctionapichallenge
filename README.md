# auctionapichallenge

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

## Contact

- Bruno Rocha - https://www.linkedin.com/in/bruno-f-rocha-6770a31a2/
- Project link - https://github.com/brunowvisk/auctionapichallenge
