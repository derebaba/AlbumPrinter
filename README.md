# Albelli .NET Software Engineer Technical Assignment

## APIs

* GET api/orders/{orderID}

* POST api/orders
Example body:
```
{
    "OrderItems": [
        {
            "ProductType": "calendar",
            "Quantity": 2
        },
        {
            "ProductType": "photoBook",
            "Quantity": 2
        },
        {
            "ProductType": "canvas",
            "Quantity": 2
        },
        {
            "ProductType": "cards",
            "Quantity": 2
        },
        {
            "ProductType": "mug",
            "Quantity": 5
        }
    ]
}
```
* Both requests return Order model as the response. Example response:
```
{
    "OrderID": "91740d8a-d66d-4a3c-bfcf-92393a2e9d8a",
    "RequiredBinWidth": 287.4,
    "OrderItems": [
        {
            "ProductType": "calendar",
            "Quantity": 2
        },
        {
            "ProductType": "photoBook",
            "Quantity": 2
        },
        {
            "ProductType": "canvas",
            "Quantity": 2
        },
        {
            "ProductType": "cards",
            "Quantity": 2
        },
        {
            "ProductType": "mug",
            "Quantity": 5
        }
    ]
}
```
## Assumption
OrderItems that have the same `ProductType` are not merged. For example, if the `Order` below is sent:
```
{
    "OrderItems": [
        {
            "ProductType": "mug",
            "Quantity": 2
        },
        {
            "ProductType": "mug",
            "Quantity": 1
        }
    ]
}
```
The API will return `RequiredBinWidth` as 94 * 2 = 188. The reasoning is, although there are a total of 3 mugs, they can be different types of mugs which cannot be stacked.