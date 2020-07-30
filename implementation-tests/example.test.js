// Import this plugin
const jestOpenAPI = require('jest-openapi');
const axios = require('axios');

// Load an OpenAPI file (YAML or JSON) into this plugin
jestOpenAPI('/Users/lavpathak/Projects/Playground/api_driven_development/api/book-service-with-example.yaml');

// Write your test
describe('GET /book/{id}', function() {
  it('should satisfy OpenAPI spec', async function() {

    // Get an HTTP response from your server (e.g. using axios)
    const res = await axios.get("http://127.0.0.1:4010/book/812");

    expect(res.status).toEqual(200);

    // Assert that the HTTP response satisfies the OpenAPI spec
    expect(res.data).toSatisfySchemaInApiSpec("Book");
  });
});