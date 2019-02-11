#!/bin/bash

for i in {1..20}
do
    curl http://localhost:5000/api/orders
    curl http://localhost:5000/api/orders/1
    curl http://localhost:5000/api/products
    curl http://localhost:5000/api/products/1
done