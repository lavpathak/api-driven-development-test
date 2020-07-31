package org.openapitools.api;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.context.request.NativeWebRequest;
import java.util.Optional;
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.SpringCodegen", date = "2020-07-31T11:52:49.322726-07:00[America/Phoenix]")

@Controller
@RequestMapping("${openapi.bookService.base-path:}")
public class BookApiController implements BookApi {

    private final NativeWebRequest request;

    @org.springframework.beans.factory.annotation.Autowired
    public BookApiController(NativeWebRequest request) {
        this.request = request;
    }

    @Override
    public Optional<NativeWebRequest> getRequest() {
        return Optional.ofNullable(request);
    }

}
