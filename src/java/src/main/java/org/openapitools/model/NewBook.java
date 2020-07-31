package org.openapitools.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.model.Author;
import org.openapitools.jackson.nullable.JsonNullable;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * NewBook
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.SpringCodegen", date = "2020-07-31T11:52:49.322726-07:00[America/Phoenix]")

public class NewBook   {
  @JsonProperty("isbn")
  private String isbn;

  @JsonProperty("title")
  private String title;

  @JsonProperty("price")
  private Double price;

  @JsonProperty("authors")
  @Valid
  private List<Author> authors = new ArrayList<>();

  public NewBook isbn(String isbn) {
    this.isbn = isbn;
    return this;
  }

  /**
   * Get isbn
   * @return isbn
  */
  @ApiModelProperty(required = true, value = "")
  @NotNull


  public String getIsbn() {
    return isbn;
  }

  public void setIsbn(String isbn) {
    this.isbn = isbn;
  }

  public NewBook title(String title) {
    this.title = title;
    return this;
  }

  /**
   * Get title
   * @return title
  */
  @ApiModelProperty(required = true, value = "")
  @NotNull


  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public NewBook price(Double price) {
    this.price = price;
    return this;
  }

  /**
   * Get price
   * @return price
  */
  @ApiModelProperty(required = true, value = "")
  @NotNull


  public Double getPrice() {
    return price;
  }

  public void setPrice(Double price) {
    this.price = price;
  }

  public NewBook authors(List<Author> authors) {
    this.authors = authors;
    return this;
  }

  public NewBook addAuthorsItem(Author authorsItem) {
    this.authors.add(authorsItem);
    return this;
  }

  /**
   * Get authors
   * @return authors
  */
  @ApiModelProperty(required = true, value = "")
  @NotNull

  @Valid

  public List<Author> getAuthors() {
    return authors;
  }

  public void setAuthors(List<Author> authors) {
    this.authors = authors;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NewBook newBook = (NewBook) o;
    return Objects.equals(this.isbn, newBook.isbn) &&
        Objects.equals(this.title, newBook.title) &&
        Objects.equals(this.price, newBook.price) &&
        Objects.equals(this.authors, newBook.authors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(isbn, title, price, authors);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NewBook {\n");
    
    sb.append("    isbn: ").append(toIndentedString(isbn)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    price: ").append(toIndentedString(price)).append("\n");
    sb.append("    authors: ").append(toIndentedString(authors)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

