
# Lint openapi file
spectral lint api/book-service-with-example.yaml


# validate openapi file with custom rules
spectral lint api/book-service-with-example.yaml -r api/operation-tag-severity-rule.yaml -r api/tag-description-rule.yaml


# Generate api server 
openapi-generator generate -g spring -i api/book-service.yaml -o src/java


# Generate api server and client
openapi-generator generate -g csharp-netcore -i api/book-service.yaml -o src/c#


# Generate documentation
openapi-generator generate -g html2 -i api/book-service.yaml -o docs