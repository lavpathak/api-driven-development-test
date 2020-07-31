/* 
 * Book Service API
 *
 * This api is part of Book Service and handles all CRUD operation on book domain object
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NewBook
    /// </summary>
    [DataContract]
    public partial class NewBook :  IEquatable<NewBook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewBook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBook" /> class.
        /// </summary>
        /// <param name="isbn">isbn (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="authors">authors (required).</param>
        public NewBook(string isbn = default(string), string title = default(string), double price = default(double), List<Author> authors = default(List<Author>))
        {
            // to ensure "isbn" is required (not null)
            this.Isbn = isbn ?? throw new ArgumentNullException("isbn is a required property for NewBook and cannot be null");
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for NewBook and cannot be null");
            this.Price = price;
            // to ensure "authors" is required (not null)
            this.Authors = authors ?? throw new ArgumentNullException("authors is a required property for NewBook and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Isbn
        /// </summary>
        [DataMember(Name="isbn", EmitDefaultValue=false)]
        public string Isbn { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name="authors", EmitDefaultValue=false)]
        public List<Author> Authors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewBook {\n");
            sb.Append("  Isbn: ").Append(Isbn).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewBook);
        }

        /// <summary>
        /// Returns true if NewBook instances are equal
        /// </summary>
        /// <param name="input">Instance of NewBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Isbn == input.Isbn ||
                    (this.Isbn != null &&
                    this.Isbn.Equals(input.Isbn))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Isbn != null)
                    hashCode = hashCode * 59 + this.Isbn.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
