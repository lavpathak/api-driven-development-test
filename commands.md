
# Lint openapi file
spectral lint api/book-service.yaml


# validate openapi file with custom rules
spectral lint api/book-service.yaml -r api/operation-tag-severity-rule.yaml -r api/tag-description-rule.yaml


# Generate api server in Java Spring
openapi-generator generate -g spring -i api/book-service.yaml -o src/java


# Generate api server and client in c#
openapi-generator generate -g csharp-netcore -i api/book-service.yaml -o src/c#


# Generate documentation
openapi-generator generate -g html2 -i api/book-service.yaml -o docs

# Run implementation test
jest example.test.js

