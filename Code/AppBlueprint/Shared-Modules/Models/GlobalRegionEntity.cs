// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace AppBlueprint.Presentation.Ui.Sdk.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GlobalRegionEntity : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The countries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.CountryEntity>? Countries { get; set; }
#nullable restore
#else
        public List<global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.CountryEntity> Countries { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.GlobalRegionEntity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.GlobalRegionEntity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.GlobalRegionEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "countries", n => { Countries = n.GetCollectionOfObjectValues<global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.CountryEntity>(global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.CountryEntity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::AppBlueprint.Presentation.Ui.Sdk.Client.Models.CountryEntity>("countries", Countries);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
        }
    }
}
#pragma warning restore CS0618
