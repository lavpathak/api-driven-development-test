

# Generate api server 
openapi-generator generate -g spring -i api/book-service.yaml -o src/java


# Generate api server and client
openapi-generator generate -g csharp-netcore -i api/book-service.yaml -o src/c#