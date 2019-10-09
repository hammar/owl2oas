using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class GeometryContext {
    /// <summary>
    /// Gets or Sets Vocab
    /// </summary>
    [DataMember(Name="@vocab", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@vocab")]
    public string Vocab { get; set; }

    /// <summary>
    /// Gets or Sets Base
    /// </summary>
    [DataMember(Name="@base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@base")]
    public string Base { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GeometryContext {\n");
      sb.Append("  Vocab: ").Append(Vocab).Append("\n");
      sb.Append("  Base: ").Append(Base).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}